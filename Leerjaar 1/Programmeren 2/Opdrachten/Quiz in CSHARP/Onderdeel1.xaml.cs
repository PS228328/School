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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Quiz_in_CSHARP
{
    /// <summary>
    /// Interaction logic for Onderdeel1.xaml
    /// </summary>
    public partial class Onderdeel1 : Window
    {
        DispatcherTimer _timetoanswer = new DispatcherTimer();
        int _countdown;
        int _quescounter;
        int _goedevragen = 0;

        Random myRandom = new Random();
        int _getal1;
        int _getal2;
        int _uitkomst;
        int _guitkomst;
        int _myOperator;

        Onderdeel2 newOnderdeel = new Onderdeel2();

        public Onderdeel1()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, RoutedEventArgs e)
        {
            btStart.Visibility = Visibility.Hidden;
            timer.Text = "8";
            vraagNR.Text = "Vraag 1";
            createSum();
            _timetoanswer.Start();
            _timetoanswer.Interval = TimeSpan.FromMilliseconds(900);
            _timetoanswer.Tick += _timetoanswer_Tick;
        }

        private void _timetoanswer_Tick(object sender, EventArgs e)
        {
            _countdown = Int32.Parse(timer.Text);
            _countdown--;
            timer.Text = _countdown.ToString();
            if (_countdown == 0)
            {
                string vraag = vraagNR.Text;
                string[] arrayvraag = vraag.Split(' ');
                _quescounter = Int32.Parse(arrayvraag[1]);
                _quescounter++;

                if (tbOperator.Text == "+")
                {
                    _uitkomst = _getal1 + _getal2;
                }
                else
                {
                    _uitkomst = _getal1 - _getal2;
                    if (_uitkomst < 0)
                    {
                        _uitkomst = _getal2 - _getal1;
                    }
                }

                try
                {
                    _guitkomst = Int32.Parse(tbUitkomst.Text);
                }
                catch (Exception)
                {
                    _guitkomst = 0;
                }

                if (_guitkomst == _uitkomst)
                {
                    _goedevragen++;
                    aantalgoed.Text = _goedevragen.ToString();
                }

                if (_quescounter > 25)
                {
                    _timetoanswer.Stop();
                    MessageBox.Show("Dit onderdeel is klaar, klik op OK om door te gaan");
                    this.Close();
                    newOnderdeel.ShowDialog();
                }
                else
                {
                    timer.Text = "8";
                    vraagNR.Text = "Vraag " + _quescounter.ToString();
                    tbUitkomst.Text = "";
                }

                createSum();
            }
        }

        private void createSum()
        {
            _getal1 = myRandom.Next(10, 200);
            _getal2 = myRandom.Next(10, 200);

            _myOperator = myRandom.Next(1, 101);
            if (_myOperator < 51)
            {
                tbGetal1.Text = _getal1.ToString();
                tbGetal2.Text = _getal2.ToString();
                tbOperator.Text = "+";
            }
            else
            {
                tbOperator.Text = "-";
                if (_getal2 > _getal1)
                {
                    tbGetal2.Text = _getal1.ToString();
                    tbGetal1.Text = _getal2.ToString();
                }
                else
                {
                    tbGetal1.Text = _getal1.ToString();
                    tbGetal2.Text = _getal2.ToString();
                }
            }
        }
    }
}
