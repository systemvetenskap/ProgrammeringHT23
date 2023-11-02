﻿using System;
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

        const int _thresholdForBonus = 25;
        // Vi har byggt vår slumpgenerator. Den är ett objekt eftersom vi har använt new
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int dieOne, dieTwo, dieThree, dieFour, dieFive, total;
            int ones, twoos, threes, fours, sixes = 0;
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

        }
    }
}