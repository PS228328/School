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
using System.Windows.Threading;

namespace WPF_project_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int _countgo = 60;
        double _subtotaal;
        double _totaalgegeven = 0;
        DispatcherTimer _countdown = new DispatcherTimer();
        bool _changechecker = false;

        double[] myArrayMoney = { 200, 100, 50, 20, 10, 5, 2, 1, 0.5, 0.2, 0.1, 0.05 };

        public MainWindow()
        {
            InitializeComponent();
            ct5.Text = "0";
            ct10.Text = "0";
            ct20.Text = "0";
            ct50.Text = "0";
            eur1.Text = "0";
            eur2.Text = "0";
            eur5.Text = "0";
            eur10.Text = "0";
            eur20.Text = "0";
            eur50.Text = "0";
            eur100.Text = "0";
            eur200.Text = "0";
            _countdown.Start();
            _countdown.Interval = TimeSpan.FromMilliseconds(1000);
            _countdown.Tick += Countdown_Tick;
        }

        private void Countdown_Tick(object sender, EventArgs e)
        {
            double width = myGrid.ActualWidth - 30;
            double splitsixty = width / 60;
            double realwidth = _countgo * splitsixty;
            _countgo--;

            tbTijd.Width = realwidth;
            if (_countgo == 0)
            {
                _countdown.Stop();
                this.Close();
            }

            //Eerst de width opmeten, dan die width delen door 60. Je krijgt dan 60 stukjes waarvan elke seconde er een weggaat.
            //Countgo wordt steeds minder waardoor de realwidth dus ook steeds lager word. Zodra countgo 0 is, dan sluit de applicatie.
        }
       
        private void setTimeToSixty()
        {
            _countgo = 60;
            tbTijd.Width = myGrid.ActualWidth - 30;
            //Method voor verschillende buttons, deze zorgt ervoor dat de timer weer teruggaat naar 60 als iemand iets doen.
        }

        private void btBestel_Click(object sender, RoutedEventArgs e)
        {
            setTimeToSixty();
            string selected = "";
            string[] strprice = {""};

            int counter = 0;

            ComboBoxItem SelectedBike = (ComboBoxItem)cbBestel.SelectedItem;
            ComboBoxItem SelectedVerzekering = (ComboBoxItem)cbVerzekering.SelectedItem;
            ComboBoxItem SelectedService = (ComboBoxItem)cbServices.SelectedItem;
            if (SelectedBike != null)
            {
                selected = SelectedBike.Content.ToString();
                strprice = selected.Split(' ');
                counter++;
            }
            
            if (SelectedVerzekering != null)
            {
                selected = SelectedVerzekering.Content.ToString();
                strprice = selected.Split(' ');
                counter++;
            }

            if (SelectedService != null)
            {
                selected = SelectedService.Content.ToString();
                strprice = selected.Split(' ');
                counter++;
            }

            //Hierboven wordt gecheckt of de waarde die we ophalen uit de comboboxen niet null zijn. Als dit wel zo is kunnen we er namelijk niks mee.

            if (counter == 1)
            {
                double price = 0;

                double totaalprijs = 0;

                int dagen;

                if (selected != "")
                {
                    try
                    {
                        dagen = Int32.Parse(tbDagen.Text);
                        price = Double.Parse(strprice[2]);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Vul aub in hoeveel dagen je de fiets wilt huren!", "Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }

                    if (dagen == 0)
                    {
                        MessageBox.Show("Vul aub in hoeveel dagen je de fiets wilt huren!", "Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }

                    totaalprijs = price * dagen;
                    lbArtikelen.Items.Add(strprice[0] + "   Prijs p/d: " + strprice[1] + " " + price.ToString("0.00") + "   Aantal dagen: " + dagen + "   Totaalprijs: " + "€ " + totaalprijs.ToString("0.00"));
                    _subtotaal += totaalprijs;
                }
                tbsubtotaal.Text = "€ " + _subtotaal.ToString("0.00");
                tbDagen.Text = "1";
                resetComboBox();

                //Omdat er maar een combobox tegelijk geselecteerd mag zijn, moet de aangemaakte counter precies 1 zijn. Doormiddel van de split kunnen we rekenen met de prijs en een string opbouwen
            }   
            else
            {
                MessageBox.Show("Selecteer aub een optie!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void lbArtikelen_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            setTimeToSixty();
            string item = (string)lbArtikelen.SelectedItem;
            if (item == null)
            {
                MessageBox.Show("Dubbelklik op een item om het te verwijderen", "Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            MessageBoxResult deleteornot = MessageBox.Show("Weet je zeker dat je het item wilt verwijderen?", "Verwijder item", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (deleteornot == MessageBoxResult.Yes)
            {
                string[] strprice = item.Split(' ');
                double minus = Double.Parse(strprice[16]);

                _subtotaal -= minus;
                tbsubtotaal.Text = "€ " + _subtotaal.ToString("0.00");
                lbArtikelen.Items.Remove(item);
            }
            else
            {
                return;
            }

            //In deze method wordt het geselecteerde artikel verwijderd en de prijs ook verrekend
            
        }

        private void resetComboBox()
        {
            cbBestel.Text = "";
            cbServices.Text = "";
            cbVerzekering.Text = "";

            //Hier zorgen we ervoor dat de comboboxen geen tekst meer hebben
        }

        private void resetMoney()
        {
            tbsubtotaal.Text = "€ 0,00";
            tbgegeven.Text = "€ 0,00";
            tbTerug.Text = "€ 0,00";
        }

        private void resetGivenMoney()
        {
            ct5.Text = "0";
            ct10.Text = "0";
            ct20.Text = "0";
            ct50.Text = "0";
            eur1.Text = "0";
            eur2.Text = "0";
            eur5.Text = "0";
            eur10.Text = "0";
            eur20.Text = "0";
            eur50.Text = "0";
            eur100.Text = "0";
            eur200.Text = "0";
        }

        private void btNext_Click(object sender, RoutedEventArgs e)
        {
            setTimeToSixty();
            if (lbArtikelen.Items.Count == 0)
            {
                MessageBox.Show("Er staan nog geen artikelen in de lijst!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            MessageBoxResult clearResult = MessageBox.Show("Is de bestelling betaald?", "Bevestiging", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (clearResult == MessageBoxResult.Yes)
            {
                resetComboBox();
                resetMoney();
                resetGivenMoney();
                lbArtikelen.Items.Clear();
                lbterug.Items.Clear();
                tbgegeven.Visibility = Visibility.Hidden;
            }
            else
            {
                return;
            }
        }

        private void cbBestel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            setTimeToSixty();
            ComboBoxItem SelectedVerzekering = (ComboBoxItem)cbVerzekering.SelectedItem;
            ComboBoxItem SelectedService = (ComboBoxItem)cbServices.SelectedItem;

            if ((SelectedVerzekering != null || SelectedService != null) && _changechecker == false)
            {
                MessageBox.Show("Je kunt maar in een box tegelijk iets geselecteerd hebben!", "Waarschuwing", MessageBoxButton.OK, MessageBoxImage.Warning);
                _changechecker = true;
                resetComboBox();
            }
            else if ((SelectedVerzekering != null || SelectedService != null) && _changechecker == true)
            {
                resetComboBox();
                _changechecker = false;
            }
            else
            {
                return;
            }
        }

        private void cbVerzekering_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            setTimeToSixty();
            ComboBoxItem SelectedBike = (ComboBoxItem)cbBestel.SelectedItem;
            ComboBoxItem SelectedService = (ComboBoxItem)cbServices.SelectedItem;

            if ((SelectedBike != null || SelectedService != null) && _changechecker == false)
            {
                MessageBox.Show("Je kunt maar in een box tegelijk iets geselecteerd hebben!", "Waarschuwing", MessageBoxButton.OK, MessageBoxImage.Warning);
                _changechecker = true;
                resetComboBox();
            }
            else if ((SelectedBike != null || SelectedService != null) && _changechecker == true)
            {
                resetComboBox();
                _changechecker = false;
            }
            else
            {
                return;
            }
        }

        private void cbServices_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            setTimeToSixty();
            ComboBoxItem SelectedBike = (ComboBoxItem)cbBestel.SelectedItem;
            ComboBoxItem SelectedVerzekering = (ComboBoxItem)cbVerzekering.SelectedItem;

            if ((SelectedVerzekering != null || SelectedBike != null) && _changechecker == false)
            {
                MessageBox.Show("Je kunt maar in een box tegelijk iets geselecteerd hebben!", "Waarschuwing", MessageBoxButton.OK, MessageBoxImage.Warning);
                _changechecker = true;
                resetComboBox();
            }
            else if ((SelectedVerzekering != null || SelectedBike != null) && _changechecker == true)
            {
                resetComboBox();
                _changechecker = false;
            }
            else
            {
                return;
            }
        }

        private void btReset_Click(object sender, RoutedEventArgs e)
        {
            resetComboBox();
        }

        private void btgeeftotaal_Click(object sender, RoutedEventArgs e)
        {
            double wisselgeld;
            int countera = 0;
            int counterb = 0;
            setTimeToSixty();

            wisselgeld = _totaalgegeven - _subtotaal;
            tbTerug.Text = "€ " + wisselgeld.ToString("0.00");

            while(countera < myArrayMoney.Length)
            {
                while(wisselgeld >= myArrayMoney[countera])
                {
                    counterb++;
                    wisselgeld -= myArrayMoney[countera];
                }
                if (counterb != 0)
                {
                    if (countera < 7)
                    {
                        lbterug.Items.Add(counterb + " keer " + myArrayMoney[countera] + " euro");
                    }
                    else
                    {
                        lbterug.Items.Add(counterb + " keer " + myArrayMoney[countera] + " cent");
                    }                
                }
                countera++;
                counterb = 0;
            }
        }

        private void ct5_TextChanged(object sender, TextChangedEventArgs e)
        {
            int aantalmunten;
            bool trycatch;
            tbgegeven.Foreground = Brushes.White;

            if (ct5.Text == "")
            {
                return;
            }

            try
            {
                aantalmunten = Int32.Parse(ct5.Text);
                trycatch = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Voer aub een geldige waarde in!");
                ct5.Text = "";
                tbgegeven.Foreground = Brushes.Red;
                tbgegeven.Text = "ERROR";
                trycatch = false;
            }

            if (trycatch == true)
            {
                updateallmoney();
            }
            else
            {
                return;
            }
        }

        private void ct10_TextChanged(object sender, TextChangedEventArgs e)
        {
            int aantalmunten;
            bool trycatch;
            tbgegeven.Foreground = Brushes.White;

            if (ct10.Text == "")
            {
                return;
            }

            try
            {
                aantalmunten = Int32.Parse(ct10.Text);
                trycatch = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Voer aub een geldige waarde in!");
                ct10.Text = "";
                tbgegeven.Foreground = Brushes.Red;
                tbgegeven.Text = "ERROR";
                trycatch = false;
            }

            if (trycatch == true)
            {
                updateallmoney();
            }
            else
            {
                return;
            }
        }

        private void ct20_TextChanged(object sender, TextChangedEventArgs e)
        {
            int aantalmunten;
            bool trycatch;
            tbgegeven.Foreground = Brushes.White;

            if (ct20.Text == "")
            {
                return;
            }

            try
            {
                aantalmunten = Int32.Parse(ct20.Text);
                trycatch = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Voer aub een geldige waarde in!");
                ct20.Text = "";
                tbgegeven.Foreground = Brushes.Red;
                tbgegeven.Text = "ERROR";
                trycatch = false;
            }

            if (trycatch == true)
            {
                updateallmoney();
            }
            else
            {
                return;
            }
        }

        private void ct50_TextChanged(object sender, TextChangedEventArgs e)
        {
            int aantalmunten;
            bool trycatch;
            tbgegeven.Foreground = Brushes.White;

            if (ct50.Text == "")
            {
                return;
            }

            try
            {
                aantalmunten = Int32.Parse(ct50.Text);
                trycatch = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Voer aub een geldige waarde in!");
                ct50.Text = "";
                tbgegeven.Foreground = Brushes.Red;
                tbgegeven.Text = "ERROR";
                trycatch = false;
            }

            if (trycatch == true)
            {
                updateallmoney();
            }
            else
            {
                return;
            }
        }

        private void eur1_TextChanged(object sender, TextChangedEventArgs e)
        {
            int aantalmunten;
            bool trycatch;
            tbgegeven.Foreground = Brushes.White;

            if (eur1.Text == "")
            {
                return;
            }

            try
            {
                aantalmunten = Int32.Parse(eur1.Text);
                trycatch = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Voer aub een geldige waarde in!");
                eur1.Text = "";
                tbgegeven.Foreground = Brushes.Red;
                tbgegeven.Text = "ERROR";
                trycatch = false;
            }

            if (trycatch == true)
            {
                updateallmoney();
            }
            else
            {
                return;
            }
        }

        private void eur2_TextChanged(object sender, TextChangedEventArgs e)
        {
            int aantalmunten;
            bool trycatch;
            tbgegeven.Foreground = Brushes.White;

            if (eur2.Text == "")
            {
                return;
            }

            try
            {
                aantalmunten = Int32.Parse(eur2.Text);
                trycatch = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Voer aub een geldige waarde in!");
                eur2.Text = "";
                tbgegeven.Foreground = Brushes.Red;
                tbgegeven.Text = "ERROR";
                trycatch = false;
            }

            if (trycatch == true)
            {
                updateallmoney();
            }
            else
            {
                return;
            }
        }

        private void eur5_TextChanged(object sender, TextChangedEventArgs e)
        {
            int aantalmunten;
            bool trycatch;
            tbgegeven.Foreground = Brushes.White;

            if (eur5.Text == "")
            {
                return;
            }

            try
            {
                aantalmunten = Int32.Parse(eur5.Text);
                trycatch = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Voer aub een geldige waarde in!");
                eur5.Text = "";
                tbgegeven.Foreground = Brushes.Red;
                tbgegeven.Text = "ERROR";
                trycatch = false;
            }

            if (trycatch == true)
            {
                updateallmoney();
            }
            else
            {
                return;
            }
        }

        private void eur10_TextChanged(object sender, TextChangedEventArgs e)
        {
            int aantalmunten;
            bool trycatch;
            tbgegeven.Foreground = Brushes.White;

            if (eur10.Text == "")
            {
                return;
            }

            try
            {
                aantalmunten = Int32.Parse(eur10.Text);
                trycatch = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Voer aub een geldige waarde in!");
                eur10.Text = "";
                tbgegeven.Foreground = Brushes.Red;
                tbgegeven.Text = "ERROR";
                trycatch = false;
            }

            if (trycatch == true)
            {
                updateallmoney();
            }
            else
            {
                return;
            }
        }

        private void eur20_TextChanged(object sender, TextChangedEventArgs e)
        {
            int aantalmunten;
            bool trycatch;
            tbgegeven.Foreground = Brushes.White;

            if (eur20.Text == "")
            {
                return;
            }

            try
            {
                aantalmunten = Int32.Parse(eur20.Text);
                trycatch = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Voer aub een geldige waarde in!");
                eur20.Text = "";
                tbgegeven.Foreground = Brushes.Red;
                tbgegeven.Text = "ERROR";
                trycatch = false;
            }

            if (trycatch == true)
            {
                updateallmoney();
            }
            else
            {
                return;
            }
        }

        private void eur50_TextChanged(object sender, TextChangedEventArgs e)
        {
            int aantalmunten;
            bool trycatch;
            tbgegeven.Foreground = Brushes.White;

            if (eur50.Text == "")
            {
                return;
            }

            try
            {
                aantalmunten = Int32.Parse(eur50.Text);
                trycatch = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Voer aub een geldige waarde in!");
                eur50.Text = "";
                tbgegeven.Foreground = Brushes.Red;
                tbgegeven.Text = "ERROR";
                trycatch = false;
            }

            if (trycatch == true)
            {
                updateallmoney();
            }
            else
            {
                return;
            }
        }

        private void eur100_TextChanged(object sender, TextChangedEventArgs e)
        {
            int aantalmunten;
            bool trycatch;
            tbgegeven.Foreground = Brushes.White;

            if (eur100.Text == "")
            {
                return;
            }

            try
            {
                aantalmunten = Int32.Parse(eur100.Text);
                trycatch = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Voer aub een geldige waarde in!");
                eur100.Text = "";
                tbgegeven.Foreground = Brushes.Red;
                tbgegeven.Text = "ERROR";
                trycatch = false;
            }

            if (trycatch == true)
            {
                updateallmoney();
            }
            else
            {
                return;
            }
        }

        private void eur200_TextChanged(object sender, TextChangedEventArgs e)
        {
            int aantalmunten;
            bool trycatch;
            tbgegeven.Foreground = Brushes.White;

            if (eur200.Text == "")
            {
                return;
            }

            try
            {
                aantalmunten = Int32.Parse(eur200.Text);
                trycatch = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Voer aub een geldige waarde in!");
                eur200.Text = "";
                tbgegeven.Foreground = Brushes.Red;
                tbgegeven.Text = "ERROR";
                trycatch = false;
            }

            if (trycatch == true)
            {
                updateallmoney();
            }
            else
            {
                return;
            }
        }

        private void updateallmoney()
        {
            double cent5;
            double cent10;
            double cent20;
            double cent50;
            double euro1;
            double euro2;
            double euro5;
            double euro10;
            double euro20;
            double euro50;
            double euro100;
            double euro200;

            try
            {
                cent5 = Double.Parse(ct5.Text);
                cent10 = Double.Parse(ct10.Text);
                cent20 = Double.Parse(ct20.Text);
                cent50 = Double.Parse(ct50.Text);
                euro1 = Double.Parse(eur1.Text);
                euro2 = Double.Parse(eur2.Text);
                euro5 = Double.Parse(eur5.Text);
                euro10 = Double.Parse(eur10.Text);
                euro20 = Double.Parse(eur20.Text);
                euro50 = Double.Parse(eur50.Text);
                euro100 = Double.Parse(eur100.Text);
                euro200 = Double.Parse(eur200.Text);
            }
            catch (Exception)
            {
                return;
            }

            cent5 = cent5 * 0.05;
            cent10 = cent10 * 0.1;
            cent20 = cent20 * 0.2;
            cent50 = cent50 * 0.5;
            euro1 = euro1 * 1;
            euro2 = euro2 * 2;
            euro5 = euro5 * 5;
            euro10 = euro10 * 10;
            euro20 = euro20 * 20;
            euro50 = euro50 * 50;
            euro100 = euro100 * 100;
            euro200 = euro200 * 200;

            _totaalgegeven = cent5 + cent10 + cent20 + cent50 + euro1 + euro2 + euro5 + euro10 + euro20 + euro50 + euro100 + euro200;
            tbgegeven.Text = "€ " + _totaalgegeven.ToString("0.00");
        }

        private void BtCalculator_Click(object sender, RoutedEventArgs e)
        {
            var Rekenmachine = new Rekenmachine();
            Rekenmachine.Show();
        }
    }
}
