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

namespace WPF_project_2
{
    /// <summary>
    /// Interaction logic for timer.xaml
    /// </summary>
    public partial class timer : Window
    {
        DispatcherTimer _refresher = new DispatcherTimer();
        DispatcherTimer _refresher2 = new DispatcherTimer();

        bool timer1 = false;
        bool timer2 = false;

        public timer()
        {
            InitializeComponent();
            initializeDispatcherTimers();
        }

        private void initializeDispatcherTimers()
        {
            _refresher2.Interval = TimeSpan.FromMilliseconds(1000);
            _refresher2.Tick += _refresher2_Tick;
        }

        private void btSetTime_Click(object sender, RoutedEventArgs e)
        {
            if (timer1 == false && spInfo.Visibility == Visibility.Hidden)
            {
                _refresher.Start();
                _refresher.Interval = TimeSpan.FromMilliseconds(1000);
                _refresher.Tick += _refresher_Tick;
                timer1 = true;
            }
        }

        private void _refresher_Tick(object sender, EventArgs e)
        {
            var src = DateTime.Now;

            if (src.Hour < 10)
            {
                tbHours.Text = "0" + src.Hour.ToString();
            }
            else
            {
                tbHours.Text = src.Hour.ToString();
            }
            if (src.Minute < 10)
            {
                tbMinutes.Text = "0" + src.Minute.ToString();
            }
            else
            {
                tbMinutes.Text = src.Minute.ToString();
            }
            if (src.Second < 10)
            {
                tbSeconds.Text = "0" + src.Second.ToString();
            }
            else
            {
                tbSeconds.Text = src.Second.ToString();
            }
        }

        private void btSetTimeManual_Click(object sender, RoutedEventArgs e)
        {
            if (btSetTimeManual.Background == Brushes.Blue)
            {
                if (timer1 == true)
                {
                    _refresher.Stop();
                    timer1 = false;
                    btSetTime.Visibility = Visibility.Hidden;
                }
                if (timer2 == true)
                {
                    _refresher2.Stop();
                    timer2 = false;
                }
                tbHours.Text = "";
                tbMinutes.Text = "";
                tbSeconds.Text = "";

                spInfo.Visibility = Visibility.Visible;
                spInput.Visibility = Visibility.Visible;

                MessageBox.Show("Please give input in the white boxes. Press the button again to start the timer");
                btSetTimeManual.Background = Brushes.Red;
            }
            else
            {
                int h = 0;
                int m = 0;
                int s = 0;

                try
                {
                    h = Int32.Parse(tbInputh.Text);
                    m = Int32.Parse(tbInputm.Text);
                    s = Int32.Parse(tbInputs.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please give a valid number in all textboxes!");
                    return;
                }

                if (h > 23 || h < 0)
                {
                    MessageBox.Show("You have to enter a number between 0 and 24 for hours");
                    return;
                }
                if (m > 59 || m < 0)
                {
                    MessageBox.Show("You have to enter a number between 0 and 60 for minutes");
                    return;
                }
                if (s > 59 || s < 0)
                {
                    MessageBox.Show("You have to enter a number between 0 and 24 for seconds");
                    return;
                }

                btSetTimeManual.Background = Brushes.Blue;
                if (timer2 == false)
                {
                    timer2 = true;
                    _refresher2.Start();
                }

                if (h < 10)
                {
                    tbHours.Text = "0" + h.ToString();
                }
                else
                {
                    tbHours.Text = h.ToString();
                }
                if (m < 10)
                {
                    tbMinutes.Text = "0" + m.ToString();
                }
                else
                {
                    tbMinutes.Text = m.ToString();
                }
                if (s < 10)
                {
                    tbSeconds.Text = "0" + s.ToString();
                }
                else
                {
                    tbSeconds.Text = s.ToString();
                }
                spInfo.Visibility = Visibility.Hidden;
                spInput.Visibility = Visibility.Hidden;
                btSetTimeManual.Visibility = Visibility.Hidden;
                btSetTimeStop.Visibility = Visibility.Visible;
            }
        }

        private void _refresher2_Tick(object sender, EventArgs e)
        {
            int h = 0;
            int m = 0;
            int s = 0;

            h = Int32.Parse(tbHours.Text);
            m = Int32.Parse(tbMinutes.Text);
            s = Int32.Parse(tbSeconds.Text);

            s++;
            if (s < 60)
            {
                if (s < 10)
                {
                    tbSeconds.Text = "0" + s.ToString();
                }
                else
                {
                    tbSeconds.Text = s.ToString();
                }
            }
            else
            {
                s = 0;
                tbSeconds.Text = "0" + s.ToString();
                m++;

                if (m < 60)
                {
                    if (m < 10)
                    {
                        tbMinutes.Text = "0" + m.ToString();
                    }
                    else
                    {
                        tbMinutes.Text = m.ToString();
                    }
                }
                else
                {
                    h++;
                    m = 0;
                    if (h < 24)
                    {
                        if (h < 10)
                        {
                            tbHours.Text = "0" + h.ToString();
                            tbMinutes.Text = "0" + m.ToString();
                        }
                        else
                        {
                            tbHours.Text = h.ToString();
                            tbMinutes.Text = "0" + m.ToString();
                        }
                    }
                    else
                    {
                        tbHours.Text = "00";
                        tbMinutes.Text = "00";
                        tbSeconds.Text = "00";
                    }
                }
            }
        }

        private void btSetTimeStop_Click(object sender, RoutedEventArgs e)
        {
            if (timer2 == true)
            {
                timer2 = false;
                btSetTime.Visibility = Visibility.Visible;
                btSetTimeManual.Visibility = Visibility.Visible;
                btSetTimeStop.Visibility = Visibility.Hidden;
                _refresher2.Stop();
            }
        }
    }
}
