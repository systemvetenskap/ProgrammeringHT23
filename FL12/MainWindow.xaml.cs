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

namespace FL12
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
        }

        private void Laget_Click(object sender, RoutedEventArgs e)
        {
            int[] numbers = new int[5];

            List<Player> team = new List<Player>();
            Player player = new Player("Kosovare Aslani", 9);

            for (int i = 0; i <= 10; i++)
            {
                player = new Player("X");
                team.Add(player);
            }
           
            player = team[9];
            SetNumberForPlayer(team);
        }

        private void SetNumberForPlayer(List<Player> team)
        {
            int number = 1;
            foreach (Player player in team)
            {
                player.Number = number;
                number++;
            }
        }
    }
}
