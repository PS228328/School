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

namespace Animation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int getal = 800;
        DispatcherTimer _myTimer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _myTimer.Interval = TimeSpan.FromMilliseconds(10);
            _myTimer.Tick += _myTimer_Tick;
            _myTimer.Start();
            myButton.Content = "";
        }
        private void _myTimer_Tick(object sender, EventArgs e)
        {
            if (getal == 0)
            {
                return;
            }
            myButton.Width = getal;
            myButton.Height = getal;

            getal = getal - 5;
        }
    }
}
