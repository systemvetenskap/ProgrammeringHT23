using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShuffleTheName
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // https://edabit.com/challenge/c4W4BNymgCC5WkfHp
        public MainWindow()
        {
            InitializeComponent();
        }
        private string NameShuffle(string name)
        {
            string firstname = string.Empty, lastname = "";
            bool isFirstname = true;
            // en sträng är en samling bokstäver
            // array of chars

            // första steget --> leta upp mellanslaget
            foreach (char letter in name)
            {
                if (char.IsWhiteSpace(letter))
                {
                    // vi har hittat mellanslag
                    // det betyder att allt som hädanefter kommer
                    // är vårt efternamn
                    isFirstname = false;
                    // vi är klara för stunden. Hoppa till nästa varv i loopen
                    continue;
                }
                if (isFirstname)
                {
                    firstname += letter;
                }
                else
                {
                    lastname += letter;
                }
            }
            txtName.Text = firstname + "från metoden";
           return  $"{lastname} {firstname}";
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string fullname = NameShuffle("Erik Öberg");
            fullname = NameShuffle("Donald Trump");
            fullname = NameShuffle("Rosie O'Donnell");
            fullname = NameShuffle(name);

        }
    }
}
