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

namespace FL2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // instansvariabel, field

        // då blir det en annan naming convention
        string _fullName;
        int _count = 1; // Ge variabeln ett startvärde

        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnOk2_Click(object sender, RoutedEventArgs e)
        {
            // datatyp för siffror
            // Det finns flera olika, men vi kommer främst jobba med 2 stycken

            // vi börjar med heltal = integer
            // -2,147,483,648 to 2,147,483,647
            // -2147483648
            int dateOfBirth, age, realAge, currentYear; //
            // vi måste parsa = konvertera värdet från sträng till int
            dateOfBirth  = int.Parse(TxtName.Text);

            // vill istället hämta nuvarande år
            currentYear = DateTime.Now.Year;
            age = currentYear - dateOfBirth;

            MessageBox.Show($"Du är {age} år gammal");

            // aritmetiska operatorer
            // + - * /
            realAge = age + 5;
            age += 5;
            age *= 2;

        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            // kan vi göra så att koden inte pratar med gränssnittet direkt?
            // Vi kanske kan spara undan värdet i en variabel
            // en variabel = liten minneslåda
            // C# är ett hårt typat programmeringsspråk

            // Vi MÅSTE bestämma vilken datatyp våra variabler ska ha
            // accessor (valfri, eller den får ett standardvärde)
            // nästa sak vi måste sätta är datatyp
            // sedan  väljer vi namn


            // Vi DEKLARERAR variabler
            // datatyp   namn
            string firstName, lastName = TxtLastName.Text;          // Namngivning. Följer en konvention
             
            // alla variabler måste börja med liten bokstav
            // sammansatta ord, då ska nästa börja med stor bokstav
            // camelCase

            // Vi tilldelar  värde till vår variabel
            firstName = TxtName.Text;  

            // Om variabeln saknar värde är den NULL
            // det som finns bortom universums slut

            // Stränginterpolation
            // konkatenera två strängar
            // dessa kan läggas i en egen variabel
            _fullName = firstName + " " + lastName;
            
            _fullName = _fullName + "!";
            // fast vi skriver det på detta sättet istället:
            _fullName += "!";
            MessageBox.Show($"Hej {_fullName}");

            // Variabler har en räckvidd. Den lever lokalt inom sin lilla låda
            // låda = scope
            // låda = kodblock {   }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            _count *=3;
            // detta kan vi istället skriva med ++
           // _count++;
            TxtLastName.Text = _count.ToString();
            int length=12;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // flyttal
            // decimaltal
            // i c# är kommatecken en punkt
            double length; // = 1.73;
            length = double.Parse(TxtName.Text);
            //length = 101.45;

            int divider=2;
            // Vi kan casta
            // casta = för stunden blunda eller konvertera
            double result = (int)(length/divider);
            TxtLastName.Text =Math.Round(length,1).ToString();



        }
    }
}
