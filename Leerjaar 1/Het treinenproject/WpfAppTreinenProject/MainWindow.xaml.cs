using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfAppTreinenProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HaalOp _data = new HaalOp();
        DispatcherTimer _tijdklok = new DispatcherTimer();
        DispatcherTimer _ververser = new DispatcherTimer();
        string[] _alleritgegevens;
        int _stationsnummer = 0;

        public MainWindow()
        {
            InitializeComponent();
            VulComboboxStations();
            _tijdklok.Start();
            _tijdklok.Tick += _tijdklok_Tick;
            DataTable alleritten = _data.HaalAlleRittenOp();
            string[] alleritgegevens = new string[alleritten.Rows.Count];
            _alleritgegevens = alleritgegevens;
            _ververser.Interval = TimeSpan.FromMilliseconds(2000);
            _ververser.Tick += _ververser_Tick;
        }

        private void _tijdklok_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            int hours = time.Hour;
            int minutes = time.Minute;

            string hour;
            string minute;

            if (hours < 10)
            {
                hour = "0" + hours.ToString();
            }
            else
            {
                hour = hours.ToString();
            }

            if (minutes < 10)
            {
                minute = "0" + minutes.ToString();
            }
            else
            {
                minute = minutes.ToString();
            }

            tbTime.Text = hour + ":" + minute;
        }

        private void btLaatzien_Click(object sender, RoutedEventArgs e)
        {
            btLaatzien.Visibility = Visibility.Hidden;
            ComboBoxItem SelectedStad = (ComboBoxItem)cbxSteden.SelectedItem;
            if (SelectedStad == null)
            {
                MessageBox.Show("Selecteer aub een stad!");
                return;
            }

            _ververser.Start();
        }

        private void _ververser_Tick(object sender, EventArgs e)
        {
            Verversgegevens();
        }

        private void Verversgegevens()
        {
            int teller = 0;
            while (teller < _alleritgegevens.Length)
            {
                _alleritgegevens[teller] = null;
                teller++;
            }
            lbRides.Items.Clear();

            string stad = cbxSteden.Text;
            int stationsnummer = _data.HaalEenStationOp(stad);
            _stationsnummer = stationsnummer;
            bool whiteorblue = true;
            bool stationfound = false;
            int aantal = Int32.Parse(tbAantalRitten.Text);
            int counter = 0;
            int arraycounter = 0;

            DataTable allelijnen = _data.HaalAlleLijnenOp();
            while (counter < allelijnen.Rows.Count)
            {
                int counter2 = 1;
                while (counter2 < 26 && allelijnen.Rows[counter]["S" + counter2].ToString() != "")
                {
                    if (allelijnen.Rows[counter]["S" + counter2].ToString() == stationsnummer.ToString() && allelijnen.Rows[counter]["S" + (counter2 + 1)].ToString() != "")
                    {
                        int counter3 = 0;
                        DataTable ritten = _data.HaalRittenVanEenLijnOp(allelijnen.Rows[counter]["Lijnnummer"].ToString());

                        while (counter3 < ritten.Rows.Count)
                        {
                            int beginpuntS = 1;
                            string beginpunt = ritten.Rows[counter3]["Beginpunt"].ToString();
                            string eindpunt = ritten.Rows[counter3]["Eindpunt"].ToString();
                            bool erbijofniet = true;

                            DataTable lijn = _data.HaalEenLijnOp(ritten.Rows[0]["Lijnnummer"].ToString());
                            while (lijn.Rows[0]["S" + beginpuntS].ToString() != beginpunt)
                            {
                                beginpuntS++;
                            }
                            int eindpuntS = beginpuntS;
                            while (lijn.Rows[0]["S" + eindpuntS].ToString() != eindpunt)
                            {
                                eindpuntS++;
                            }
                            int stationIndex = 1;
                            while (lijn.Rows[0]["S" + stationIndex].ToString() != stationsnummer.ToString())
                            {
                                stationIndex++;
                            }
                            if (stationIndex >= eindpuntS || stationIndex < beginpuntS)
                            {
                                erbijofniet = false;
                            }

                            if (erbijofniet == true)
                            {
                                string vertrektijd = ritten.Rows[counter3]["Vertrektijd"].ToString();

                                int counter4 = 1;
                                if (ritten.Rows[counter3]["Beginpunt"].ToString() == allelijnen.Rows[counter]["S" + counter4].ToString())
                                {
                                    stationfound = true;
                                }
                                while (ritten.Rows[counter3]["Beginpunt"].ToString() != allelijnen.Rows[counter]["S" + counter4].ToString() && stationfound == false)
                                {
                                    counter4++;
                                }
                                int begintijd = 0;
                                int tijdopstation = 0;
                                if (counter4 > 1)
                                {
                                    begintijd = Int32.Parse(allelijnen.Rows[counter]["V" + counter4].ToString());
                                }
                                if (allelijnen.Rows[counter]["S1"].ToString() != stationsnummer.ToString())
                                {
                                    tijdopstation = Int32.Parse(allelijnen.Rows[counter]["V" + counter2].ToString());
                                }
                                string[] arraytijd = vertrektijd.Split(':');
                                int uur = Int32.Parse(arraytijd[0]);
                                int minuut = Int32.Parse(arraytijd[1]);
                                int tijderbij = tijdopstation - begintijd;

                                int vertrektijdincijfers = uur * 60 + minuut + tijderbij;
                                string benodigdeinformatie = vertrektijdincijfers.ToString() + " " + ritten.Rows[counter3]["Ritnummer"].ToString();

                                if (vertrektijdincijfers < 10)
                                {
                                    benodigdeinformatie = "A " + benodigdeinformatie;
                                }
                                else if (vertrektijdincijfers < 100)
                                {
                                    benodigdeinformatie = "B " + benodigdeinformatie;
                                }
                                else if (vertrektijdincijfers < 1000)
                                {
                                    benodigdeinformatie = "C " + benodigdeinformatie;
                                }
                                else
                                {
                                    benodigdeinformatie = "D " + benodigdeinformatie;
                                }
                                _alleritgegevens[arraycounter] = benodigdeinformatie;
                                arraycounter++;
                                stationfound = false;
                            }
                            counter3++;
                        }
                    }
                    counter2++;
                }
                counter++;
            }

            Array.Sort(_alleritgegevens);
            DateTime time = DateTime.Now;
            int hourNow = time.Hour;
            int minuteNow = time.Minute;
            int timeNumbers = hourNow * 60 + minuteNow;
            int counter5 = 0;
            bool foundIt = false;

            while (counter5 < _alleritgegevens.Length && foundIt == false)
            {
                if (_alleritgegevens[counter5] != null)
                {
                    string[] splitter = _alleritgegevens[counter5].Split(' ');
                    int tijd = Convert.ToInt32(splitter[1]);

                    if (tijd >= timeNumbers)
                    {
                        foundIt = true;
                        counter5--;
                    }
                }
                counter5++;
            }

            counter = 0;
            bool settrue = false;

            while (counter < _alleritgegevens.Length)
            {
                if (_alleritgegevens[counter] != null)
                {
                    settrue = true;
                }
                counter++;
            }

            if (settrue == false)
            {
                MessageBox.Show("Geen ritten gevonden...");
                btLaatzien.Visibility = Visibility.Visible;
                _ververser.Stop();
                return;
            }

            counter = 0;

            while (counter < aantal)
            {
                string[] splitter = _alleritgegevens[counter5].Split(' ');
                DataTable rit = _data.HaalEenRitOp(Int32.Parse(splitter[2]));
                DataTable lijn = _data.HaalEenLijnOp(rit.Rows[0]["Lijnnummer"].ToString());
                int starttijd = 0;
                int tijdopstation = 0;

                int tijd = Convert.ToInt32(splitter[1]);
                int vertrektijdopstation = tijd + tijdopstation - starttijd;
                int uur = 0;
                string uurstring = "";
                string minuutstring = "";

                while (vertrektijdopstation >= 60)
                {
                    vertrektijdopstation = vertrektijdopstation - 60;
                    uur++;
                }

                if (uur < 10)
                {
                    uurstring = "0" + uur.ToString();
                }
                else
                {
                    uurstring = uur.ToString();
                }

                if (vertrektijdopstation < 10)
                {
                    minuutstring = "0" + vertrektijdopstation.ToString();
                }
                else
                {
                    minuutstring = vertrektijdopstation.ToString();
                }

                string tijdincijfers = uurstring + ":" + minuutstring;
                DataTable rit1 = _data.HaalEenRitOp(Convert.ToInt32(splitter[2]));

                StackPanel fullPanel = new StackPanel();
                fullPanel.Orientation = Orientation.Horizontal;
                lbRides.Items.Add(fullPanel);

                StackPanel vertrekvertraging = new StackPanel();
                vertrekvertraging.Orientation = Orientation.Vertical;
                fullPanel.Children.Add(vertrekvertraging);

                StackPanel bestemmingbeschrijving = new StackPanel();
                bestemmingbeschrijving.Orientation = Orientation.Vertical;
                fullPanel.Children.Add(bestemmingbeschrijving);

                TextBlock vertrektijd = new TextBlock();
                vertrektijd.FontSize = 25;
                vertrektijd.FontWeight = FontWeights.Bold;
                vertrektijd.Width = 120;
                vertrektijd.Height = 40;
                vertrektijd.TextAlignment = TextAlignment.Center;
                vertrektijd.Foreground = Brushes.DarkBlue;
                if (whiteorblue == true)
                {
                    vertrektijd.Background = Brushes.LightBlue;
                }
                else
                {
                    vertrektijd.Background = Brushes.LightGray;
                }
                vertrektijd.Text = tijdincijfers;
                vertrekvertraging.Children.Add(vertrektijd);

                TextBlock vertraging = new TextBlock();
                vertraging.FontSize = 20;
                vertraging.FontWeight = FontWeights.Bold;
                vertraging.Width = 120;
                vertraging.Height = 30;
                vertraging.TextAlignment = TextAlignment.Center;
                vertraging.Foreground = Brushes.Red;
                if (whiteorblue == true)
                {
                    vertraging.Background = Brushes.LightBlue;
                }
                else
                {
                    vertraging.Background = Brushes.LightGray;
                }
                if (rit.Rows[0]["Vertraging?"].ToString() != "" && rit.Rows[0]["Vertraging vanaf"].ToString() != "")
                {
                    int delaytime = CheckDelay(Int32.Parse(splitter[2]), stationsnummer);
                    if (delaytime == 0)
                    {
                        vertraging.Text = "";
                    }
                    else
                    {
                        vertraging.Text = "+" + delaytime.ToString();
                    }
                }
                else
                {
                    vertraging.Text = "";
                }
                vertrekvertraging.Children.Add(vertraging);

                TextBlock bestemming = new TextBlock();
                bestemming.FontSize = 25;
                bestemming.Height = 40;
                bestemming.FontWeight = FontWeights.Bold;
                bestemming.Width = 300;
                bestemming.TextAlignment = TextAlignment.Center;
                bestemming.Foreground = Brushes.DarkBlue;
                if (whiteorblue == true)
                {
                    bestemming.Background = Brushes.LightBlue;
                }
                else
                {
                    bestemming.Background = Brushes.LightGray;
                }
                string station = _data.HaalEenStationOp2(rit1.Rows[0]["Eindpunt"].ToString());

                bestemming.Text = station;
                bestemmingbeschrijving.Children.Add(bestemming);

                TextBlock bijzonderheden = new TextBlock();
                bijzonderheden.FontSize = 15;
                bijzonderheden.FontWeight = FontWeights.Bold;
                bijzonderheden.Width = 300;
                bijzonderheden.Height = 30;
                bijzonderheden.TextAlignment = TextAlignment.Center;
                bijzonderheden.Foreground = Brushes.Red;
                if (whiteorblue == true)
                {
                    bijzonderheden.Background = Brushes.LightBlue;
                }
                else
                {
                    bijzonderheden.Background = Brushes.LightGray;
                }
                bijzonderheden.Text = "";
                bestemmingbeschrijving.Children.Add(bijzonderheden);

                TextBlock spoor = new TextBlock();
                spoor.FontSize = 50;
                spoor.Name = "Spoor";
                spoor.FontWeight = FontWeights.Bold;
                spoor.Width = 100;
                spoor.TextAlignment = TextAlignment.Center;
                spoor.Foreground = Brushes.DarkBlue;
                if (whiteorblue == true)
                {
                    spoor.Background = Brushes.LightBlue;
                }
                else
                {
                    spoor.Background = Brushes.LightGray;
                }
                int counter6 = 1;
                if (rit.Rows[0]["Spoorwijziging?"].ToString() == "")
                {
                    DataTable lijn1 = _data.HaalEenLijnOp(rit1.Rows[0]["Lijnnummer"].ToString());
                    while (lijn.Rows[0]["S" + counter6].ToString() != stationsnummer.ToString())
                    {
                        counter6++;
                    }
                    spoor.Text = lijn1.Rows[0]["Sp" + counter6].ToString();
                }
                fullPanel.Children.Add(spoor);

                TextBlock trein = new TextBlock();
                trein.Name = "t" + rit1.Rows[0]["Ritnummer"].ToString();
                trein.FontSize = 30;
                trein.FontWeight = FontWeights.Bold;
                trein.Width = 300;
                trein.TextAlignment = TextAlignment.Center;
                trein.Foreground = Brushes.DarkBlue;
                if (whiteorblue == true)
                {
                    trein.Background = Brushes.LightBlue;
                    whiteorblue = false;
                }
                else
                {
                    trein.Background = Brushes.LightGray;
                    whiteorblue = true;
                }
                trein.Text = rit1.Rows[0]["Trein"].ToString();
                fullPanel.Children.Add(trein);

                Button myButton = new Button();
                myButton.Name = "Rideinfo";
                myButton.Width = 100;
                myButton.Background = Brushes.LightGreen;
                myButton.Click += Ride_Click;
                fullPanel.Children.Add(myButton);

                counter++;
                counter5++;
                if (counter5 >= _alleritgegevens.Length)
                {
                    counter5 = 0;
                    while (_alleritgegevens[counter5] == null)
                    {
                        counter5++;
                    }
                }
            }
        }

        private void Ride_Click(object sender, RoutedEventArgs e)
        {
            Button myButton = e.Source as Button;
            StackPanel parent = (StackPanel)myButton.Parent;
            int counter = 0;
            int oudeAantal = Convert.ToInt32(tbAantalRitten.Text);
            string spoor = "";

            foreach (TextBlock myBlock in parent.Children.OfType<TextBlock>())
            {
                if (counter == 0)
                {
                    spoor = myBlock.Text;
                }
                if (counter == 1)
                {
                    string[] splitter = myBlock.Name.Split('t');
                    int ritnummer = Convert.ToInt32(splitter[1]);
                    int nieuwerit = 0;
                    tbAantalRitten.Text = "60";
                    Verversgegevens();
                    bool geklikteritgevonden = false;
                    bool nieuweritgevonden = false;

                    foreach (StackPanel myPanel in lbRides.Items.OfType<StackPanel>())
                    {
                        foreach (TextBlock spooroftrein in myPanel.Children.OfType<TextBlock>())
                        {
                            if (spooroftrein.Name == "t" + ritnummer.ToString())
                            {
                                geklikteritgevonden = true;
                            }

                            if (geklikteritgevonden == true && spooroftrein.Name == "Spoor" && spooroftrein.Text == spoor)
                            {
                                nieuweritgevonden = true;
                            }

                            if (geklikteritgevonden == true && nieuweritgevonden == true && spooroftrein.Name != "Spoor")
                            {
                                string[] splitter2 = spooroftrein.Name.Split('t');
                                nieuwerit = Convert.ToInt32(splitter2[1]);
                                nieuweritgevonden = false;
                                geklikteritgevonden = false;
                            }
                        }
                    }
                    LaatEenRitZien show = new LaatEenRitZien(ritnummer, _stationsnummer, nieuwerit);
                    show.ShowDialog();
                    string station = _data.HaalEenStationOp2(_stationsnummer.ToString());
                    int counter2 = 0;
                    tbAantalRitten.Text = oudeAantal.ToString();
                    DataTable stations = _data.HaalStationsOp();

                    while (counter2 < 399)
                    {
                        if (station == stations.Rows[counter2]["Stad"].ToString())
                        {
                            cbxSteden.SelectedIndex = counter2;
                        }
                        counter2++;
                    }
                }
                counter++;
            }
        }

        private void btUp_Click(object sender, RoutedEventArgs e)
        {
            UpdateNumberOfRides(true);
        }

        private void btDown_Click(object sender, RoutedEventArgs e)
        {
            UpdateNumberOfRides(false);
        }
        private void UpdateNumberOfRides(bool upordown)
        {
            int oud = Int32.Parse(tbAantalRitten.Text);
            if (upordown == true && oud < 18)
            {
                oud++;
            }
            else if (upordown == false && oud > 2)
            {
                oud--;
            }
            else
            {
                MessageBox.Show("Maximum of minimum aantal bereikt!");
            }
            tbAantalRitten.Text = oud.ToString();
        }
        private void VulComboboxStations()
        {
            DataTable stations = _data.HaalStationsOp();
            int counter = 0;

            while (counter < stations.Rows.Count)
            {
                ComboBoxItem station = new ComboBoxItem();
                station.Content = stations.Rows[counter]["Stad"].ToString();
                cbxSteden.Items.Add(station);
                counter++;
            }
        }
        public int CheckDelay(int ritnummer, int stationsnummer)
        {
            DataTable bijbehorendeRit = _data.HaalEenRitOp(ritnummer);
            DataTable bijbehorendeLijn = _data.HaalEenLijnOp(bijbehorendeRit.Rows[0]["Lijnnummer"].ToString());
            int vertragingbegin = 1;
            while (bijbehorendeLijn.Rows[0]["S" + vertragingbegin].ToString() != bijbehorendeRit.Rows[0]["Vertraging vanaf"].ToString())
            {
                vertragingbegin++;
            }
            int normalevertrektijd = 0;
            int tijderbij = Convert.ToInt32(bijbehorendeRit.Rows[0]["Vertraging?"].ToString());

            if (vertragingbegin < 2)
            {
                normalevertrektijd = 0;
            }
            else
            {
                normalevertrektijd = Convert.ToInt32(bijbehorendeLijn.Rows[0]["V" + vertragingbegin].ToString());
            }
            int nieuwevertrektijd = normalevertrektijd + tijderbij;
            int stationIndex = 1;

            while (stationsnummer.ToString() != bijbehorendeLijn.Rows[0]["S" + stationIndex].ToString())
            {
                stationIndex++;
            }

            if (stationIndex < vertragingbegin)
            {
                return 0;
            }

            while (stationIndex >= vertragingbegin)
            {
                if (vertragingbegin > 1)
                {
                    int vertrektijd = Int32.Parse(bijbehorendeLijn.Rows[0]["V" + vertragingbegin].ToString());
                    int aankomsttijd = Int32.Parse(bijbehorendeLijn.Rows[0]["A" + vertragingbegin].ToString());
                    int tijderafhalen = vertrektijd - aankomsttijd;
                    tijderbij = tijderbij - tijderafhalen;
                }
                vertragingbegin++;
            }

            if (tijderbij < 1)
            {
                return 0;
            }
            else
            {
                if (tijderbij % 5 == 0)
                {
                    return tijderbij;
                }
                else if (tijderbij % 5 == 1)
                {
                    return tijderbij - 1;
                }
                else if (tijderbij % 5 == 2)
                {
                    return tijderbij + 3;
                }
                else if (tijderbij % 5 == 3)
                {
                    return tijderbij + 2;
                }
                else if (tijderbij % 5 == 4)
                {
                    return tijderbij + 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
