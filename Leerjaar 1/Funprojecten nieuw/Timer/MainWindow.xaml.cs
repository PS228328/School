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

namespace Timer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromMilliseconds(100);
            _timer.Tick += _timer_Tick;
        }

        private DispatcherTimer _timer;
        private int _Millieseconds = 0;
        private bool _started = false;

        private void _timer_Tick(object sender, EventArgs e)
        {
            if(_Millieseconds < 41)
            {
                _Millieseconds++;
            }
            else 
            {
                _timer.Stop();
                _started = false;
                _Millieseconds = 0;
            }
        }
    }
}
