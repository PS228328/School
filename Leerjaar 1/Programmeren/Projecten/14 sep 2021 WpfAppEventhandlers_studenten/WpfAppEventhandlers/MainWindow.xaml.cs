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

namespace WpfAppEventhandlers
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

        private void btStart_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Okay deze eventhandler is goed gekoppeld!");
        }

        //Door middel van een messagebox verschijnt er een melding

        private void rbStart_Checked(object sender, RoutedEventArgs e)
        {
            rbStart.Visibility = Visibility.Hidden;
        }

        //Door het commando visibility in te voeren, kun je ervoor zorgen dat er iets verdwijnt. In dit geval de radiobutton.

        private void cmbGridColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem comboxItemColor = (ComboBoxItem)cmbGridColor.SelectedItem;
            string comboBoxColor = comboxItemColor.Content.ToString();
            switch (comboBoxColor)
            {
                case "Gray":
                    cmbGridColor.Foreground = Brushes.Blue;
                    break;
                case "Blue":
                    cmbGridColor.Foreground = Brushes.Blue;
                    break;
                case "Orange":
                    cmbGridColor.Foreground = Brushes.Blue;
                    break;
                case "Green":
                    cmbGridColor.Foreground = Brushes.Blue;
                    break;
                default:
                    MessageBox.Show("This should never be happened!");
                    break;
            }

        }

        private void Joris_MouseEnter(object sender, MouseEventArgs e)
        {
            Joris.Width = 100;
            Joris.Height = 200;
        }

        private void Joris_MouseLeave(object sender, MouseEventArgs e)
        {
            Joris.Width = 300;
            Joris.Height = 40;
        }

        //UITLEG: Door middel van het commando MouseEnter en MouseLeave kun je een button zo programmeren dat deze groter of kleiner wordt.

        private void btStart_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Oke, deze heb je na 175 uur gekoppeld! :)");
        }

        private void btZelf_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Doe goed je best!");
        }
    }
}
