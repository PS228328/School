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
    /// Interaction logic for stopwatch.xaml
    /// </summary>
    public partial class stopwatch : Window
    {
        DispatcherTimer _myTimer = new DispatcherTimer();
        bool onoff = false;
        public stopwatch()
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
            int Seconds;
            int Minutes;

            Seconds = Int32.Parse(seconds.Text);
            Seconds++;

            if (Seconds < 10)
            {
                seconds.Text = "0" + Seconds.ToString();
            }
            else
            {
                seconds.Text = Seconds.ToString();
            }

            if (Seconds == 60)
            {
                Seconds = 0;
                Minutes = Int32.Parse(minutes.Text);
                Minutes++;

                if (Minutes < 10)
                {
                    minutes.Text = "0" + Minutes.ToString();
                    seconds.Text = "0" + Seconds.ToString();
                }
                else
                {
                    minutes.Text = Minutes.ToString();
                    seconds.Text = "0" + Seconds.ToString();
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
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
                btStart.Content = "Stop";
            }
        }

        private void btStop_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
