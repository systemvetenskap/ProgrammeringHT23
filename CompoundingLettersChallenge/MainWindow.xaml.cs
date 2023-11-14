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

namespace CompoundingLettersChallenge
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string accum = Accum("abcd");

            // A-Bb-Ccc-Dddd
            // a-bb-ccc-dddd-

        }

        private string Accum(string text)
        {
            //Todo: Fixa att första bokstaven är stor
            // tips. char.ToUpper()
            // char.ToLower()
            // Fixa dessutom att sista strecket försvinner.
            // a-bb-ccc-dddd-  <-- ta bort strecket i slutet

            // En sträng är en array of chars
            // en array har indexvärden
            // 0 för första facket
            string word = string.Empty;
            // vi  vill loopa igenom texten
            for (int i = 0; i < text.Length; i++)
            {
                // idé
                // vi testar att lägga en loop inuti en annan loop
                for (int j = 0; j <= i; j++)
                {
                    word += text[i];
                }
                word += "-";
            }
            
            return text;
        }
    }
}
