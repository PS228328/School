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

        StackPanel _myPanel;
        TextBlock naamproduct;
        TextBlock prijspd;
        TextBlock aantaldagen;
        TextBlock totaalprijs;
        Button deleteButton;

        timer newtm = new timer();
        Rekenmachine newcalc = new Rekenmachine();

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
            if (myGrid.ActualWidth <= 0)
            {
                return;
            }
            tbTijd.Width = myGrid.ActualWidth - 30;
            //Method voor verschillende buttons, deze zorgt ervoor dat de timer weer teruggaat naar 60 als iemand iets doet.
        }

        private void btBestel_Click(object sender, RoutedEventArgs e)
        {
            setTimeToSixty();
            string selected = "";
            string[] strprice = {""};

            int counter = 0;
            double prijsart = 0;
            int dagaantal = 0;
            double totaalsamen = 0;

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
                try
                {
                    dagaantal = Int32.Parse(tbDagen.Text);
                    prijsart = Double.Parse(strprice[2]);
                    totaalsamen = dagaantal * prijsart;
                }
                catch (Exception)
                {
                    MessageBox.Show("Vul aub een geldig aantal dagen in!");
                    return;
                }

                _myPanel = new StackPanel();
                _myPanel.Orientation = Orientation.Horizontal;
                lbArtikelen.Items.Add(_myPanel);

                naamproduct = new TextBlock();
                naamproduct.Text = strprice[0] + "    ";
                _myPanel.Children.Add(naamproduct);

                prijspd = new TextBlock();
                prijspd.Text = "Prijs p/d: € " + strprice[2] + "    ";
                _myPanel.Children.Add(prijspd);

                aantaldagen = new TextBlock();
                aantaldagen.Text = "Aantal dagen: " + tbDagen.Text + "    ";
                _myPanel.Children.Add(aantaldagen);

                _subtotaal += totaalsamen;

                totaalprijs = new TextBlock();
                totaalprijs.Text = "€ " + totaalsamen.ToString("0.00") + "    ";
                totaalprijs.Name = "lijstvanartikelen";
                _myPanel.Children.Add(totaalprijs);

                deleteButton = new Button();
                deleteButton.Width = 80;
                deleteButton.Background = Brushes.Red;
                deleteButton.Name = "Deletebt";
                deleteButton.Content = "Verwijder";
                deleteButton.Foreground = Brushes.White;
                deleteButton.Click += DeleteButton_Click;
                deleteButton.HorizontalAlignment = HorizontalAlignment.Right;
                _myPanel.Children.Add(deleteButton);

                tbsubtotaal.Text = "€ " + _subtotaal.ToString("0.00");
                tbDagen.Text = "1";
                resetComboBox();
            }   
            else
            {
                MessageBox.Show("Selecteer aub een optie!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            //Verwijder een artikel

            setTimeToSixty();
            //Hieronder: Vraag om de bevestiging of het artikel echt verwijderd moet worden

            MessageBoxResult deleteornot = MessageBox.Show("Weet je zeker dat je het item wilt verwijderen?", "Verwijder item", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (deleteornot == MessageBoxResult.Yes)
            {
                Button myButton = e.Source as Button;
                StackPanel parent = (StackPanel)myButton.Parent;
                //Haal de button op en het betreffende stackpanel

                foreach (TextBlock item in parent.Children.OfType<TextBlock>())
                {
                    if (item.Name == "lijstvanartikelen")
                    {
                        string[] text = item.Text.Split(' ');
                        double minus = 0;
                        minus = Double.Parse(text[1]);
                        _subtotaal -= minus;
                        tbsubtotaal.Text = "€ " + _subtotaal.ToString("0.00");
                    }
                    //In de lijstvanartikelen staat het bedrag waarmee gerekend moet worden
                }
                lbArtikelen.Items.Remove(parent);
            }
            else
            {
                return;
            }
        }

        private void tbDagen_TextChanged(object sender, TextChangedEventArgs e)
        {
            setTimeToSixty();
        }

        private void btNext_Click(object sender, RoutedEventArgs e)
        {
            //Ga naar de volgende klant

            setTimeToSixty();
            if (lbArtikelen.Items.Count == 0)
            {
                MessageBox.Show("Er staan nog geen artikelen in de lijst!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
                //Als er geen artikelen in de lijst staan om verwijderd te worden
            }

            MessageBoxResult clearResult = MessageBox.Show("Is de bestelling betaald?", "Bevestiging", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (clearResult == MessageBoxResult.Yes)
            {
                resetComboBox();
                resetMoney();
                resetGivenMoney();
                lbArtikelen.Items.Clear();
                lbterug.Items.Clear();
                _totaalgegeven = 0;
                _changechecker = false;
                _subtotaal = 0;

                //Als het bevestigd wordt, moet alles gereset worden
            }
            else
            {
                return;
            }
        }

        private void cbBestel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Wanneer de selectie veranderd wordt, moet gecheckt worden of dat de andere twee comboboxen leeg zijn, als dit niet zo is moeten die leeggemaakt worden,
            //er kan immers maar een item tegelijk geselecteerd zijn. Onderstaande 2 handlers werken precies hetzelfde, maar dan voor de andere boxen.
            setTimeToSixty();
            ComboBoxItem SelectedVerzekering = (ComboBoxItem)cbVerzekering.SelectedItem;
            ComboBoxItem SelectedService = (ComboBoxItem)cbServices.SelectedItem;

            if ((SelectedVerzekering != null || SelectedService != null) && _changechecker == false)
            {
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
            //Haal alles uit de lijst

            setTimeToSixty();
            MessageBoxResult myResult = MessageBox.Show("Weet je zeker dat je alles wilt verwijderen?", "Alles verwijderen", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (myResult == MessageBoxResult.No)
            {
                return;
            }
            resetComboBox();
            lbArtikelen.Items.Clear();
            tbsubtotaal.Text = "€ 0,00";
            _subtotaal = 0;
        }

        private void btgeeftotaal_Click(object sender, RoutedEventArgs e)
        {
            //Wanneer er op de knop wordt geklikt, moet het wisselgeld getoond worden
            changeMoney();
        }


        private void automatic_Click(object sender, RoutedEventArgs e)
        {
            setTimeToSixty();
            automatic.Background = Brushes.Red;
            manual.Background = Brushes.White;
        }

        private void manual_Click(object sender, RoutedEventArgs e)
        {
            setTimeToSixty();
            automatic.Background = Brushes.White;
            manual.Background = Brushes.Red;
        }

        private void changeMoney()
        {
            //En dat wordt in deze eventHandler gedaan
            double totaalgegeven = 0;
            try
            {
                totaalgegeven = Double.Parse(tbgegeven.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Vul aub een geldige waarde in!");
                return;
            }
            lbterug.Items.Clear();
            double wisselgeld;
            int countera = 0;
            int counterb = 0;
            setTimeToSixty();

            wisselgeld = totaalgegeven - _subtotaal;
            tbTerug.Text = "€ " + wisselgeld.ToString("0.00");

            //We lopen door de array van briefjes en muntjes en we kijken of we een bepaald briefje kunnen teruggeven of dat dit teveel is

            while (countera < myArrayMoney.Length)
            {
                while (wisselgeld >= myArrayMoney[countera])
                {
                    counterb++;
                    wisselgeld -= myArrayMoney[countera];
                }
                if (counterb != 0)
                {
                    if (countera < 8)
                    {
                        lbterug.Items.Add(counterb + " keer " + myArrayMoney[countera] + " euro");
                    }
                    else
                    {
                        lbterug.Items.Add(counterb + " keer " + myArrayMoney[countera] * 100 + " cent");
                    }
                }
                countera++;
                counterb = 0;
            }
        }

        //In onderstaande eventHandlers wordt de tekst veranderd van een bepaalde waarde (munt of brief)

        private void ct5_TextChanged(object sender, TextChangedEventArgs e)
        {
            setTimeToSixty();
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
            setTimeToSixty();
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
            setTimeToSixty();
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
            setTimeToSixty();
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
            setTimeToSixty();
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
            setTimeToSixty();
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
            setTimeToSixty();
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
            setTimeToSixty();
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
            setTimeToSixty();
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
            setTimeToSixty();
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
            setTimeToSixty();
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
            setTimeToSixty();
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
            //Hier wordt alles geupdate wanneer er tekst wordt veranderd
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
            tbgegeven.Text =  _totaalgegeven.ToString("0.00");
        }

        private void btgotoTimer_Click(object sender, RoutedEventArgs e)
        {
            _countdown.Stop();
            this.Close();
            newtm.Show();
        }

        private void btgotoCalc_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            _countdown.Stop();
            newcalc.Show();
        }

        private void tbgegeven_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (automatic.Background == Brushes.Red)
            {
                changeMoney();
            }
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
            tbgegeven.Text = "0,00";
            tbTerug.Text = "€ 0,00";

            //Alles wordt teruggezet naar 0 (Wordt aangeroepen als alles hersteld moet worden)
        }

        private void resetGivenMoney()
        {
            //Alles wordt teruggezet naar 0 (Wordt aangeroepen als alles hersteld moet worden)

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
    }
}
