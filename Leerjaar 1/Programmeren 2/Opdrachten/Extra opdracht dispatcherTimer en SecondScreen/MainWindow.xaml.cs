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

namespace Extra_opdracht_dispatcherTimer_en_SecondScreen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer _myTimer = new DispatcherTimer();
        bool TimerRunning = true;
        go _mySecondScreen = new go();
        int counter = 0;

        public MainWindow()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TimerRunning == true)
            {
                _myTimer.Start();
                btStart.Content = "Stop";
                TimerRunning = false;
            }
            else
            {
                _myTimer.Stop();
                btStart.Content = "Start";
                TimerRunning = true;
            }
        }

        private void InitializeTimer()
        {
            _myTimer.Interval = TimeSpan.FromSeconds(1);
            _myTimer.Tick += _myTimer_Tick;
        }
        
        private void _myTimer_Tick(object sender, EventArgs e)
        {
            counter++;
            tbGetal.Text = counter.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            counter = 0;
            tbGetal.Text = counter.ToString();
            _myTimer.Stop();
            btStart.Content = "Start";
            TimerRunning = true;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            _mySecondScreen.ShowDialog();
        }
    }
}
