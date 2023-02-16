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

namespace DEMO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int myInt = 0;
        DispatcherTimer _myTimer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            StartCounter();
        }

        private void StartCounter()
        {
            _myTimer.Interval = TimeSpan.FromSeconds(1);
            _myTimer.Tick += _myTimer_Tick;
            _myTimer.Start();
        }

        private void _myTimer_Tick(object sender, EventArgs e)
        {
            myInt = Int32.Parse(tbGetal.Text);
            myInt++;
            tbGetal.Text = myInt.ToString();
        }
    }
}
