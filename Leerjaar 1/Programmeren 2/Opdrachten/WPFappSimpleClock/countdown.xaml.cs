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

namespace WPFappSimpleClock
{
    /// <summary>
    /// Interaction logic for countdown.xaml
    /// </summary>
    public partial class countdown : Window
    {
        int Minutes;
        int Seconds;
        DispatcherTimer _myTimer = new DispatcherTimer();
        bool onoff = false;

        public countdown()
        {
            InitializeComponent();
            InitializeTimer();
        }

        public void InitializeTimer()
        {
            _myTimer.Interval = TimeSpan.FromMilliseconds(1000);
            _myTimer.Tick += _myTimer_Tick;
        }

        private void _myTimer_Tick(object sender, EventArgs e)
        {
            Seconds--;

            if (Seconds < 0)
            {
                Seconds = 59;
                Minutes--;
            }

            if (Seconds < 10)
            {
                tbseconds.Text = "0" + Seconds.ToString();
            }
            else
            {
                tbseconds.Text = Seconds.ToString();
            }

            if (Minutes < 10)
            {
                tbminutes.Text = "0" + Minutes.ToString();
            }
            else
            {
                tbminutes.Text = Minutes.ToString();
            }

            if (Minutes == 0 && Seconds == 0)
            {
                MessageBox.Show("Time!!");
                _myTimer.Stop();
                return;
            }
        }

        private void btStart_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Minutes = Int32.Parse(minutes.Text);
                Seconds = Int32.Parse(seconds.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vul aub hele minuten en seconden in in beide tekstvakken!");
            }

            if (onoff == true)
            {
                onoff = false;
                _myTimer.Stop();
                btStart.Content = "Start";
            }
            else
            {
                onoff = true;
                _myTimer.Start();
                btStart.Content = "Pauze";
            }

            minutes.Visibility = Visibility.Hidden;
            seconds.Visibility = Visibility.Hidden;

            tbminutes.Visibility = Visibility.Visible;
            tbseconds.Visibility = Visibility.Visible;

            minutes.Text = tbminutes.Text;
            seconds.Text = tbseconds.Text;

            if (Minutes == 0 && Seconds == 0)
            {
                MessageBox.Show("Time!!");
                _myTimer.Stop();
                return;
            }
        }

        private void btStop_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
