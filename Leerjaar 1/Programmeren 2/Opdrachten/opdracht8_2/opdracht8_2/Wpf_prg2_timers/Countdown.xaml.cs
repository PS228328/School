using Microsoft.Win32;
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

namespace Wpf_prg2_timers
{
    /// <summary>
    /// Interaction logic for Countdown.xaml
    /// </summary>
    public partial class Countdown : Window
    {
        DispatcherTimer myTimer = new DispatcherTimer();
        int counter;

        public Countdown()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        { 
            myTimer.Start();
            myTimer.Interval = new TimeSpan(0, 0, 0, 1);
            myTimer.Tick += MyTimer_Tick;
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text == "") 
            {
                MessageBox.Show("Vul aub een naam in!!");
                return;
            }
            myTimer.Stop();
            string MyName = txtName.Text;
            Bartender win = new Bartender(MyName);
            win.Show();
            this.Close();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            counter = Int32.Parse(txtNumber.Text);
            counter--;
            txtNumber.Text = counter.ToString();

            if (counter == 0)
            {
                MessageBox.Show("Te laat!");
                this.Close();
                myTimer.Stop();
                return;
            }
        }
    }
}
