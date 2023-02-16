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

namespace SimplePlaying
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random myRandomizer = new Random();
        Random myOperator = new Random();
        int vraagnummer = 0;
        int intgetal1;
        int intgetal2;
        int intuitkomst;

        int counter = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            rekensomblok.Text = "";
            btStart.Visibility = Visibility.Hidden;
            vraagnummer++;

            Vraagbalk.Visibility = Visibility.Visible;
            Vraagbalk.Text = "Vraag " + vraagnummer + " / 10";
            Volgende.Visibility = Visibility.Visible;
            getal1.Visibility = Visibility.Visible;
            getal2.Visibility = Visibility.Visible;
            getaluitkomst.Visibility = Visibility.Visible;
            operators.Visibility = Visibility.Visible;
            isgelijkaan.Visibility = Visibility.Visible;

            intgetal1 = myRandomizer.Next(1, 21);
            intgetal2 = myRandomizer.Next(1, 21);

            getal1.Text = intgetal1.ToString();
            getal2.Text = intgetal2.ToString();
        }

        private void Volgende_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                intgetal1 = Int32.Parse(getal1.Text);
                intgetal2 = Int32.Parse(getal2.Text);
                intuitkomst = Int32.Parse(getaluitkomst.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Je hebt geen geldig getal ingevuld!");
                return;
            }

            int uitkomst;

            uitkomst = intgetal1 + intgetal2;

            if (intuitkomst == uitkomst)
            {
                counter++;
            }

            getaluitkomst.Text = "";
            vraagnummer++;
            Vraagbalk.Text = "Vraag " + vraagnummer + " / 10";

            intgetal1 = myRandomizer.Next(1, 21);
            intgetal2 = myRandomizer.Next(1, 21);

            getal1.Text = intgetal1.ToString();
            getal2.Text = intgetal2.ToString();

            if (vraagnummer == 11)
            {
                Laatuitslagzien();
                return;
            }
        }

        private void Laatuitslagzien()
        {
            rekensomblok.Text = "Je hebt " + counter + " vragen goed beantwoord";

            Vraagbalk.Visibility = Visibility.Hidden;
            Volgende.Visibility = Visibility.Hidden;
            getal1.Visibility = Visibility.Hidden;
            getal2.Visibility = Visibility.Hidden;
            getaluitkomst.Visibility = Visibility.Hidden;
            operators.Visibility = Visibility.Hidden;
            isgelijkaan.Visibility = Visibility.Hidden;

            if (counter > 8)
            {
                Geslaagdgezakt.Text = "GESLAAGD!";
                Geslaagdgezakt.Foreground = Brushes.Green;
            }
            else
            {
                Geslaagdgezakt.Text = "GEZAKT!";
                Geslaagdgezakt.Foreground = Brushes.Red;
            }
        }
    }
}
