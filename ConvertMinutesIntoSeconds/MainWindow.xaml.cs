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

namespace ConvertMinutesIntoSeconds
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
        // https://edabit.com/challenge/bizjGL4wyd8PwR4Ke
        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            // vilka datatyper efterfrågas?
            // det är integers för minuter
            int minutes, seconds;
            // skapar en konstant

            // en konstant är en variabel som aldrig kan byta värde
            const int secondsPerMinute = 60;

            // unassigned variable?
            // deklarerar = skapar
            // tilldela värde
            minutes = 3; // 180

            seconds = minutes * secondsPerMinute;

            
        }
    }
}
