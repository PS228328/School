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

namespace WPFappSimpleClock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        stopwatch myStopwatch = new stopwatch();
        countdown myCountdown = new countdown();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btStopwatch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                stopwatch myStopwatch = new stopwatch();

                myStopwatch.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btCountdown_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                countdown myCountdown = new countdown();
                myCountdown.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
