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

namespace FL9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Farm _farm = new Farm(5);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // animals(2, 3, 5) ➞ 36
            //int count = CountAnimalLegs(chickens: 2, cows 3, pigs: 5); // 36

            // Vi vill göra ett objekt av klassen Cow
            Cow cow = new Cow("Rosamunda");
            Animal chicken = new Chicken("Kackan");
            
            

            Animal pig = new Pig(); // Skapar en  gris av sorten Animal
            _farm.Animals.Add(pig);
            _farm.Animals.Add(chicken);
            int count = _farm.CountTotalLegs();
           // _farm.Cow = cow;

            // Välkommen alla mina små kycklingar
            // Målsättning
            // vi vill bygga världens största farm
            // > 100 000 stycken kossor
        }

        // The farm problem
        // https://edabit.com/challenge/4AaTbg5NuA8eSijcr

        private int CountAnimalLegs(int y, int cows, int pigs)
        {
           return y * 2 + cows * 4 + pigs * 4;
        }

        private int CountAnimalLegs(int twoLegged, int fourLegged)
        {
            return twoLegged * 2 + fourLegged * 4;
        }
    }
}
