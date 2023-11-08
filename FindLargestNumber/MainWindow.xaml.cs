using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace FindLargestNumber
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void button_Click(object sender, RoutedEventArgs e)
        {
            // array
            int[] numbers = { 4, 5, 1, 3, 9 };
            int largestNumber = 0;

            // leta efter ett tal som är störst
            Array.Sort(numbers);
            largestNumber = numbers[numbers.Length - 1];

            // visa detta tal
            MessageBox.Show(largestNumber.ToString());
            // Genom att  jag hårdkodar ett index 
            // då blir inte min lösning dynamisk
            // Första steget --> lägg svaret i en variabel
        }
        public MainWindow()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // Array
            int[] numbers =    { 4, 5, 1, 3, 9 };
            int largestNumber = 0;
            // Vi måste göra ett metodanrop
            largestNumber = GetLargestNumber(numbers);
           
        }

        // Accessor = kan vara default tom
        // andra uttrycket i vårt metodhuvud är returvärdet
        private int GetLargestNumber(int[] numbers)
        {
            int largestNumber = int.MinValue;
            // då ska du alltid tänka loop!!!

            // for --> den är alltid funkis
            // den ger mig koll på indexvärdet

            // vi testar en foreach
            foreach (int number in numbers)
            {
                // vi måste jämföra
                // är det tal som nu finns i variabeln number vårt största tal?
                // om så, kom ihåg vilket tal
                if (number >= largestNumber)
                {
                    largestNumber = number;
                }
            }
            // här skickar vi ut värdet  från metoden
            // = returvärde
            return largestNumber;
        }
    }
}
