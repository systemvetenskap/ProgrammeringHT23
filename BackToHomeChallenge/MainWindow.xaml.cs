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

namespace BackToHomeChallenge
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
        // https://edabit.com/challenge/qwPdNdEtpNpMiSTRN
        private void button_Click(object sender, RoutedEventArgs e)
        {
            bool result;
            result = BackToHome("NEWE"); // false
            result = BackToHome("NENESSWW"); // true
            result = BackToHome("NEESSW"); // false
            result = BackToHome("SSSSSSSSSSNNNNNNNNNN"); // true
        }

        private bool BackToHome(string directions)
        {
            bool result = false;
            int x = 0, y = 0;
            Point point = new Point(0, 0);
            
            // Hur????
            // Börja med att loopa igenom instruktionerna
            foreach (char direction in directions)
            {
                switch (direction)
                {
                    case 'N':
                        y++;
                        break;
                    case 'S':
                        y--;
                        break;
                    case 'W':
                        x++;
                        break;
                    case 'E':
                        x--;
                        break;
                }
            }
            result = x == 0 && y ==0;

            return result;
        }
    }
}
