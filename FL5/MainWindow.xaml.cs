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

namespace FL5
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
            string name = "Erik";
            string lastName = "Öberg";
            string address = "Sågstigen";
            string firstResult = "G";
            string secondResult = "U";
            string thirdResult = "G";

            // Jag vill samla alla resultat i en lista / kollektion
            // Vi vill därför göra en array
            // en array är en samling data av SAMMA datatyp

            // hur deklarerar  vi en array?
            string[] results;
            // Alla arrayer har en fast längd
             results = new string[3];
            // siffran anger hur många fack arrayen ska ha

            //Arrayen saknar värden. Det måste vi tilldela
            // Det är nu våra index kommer till användning
            results[0] = "G";
            results[1] = "U";
            results[2] = "G";

            // Vi kan också hämta värden mha index
           // MessageBox.Show(results[1]);
            //results[3] = "G";

            // En kollektions bästa kompis är en loop
            // Ser ni en lista/array/kollektion --- > tänk loop

            // vi börjar med for-loop
            // Den har alltid tre uttryck
            // nr 1 startvärde --> från vilket fack vill vi börja loopa?

            // nr 2 = villkor för att köra vidare eller inte

            // nr 3. Hur stora kliv ska vi ta varje varv i loopen?
            for(int i = 0; i< results.Length; i++)
            {
                //MessageBox.Show(results[i]);
            }

            // en uppmaning!!!!!!!!!!
            // undvik ALLTID inbyggda metoder om du kan bygga dem själv

            // Du får inte använda contains

            // Uppdrag. Undersök om det  finns något moment som är underkänt
            // vi utgår från att alla resultat är godkända

            // räkna. Hur många moment är underkända?
            int countFails = 0, countPasses=0;
            for(int i = 0;i< results.Length; i++)
            {
                if (results[i] == "U")
                {
                   countFails++;
                }
            }
            countPasses = results.Length - countFails;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int countFails = 0;
            // vi tittar på en annan loop
            string[] results = {"U", "G", "U"};

            // Om vi vill undersöka ALLA fack i en lista
            // då använder vi ofta en foreach
            int i = 0;
            foreach(string result in results)
            {
                if(result == "U")
                {
                    countFails++;
                    if(countFails == 2)
                    {
                        results[i] = "G";
                    }
                }
                i++;
            }

            // Undersök om studenten är godkänd på samtliga moment
            foreach (string result in results)
            {
                if (result == "U")
                {
                    // vi kan bryta en loop med en break;
                    break;
                }
            }
            // while
            //do while


        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            // Strängar och arrayer
            // Dessa hör ihop

            // en sträng är en kollektion av tecken
            // tecken = char
            // en kollektion av bokstäver
            // Erik -->
            string name = "Erik Öberg";
            char sign = 'a';
            //name[5] = 'Å';
            foreach(char c in name)
            {
                if (c == ' ')
                {

                }

                if (char.IsWhiteSpace(c))
                {

                }
                MessageBox.Show(c.ToString());
            }
        }
    }
}
