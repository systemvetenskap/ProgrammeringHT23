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

namespace YatzeeGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {  // Vi jobbar objektorienterat...
       // Nyckelordet är då new
        private readonly Random _random = new();
        // gränsvärdet är 63 poäng
        /// <summary>
        /// Spelmotor
        /// </summary>
        GameEngine _gameEngine = new GameEngine();

        const int _thresholdForBonus = 25;
        // Vi har byggt vår slumpgenerator. Den är ett objekt eftersom vi har använt new
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int dieOne, dieTwo, dieThree, dieFour, dieFive, total;
            int ones, twoos, threes, fours, fives=0, sixes = 0;
            // Hur kan mina tärningar få värden?

            // vi introducerar slumpvärden
            // Sätter 7 som högsta värde, eftersom jag vill ha 1-6 där upper är exclusive
            dieOne = _random.Next(1,7);
            dieTwo = _random.Next(6)+1;
            dieThree = _random.Next(1, 7);
            dieFour = _random.Next(1, 7);
            dieFive = _random.Next(1, 7);


            // Skriv ut våra värden i gränssnittet
            diceOne.Content = dieOne;
            diceTwo.Content = dieTwo;
            diceThree.Content = dieThree;
            diceFour.Content = dieFour;
            diceFive.Content = dieFive;


            // Beräkna totalsumman
            total = dieOne + dieTwo + dieThree + dieFour + dieFive;

            // Vi ska samla på sexor
            sixes = Convert.ToInt32(txtSixes.Text);

            // vi vill nu kontrollera att användaren räknat rätt

            if (sixes ==0 || sixes==12 || sixes == 18 || sixes == 24 || sixes == 30)
            {
                // yes!
            }
            else
            {
                MessageBox.Show("felaktig inmatning");
            }
            // Kan vi tvinga den att följa sexans gångertabell??
            // det kan vi ta reda på  genom att använda modulus
            if (sixes % 6 != 0 && sixes <= 30)
            {
                // no
                MessageBox.Show("felaktig inmatning");

            }

            


            bool hasBonus = total >= _thresholdForBonus;

            if (hasBonus)
            {
                total += 50;
                txtBonus.Text = "50";
            }

            txtTotal.Text = total.ToString();
            // DRY
            // don't repeat yourself
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int[] dice = new int[5];
            bool[] savedDice = { false, false, false, false, false };
            int total = 0;

            for (int i = 0; i < dice.Length; i++)
            {
                // undersök om tärningen är sparad eller inte
                if (!savedDice[i])
                {
                    dice[i] = _random.Next(1,7);
                }
            }

            // Beräkna totalsumman av tärningarna
            // Vi vill räkna totalsumman, men bara för vissa tärningar
            foreach (int die in dice)
            {
                // räkna enbart femmor
                if (die==5)
                {
                    total += die;
                }
            }

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            // Koppla ihop vårt spel med spelmotorn

            // spelmotorn är en egen klass
            // som heter GameEngine
            // För att komma åt en klass måste vi skapa ett objekt
            // Objekt skapr vi med att skriva new
            // Vi skapar en variabel
            // Observera!!!
            // new betyder ny
            int[] dices =  _gameEngine.RollDice();
            DisplayDice(dices);
            bool[] savedDices = { true, false, true, false, false };
            _gameEngine.SaveDice(savedDices);
            dices = _gameEngine.RollDice();
            DisplayDice(dices);
            

        }

        private void DisplayDice(int[] dice)
        {
           diceOne.Content = dice[0];
           diceTwo.Content = dice[1];
           diceThree.Content = dice[2];
           diceFour.Content = dice[3];
           diceFive.Content = dice[4];
        }
    }
}
