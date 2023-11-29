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

namespace YatzyGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GameEngine _game;
        int[] _dice;
        public MainWindow()
        {
            InitializeComponent();
            _game = new GameEngine();
        }

        private void btnRollDice_Click(object sender, RoutedEventArgs e)
        {
            // Ta reda på. Vilka tärningar har vi sparat?
            bool[] saved = new bool[]
            {
                (bool)chkDiceOne.IsChecked,
                (bool)chkDiceTwo.IsChecked,
                (bool)chkDiceThree.IsChecked,
                (bool)chkDiceFour.IsChecked,
                (bool)chkDiceFive.IsChecked,
            };
            _dice = _game.RollDice(saved);
            DisplayDice();
            CanRollDice();
        }

        private void DisplayDice()
        {
            diceOne.Content = _dice[0];
            diceTwo.Content = _dice[1];
            diceThree.Content =_dice[2];
            diceFour.Content = _dice[3];
            diceFive.Content = _dice[4];
        }

        private void DisplayScores()
        {
            txtOnes.Text = _game.ScoreOnes.ToString();
            txtTwos.Text = _game.ScoreTwos.ToString();

        }

        private void BetOnOnes(object sender, MouseButtonEventArgs e)
        {
            _game.BetOnCategory(1);
            txtOnes.Background = Brushes.Tan;
        }

        private void BetOnCategory(object sender, MouseButtonEventArgs e)
        {
            Label selected = sender as Label;
            string tag = selected.Tag.ToString();
            bool isSuccessful = _game.BetOnCategory(int.Parse(tag));
            if (!isSuccessful)
            {
                MessageBox.Show("Du får inte spara i samma kategori flera gånger.");
            }
            DisplayScores();
            CanRollDice();
        }
        private void CanRollDice()
        {
            btnRollDice.IsEnabled = _game.CanRollDice;

        }
    }
}
