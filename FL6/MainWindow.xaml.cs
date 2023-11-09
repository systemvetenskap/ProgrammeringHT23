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

namespace FL6
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
            // Vi ska titta på metoder

            // en metod är något som GÖRS
            // en variabel har/håller något
            // en property beskriver något

            // metoder följer liknande struktur som en variabel

            // börja med att skapa ett metodhuvud
            // Vad metoden heter
            // den beskriver vad metoden svarar med för datatyp = utdata
            // den beskriver vilka eventuella indataparametrar som vi behöver

            // GetIceCream
            // Vilken glass då?
            // GetIceCream("Cornetto") // indataparameter
            // --> En glass IceCream

            // en metod ska ha ett uppdrag
            string message = SayHello("Hejhopp");
            SayHello();
            message = SayHello(numberOfEchos: 10);
            message = Talk("Land i sikte", 150);
            
        }

        // Alla metoder måste inte returnera värden
        // Då säger vi att den returnerar void
        // tomrum

        /// <summary>
        /// Tar emot ett valfritt meddelande
        /// </summary>
        /// <param name="message">Det meddelande som skickas ut i piratformat</param>
        /// <returns></returns>
        private string SayHello(string message)
        {
            return message + " ahoy!!";
        }
        /// <summary>
        /// Standard piratmeddelande
        /// </summary>
        /// <returns></returns>
        private string SayHello()
        {
            return  "Hello ahoy!!";
        }
        private string SayHello(int numberOfEchos)
        {
            string message = "";
            for (int i = 0; i < numberOfEchos; i++)
            {
                message += SayHello();
            }
            return message;
        }

        private string Talk(string message, int echoes=3)
        {
            string parrotMessage = "Kraa ";
            string[] parts = message.Split(' ');

            // en array -- > tänk loop
            // Vilken loop?
            // for-loop
            for (int i = 0; i<echoes; i++)
            {
                parrotMessage += " " + parts[parts.Length-1];
            }
            parrotMessage += " Ahoy!!";
            return parrotMessage;
        }


    }
}
