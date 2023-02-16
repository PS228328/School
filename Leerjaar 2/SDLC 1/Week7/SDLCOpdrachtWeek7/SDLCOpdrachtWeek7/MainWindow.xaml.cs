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

namespace SDLCOpdrachtWeek7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Valutaconverter converter = new Valutaconverter();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tbxLinks_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbxLinks.Text == "")
            {
                return;
            }
            try
            {
                converter.WijzigBedragLinks(Convert.ToDecimal(tbxLinks.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Vul aub een geldige waarde in!");
                return;
            }
            tbxRechts.Text = converter.BedragRechts.ToString("0.00");
        }

        private void tbxRechts_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbxRechts.Text == "")
            {
                return;
            }
            try
            {
                converter.WijzigBedragRechts(Convert.ToDecimal(tbxRechts.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Vul aub een geldige waarde in!");
                return;
            }
            tbxLinks.Text = converter.BedragLinks.ToString("0.00");
        }

        private void radiobuttonLinks_Checked(object sender, RoutedEventArgs e)
        {
            if (rbEuroLinks.IsChecked == true)
            {
                converter.WijzigValutaLinks(0);
            }
            else if (rbDollarLinks.IsChecked == true)
            {
                converter.WijzigValutaLinks(1);
            }
            else if (rbYenLinks.IsChecked == true)
            {
                converter.WijzigValutaLinks(2);
            }
            else
            {
                MessageBox.Show("Selecteer aub een koers!");
            }
            tbxLinks.Text = converter.BedragLinks.ToString("0.00");
        }

        private void radiobuttonRechts_Checked(object sender, RoutedEventArgs e)
        {
            if (rbEuroRechts.IsChecked == true)
            {
                converter.WijzigValutaRechts(0);
            }
            else if (rbDollarRechts.IsChecked == true)
            {
                converter.WijzigValutaRechts(1);
            }
            else if (rbYenRechts.IsChecked == true)
            {
                converter.WijzigValutaRechts(2);
            }
            else
            {
                MessageBox.Show("Selecteer aub een koers!");
            }
            tbxRechts.Text = converter.BedragRechts.ToString("0.00");
        }

    }
}
