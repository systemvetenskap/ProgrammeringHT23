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

namespace Uppgift2
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

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            // Vi kan komma åt objekt i C# genom att använda deras namn (objektet) och 
            // deras egenskap

            // Genom att skriva text efter likamedtecknet kan vi
            // tilldela ett värde till egenskapen Text på vår textruta (objektet)
           // TxtName.Text = "Muhamed";

            // Vi ville ju hämta värdet, inte ändra!
            // Vi har gjort vår första stränginterpolation
            MessageBox.Show($"Hej {TxtName.Text}. Hoppas du mår bra!");

            // Det är samma sak som att plussa ihop strängarna +
            MessageBox.Show("Hej " + TxtName.Text + " Hoppas du är ok");
        }
    }
}
