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

namespace ProfitableGamble
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
            // net_outcome = probability_of_winning * prize - cost_of_playing.
            double probability=0.5, prize=50, cost = 9, netOutcome;
            // undersök om affären är lönsam ja eller nej --> bool
            bool isProfitable;
            probability = slider.Value;
            netOutcome = probability * prize - cost;
            isProfitable = netOutcome > 0;

            // jag vill skriva om den är lönsam och visa lönsamheten
            MessageBox.Show($"lönsamheten blir {Math.Round(netOutcome,0)}");

            if (isProfitable)
            {
                // ja det är lönsamt
            }
             else
            {
                // nej, satsa på något annat
            }
        }
    }
}
