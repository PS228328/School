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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfAppTreinenProject
{
    /// <summary>
    /// Interaction logic for LaatEenRitZien.xaml
    /// </summary>
    public partial class LaatEenRitZien : Window
    {
        HaalOp _data = new HaalOp();
        MainWindow _myWindow = new MainWindow();
        DispatcherTimer _switcher = new DispatcherTimer();
        int _station = 0;
        int _vertraging = 0;
        int _ritnummer = 0;
        int _stationnummer = 0;
        string _oud = "";

        public LaatEenRitZien(int ritnummer, int station, int nieuwerit)
        {
            InitializeComponent();
            _switcher.Interval = TimeSpan.FromSeconds(4);
            _switcher.Tick += _switcher_Tick;
            _stationnummer = station;
            _ritnummer = ritnummer;

            DataTable rit = _data.HaalEenRitOp(ritnummer);
            if (rit.Rows[0]["Vertraging?"].ToString() != "" && rit.Rows[0]["Vertraging vanaf"].ToString() != "")
            {
                _vertraging = _myWindow.CheckDelay(ritnummer, station);
            }
            if (_vertraging != 0)
            {
                _switcher.Start();
            }
            string eindbestemming = _data.HaalEenStationOp2(rit.Rows[0]["Eindpunt"].ToString());
            _station = station;
            tbEindbestemming.Text = eindbestemming;
            DataTable lijn = _data.HaalEenLijnOp(rit.Rows[0]["Lijnnummer"].ToString());

            string vertrektijd = rit.Rows[0]["Vertrektijd"].ToString();
            int counter = 1;
            bool stationfound = false;

            if (rit.Rows[0]["Beginpunt"].ToString() == lijn.Rows[0]["S" + counter].ToString())
            {
                stationfound = true;
            }
            while (rit.Rows[0]["Beginpunt"].ToString() != lijn.Rows[0]["S" + counter].ToString() && stationfound == false)
            {
                counter++;
            }
            int begintijd = 0;
            int tijdopstation = 0;
            if (counter > 1)
            {
                begintijd = Int32.Parse(lijn.Rows[0]["V" + counter].ToString());
            }
            int counter2 = 1;
            while (lijn.Rows[0]["S" + counter2].ToString() != station.ToString())
            {
                counter2++;
            }
            if (counter2 != 1)
            {
                tijdopstation = Int32.Parse(lijn.Rows[0]["V" + counter2].ToString());
            }
            string[] arraytijd = vertrektijd.Split(':');
            int uur = Int32.Parse(arraytijd[0]);
            int minuut = Int32.Parse(arraytijd[1]);
            int tijderbij = tijdopstation - begintijd;

            int vertrektijdincijfers = uur * 60 + minuut + tijderbij;

            uur = 0;

            while (vertrektijdincijfers >= 60)
            {
                vertrektijdincijfers -= 60;
                uur++;
            }

            string uurString = "";
            string minuutString = "";

            if (uur < 10)
            {
                uurString = "0" + uur.ToString();
            }
            else
            {
                uurString = uur.ToString();
            }

            if (vertrektijdincijfers < 10)
            {
                minuutString = "0" + vertrektijdincijfers.ToString();
            }
            else
            {
                minuutString = vertrektijdincijfers.ToString();
            }
            tbVertrektijd.Text = uurString + ":" + minuutString;
            tbTrein.Text = rit.Rows[0]["Trein"].ToString();
            _oud = rit.Rows[0]["Trein"].ToString();
            tbSpoor.Text = lijn.Rows[0]["Sp" + counter2].ToString();
            counter2++;

            int aantallijnen = 1;
            viavia.Text = "";

            while (lijn.Rows[0]["S" + counter2].ToString() != rit.Rows[0]["Eindpunt"].ToString())
            {
                string stad = _data.HaalEenStationOp2(lijn.Rows[0]["S" + counter2].ToString());

                if (viavia.Text.Length + stad.Length > 32 * aantallijnen)
                {
                    if (viavia.Text == "")
                    {
                        viavia.Text = "Via " + stad;
                    }
                    else if (lijn.Rows[0]["S" + (counter2 + 1)].ToString() == rit.Rows[0]["Eindpunt"].ToString())
                    {
                        viavia.Text += "\n" + " en " + stad;
                    }
                    else
                    {
                        viavia.Text += "\n" + stad;
                    }
                    aantallijnen++;
                }
                else
                {
                    if (viavia.Text == "")
                    {
                        viavia.Text = "Via " + stad;
                    }
                    else if (lijn.Rows[0]["S" + (counter2 + 1)].ToString() == rit.Rows[0]["Eindpunt"].ToString())
                    {
                        viavia.Text += " en " + stad;
                    }
                    else
                    {
                        viavia.Text += ", " + stad;
                    }
                }

                if (aantallijnen >= 7)
                {
                    viavia.FontSize = 30;
                }
                counter2++;
            }

            DataTable volgenderit = _data.HaalEenRitOp(nieuwerit);
            string nieuwestad = _data.HaalEenStationOp2(volgenderit.Rows[0]["Eindpunt"].ToString());
            string vertrektijdnieuwString = volgenderit.Rows[0]["Vertrektijd"].ToString();
            string[] splitternieuw = vertrektijdnieuwString.Split(':');
            int uurnieuw = Convert.ToInt32(splitternieuw[0]);
            int minuutnieuw = Convert.ToInt32(splitternieuw[1]);
            int echtetijd = uurnieuw * 60 + minuutnieuw;
            int tellerBegin = 1;
            int tellerEind = 1;
            int stationIndex = 1;
            DataTable lijnNieuw = _data.HaalEenLijnOp(volgenderit.Rows[0]["Lijnnummer"].ToString());

            while (lijnNieuw.Rows[0]["S" + tellerBegin].ToString() != volgenderit.Rows[0]["Beginpunt"].ToString())
            {
                tellerBegin++;
            }
            if (tellerBegin == 1)
            {
                tellerBegin = 0;
            }
            else
            {
                tellerBegin = Convert.ToInt32(lijnNieuw.Rows[0]["V" + tellerBegin].ToString());
            }

            while (lijnNieuw.Rows[0]["S" + stationIndex].ToString() != station.ToString())
            {
                stationIndex++;
            }
            if (stationIndex == 1)
            {
                tellerEind = 0;
            }
            else
            {
                tellerEind = Convert.ToInt32(lijnNieuw.Rows[0]["V" + stationIndex].ToString());
            }

            int vertrekTijdNieuw = echtetijd + tellerEind - tellerBegin;
            uurnieuw = 0;
            while (vertrekTijdNieuw >= 60)
            {
                vertrekTijdNieuw -= 60;
                uurnieuw++;
            }

            string tijdinKlok = "";

            if (vertrekTijdNieuw < 10 && uurnieuw >= 10)
            {
                tijdinKlok = uurnieuw.ToString() + ":0" + vertrekTijdNieuw.ToString();
            }
            else if (uurnieuw < 10 && vertrekTijdNieuw >= 10)
            {
                tijdinKlok = "0" + uurnieuw.ToString() + ":" + vertrekTijdNieuw.ToString();
            }
            else if (vertrekTijdNieuw < 10 && uurnieuw < 10)
            {
                tijdinKlok = "0" + uurnieuw.ToString() + ":0" + vertrekTijdNieuw.ToString();
            }
            else
            {
                tijdinKlok = uurnieuw.ToString() + ":" + vertrekTijdNieuw.ToString();
            }

            tbNext.Text = "Hierna/Next: " + tijdinKlok + " " + volgenderit.Rows[0]["Trein"].ToString() + " naar " + nieuwestad;
        }

        private void _switcher_Tick(object sender, EventArgs e)
        {
            DataTable rit = _data.HaalEenRitOp(_ritnummer);
            if (rit.Rows[0]["Vertraging?"].ToString() != "" && rit.Rows[0]["Vertraging vanaf"].ToString() != "" && _vertraging != 0)
            {
                _vertraging = _myWindow.CheckDelay(_ritnummer, _stationnummer);
            }
            else
            {
                tbTrein.Text = _oud;
                tbTrein.Foreground = Brushes.DarkBlue;
                return;
            }

            if (tbTrein.Foreground == Brushes.DarkBlue)
            {
                tbTrein.Foreground = Brushes.Red;
                tbTrein.Text = "+" + _vertraging.ToString() + " minuten";
            }
            else
            {
                tbTrein.Foreground = Brushes.DarkBlue;
                tbTrein.Text = _oud;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
