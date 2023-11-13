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

namespace FL7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Ship _ship;
        Tortuga _tortuga = new Tortuga();

        // Vi vill skapa flera pirater
        // Därför gör vi en kollektion, eller lista
        public MainWindow()
        {
            InitializeComponent();
            _ship = new Ship();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // Vi har en idé om att skapa pirater
            // vi vill kunna ha flera olika pirater
            // som alla har olika egenskaper
            string name2 = "Esmeralda Grout";
            string rank = "Captain";

            string name = "Jack Sparrow";
            string rank2 = "Boatsman";

            // lösningen
            // vi skapar en klass som håller information
            // om våra pirater

            // Vi tar ett smart sätt istället!
            Pirate pirate = new Pirate();
            // vi tilldelar värden till vår pirats egenskaper
            // testar punktnotation first.
            pirate.Name = "Jack Sparrow";
           // pirate.Rank = "Captain";
            // Vi vill skapa en ny pirat
            // Vi tilldelar värden med en initializer
            Pirate pirate2 = new Pirate()         
            {           Name = "Esmeralda",            
            //   Rank = "Boatsman"
            };

            // vi kan ändra värden
            pirate2.Name = "Esmeralda Grout";
            // Alla värden kan ändras eftersom våra properties har 
            // get och set
            // pirate2.Rank = "Captain";
            Pirate pirate3 = new Pirate("Jack Sparrow", 1728);
            Pirate pirate4 = new Pirate("Jacsdfgdsfgk Sparrow", 1544);

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int[] numbers = new int[23];
            
            string name = txtName.Text;
            Pirate pirate = new Pirate(name, 1725);
            // Vi lägger till saker i en lista med Add
            _ship.Crew.Add(pirate);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            List<Pirate> pirates = new List<Pirate>();
            pirates = _tortuga.GetPiratesByLevel(10, 1);
            _ship.Crew = pirates;
            pirates = _tortuga.GetPiratesByLevel(1, 5);
            _ship.Crew.AddRange(pirates);

            Person person = new Person();
            person.Firstname = "Erik";
            person.Lastname = "Öberg";

            Person person1 = new Person()
            {
                Firstname = "Lill-Erik",
                Lastname = "Öberg"
            };

            Person person2 = new Person("Erik", "Öberg");
            MessageBox.Show(person1.Greet());
            MessageBox.Show(person.Greet());
        }
    }
}
