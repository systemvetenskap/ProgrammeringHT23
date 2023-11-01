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

namespace AreNumbersEqual
{
    // https://edabit.com/challenge/e7Bxnaspmr3kMPYWg
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            // Uppdrag
            // undersök om två tal är lika,
            // om de är lika säg true
            // annars säg false

            // en bool svarar ja eller nej
            // sant eller falskt
            bool isEqual;
            int firstNumber = int.Parse(txtFirst.Text);
            double secondNumber = double.Parse(txtSecond.Text);

            //if(txtFirst.Text == txtSecond.Text)
            //{
            //    // de är lika
            //}

            // Styrande satser
            // if (logiskt uttryck) {

            //}

            // ett logiskt uttryck valideras alltid som sant eller falskt

            // jämför --> dubbla likamed
            if (firstNumber == secondNumber)
            {
                //MessageBox.Show("Talen är lika");
            }
            else if (firstNumber > secondNumber)
            {
                //MessageBox.Show("första talet är störst");
            }
            else if (firstNumber < secondNumber) 
            {
              //  MessageBox.Show("andra talet är störst");
            }
            // logiska operatorer
            // ==
            // >
            // <
            // >=
            // if-satser
            // Datorn undersöker ALLTID alla if-satser
            // däremot, kan den hoppa över else if om det är som så
            // att den har hittat ett villkor som uppfylls = sant

            bool isSober = false, hasCorrectSpeed = true;
            int currentSpeedLimit = 90, currentSpeed=130;

            // undersöker ev fortkörning
            hasCorrectSpeed = currentSpeed <= currentSpeedLimit;

            // Vi kan lägga på hur många logiska uttryck som helst

            if (isSober || hasCorrectSpeed)
            {
                // var så god. Kör vidare
            }
            else
            {
                // du får inte köra mer, eller får böter
            }

            // Vi måste tänka om!
            if (!isSober) 
            { 
               // fy skäms
            }
            if(!hasCorrectSpeed)
            {
                // betala böter
            }

            // !false
            // it's funny because it's true

            // en if-sats kan nästlas
            if (!hasCorrectSpeed)
            {
                int speedError = currentSpeed - currentSpeedLimit;
                // undersök hur mycket böter jag får

                // eller kanske till och med förlorar mitt körkort
                // 10 km eller mindre = 1000 kr i böter
                if (speedError <= 10)
                {
                    // 1000 kr
                }
                else if (speedError > 10 && speedError < 30)
                {
                    // 2000 kr
                }
                else
                {
                    // 4000 kr + förlorat körkort
                }

                // Tips från coachen
                // börja med yttervärden!
            }
            bool iLikeRed;
            iLikeRed = (bool)rdoColorRed.IsChecked;
        }
    }
}
