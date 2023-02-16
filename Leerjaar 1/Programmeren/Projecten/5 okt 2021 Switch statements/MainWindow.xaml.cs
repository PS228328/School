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

namespace _5_okt_2021_Switch_statements
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

        private void btGo_Click(object sender, RoutedEventArgs e)
        {
            string invoer = tbInvoer.Text;
            string invoerUpper = invoer.ToUpper();

            if (invoerUpper == "A")
            {
                MessageBox.Show("Dit is de eerste letter van het alfabet");
            }
            else if(invoerUpper == "B")
            {
                MessageBox.Show("Dit is de tweede letter van het alfabet");
            }
            else if (invoerUpper == "C")
            {
                MessageBox.Show("Dit is de derde letter van het alfabet");
            }
            else if (invoerUpper == "D")
            {
                MessageBox.Show("Dit is de vierde letter van het alfabet");
            }
            else
            {
                MessageBox.Show("Je hebt geen letter van het alfabet ingevuld");
            }
        }

        private void btSwitch_Click(object sender, RoutedEventArgs e)
        {
            string invoer = tbInvoer.Text;
            string invoerUpper = invoer.ToUpper();

            switch (invoerUpper)
            {
                case "Appel":
                    MessageBox.Show("Dit is de eerste letter van het alfabet");
                    break;
                case "Banaan":
                    MessageBox.Show("Dit is de tweede letter van het alfabet");
                    break;
                case "Citroen":
                    MessageBox.Show("Dit is de derde letter van het alfabet");
                    break;
                case "Druiven":
                    MessageBox.Show("Dit is de vierde letter van het alfabet");
                    break;
                case "Eten":
                    MessageBox.Show("Dit is de vijfde letter van het alfabet");
                    break;
                default:
                    MessageBox.Show("Dit is geen letter van het alfabet");
                    break;
            }
        }
    }
}
