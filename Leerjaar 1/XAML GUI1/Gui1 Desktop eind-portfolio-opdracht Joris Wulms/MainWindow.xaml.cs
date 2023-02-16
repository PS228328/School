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

namespace Gui1_Desktop_eind_portfolio_opdracht_Joris_Wulms
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (tbVoornaam.Text != "" && tbAchternaam.Text != "" && tbStraatHuisnr.Text != "" && tbPostcode.Text != "" && tbWoonplaats.Text != "" && tbTelefoonnr.Text != "" && tbEmail.Text != "" && tbCombobox.Text != "" && tbGeboortedatum.Text != "" && tbAfspaakdatum.Text != "" && tbCombobox.Text != "")
            {
                if (checkboxav.IsChecked == false)
                {
                    MessageBox.Show("Ga je akkoord met de algemene voorwaarden?");
                    return;
                }

                Inschrijvingvoltooid.Visibility = Visibility.Visible;
                Inschrijvingvoltooid.Text = "Beste " + tbVoornaam.Text + " " + tbAchternaam.Text + ", dank voor je inschrijving!";
            }
            else
            {
                MessageBox.Show("Je hebt nog niet alle velden ingevuld!");
                return;
            }

        }
    }
}
