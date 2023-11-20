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

namespace FL11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _counter = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // skillnad mellan variabel och objekt?
            // en variabel är en minnesask som håller koll på värden som jag vill lagra

            // datatyp   namnet
            int count = 0;

            Car car;

            car = new Car();
            car.Make = "Audi";
            car.Model = "Q5";
            car.LicenceNumber = "ABC 123";

            car.FillTank(43);

            Car car2 = new Car();
            car2.Make = "Opel";
            int[] numbers = new int[2];
            // [0][1]
            // en array är statisk och kan inte utöka antalet fack
            numbers[0] = 1;
            numbers[1] = 2;
            // krasch!!!!
            //numbers[2] = 3;

            // En lista däremot- Den är dynamisk
            List<int> numbers2 = new List<int>();
            numbers2.Add(1);
            numbers2.Add(1);
            numbers2.Add(1);
            numbers2.Add(1);
            numbers2.Add(1);

            Car[] cars = new Car[2];
            cars[0] = car;
            cars[1] = car2;

            // for-loop
            // bra när du vill
            // 1. Hålla koll på indexvärdet

            string[] firstnames = { "Erik", "Anna" };
            string[] lastnames = { "Öberg", "Persson" };
            for (int i = 0; i < firstnames.Length; i++)
            {
                string fullname = $"{firstnames[i]} {lastnames[i]}";
            }

            // 2. Vi kan ändra värdet i loopen

            for (int i = 0; i < firstnames.Length; i++)
            {
                firstnames[i] = $"{firstnames[i]} {lastnames[i]}";
            }

            // 3. När vi vill kunna påverka start och slut i loopen

            for (int i = 1; i < firstnames.Length; i += 3)
            {
                firstnames[i] = $"{firstnames[i]} {lastnames[i]}";
            }
            string signs = "abcxsaslra";
            if (signs.Contains('x'))
            {

            }

            if (FindNeedle(signs, 'x'))
            {

            }
        }
        private bool FindNeedle(string haystack, char needle)
        {
            foreach (char letter in haystack)
            {
                if (letter == needle)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
