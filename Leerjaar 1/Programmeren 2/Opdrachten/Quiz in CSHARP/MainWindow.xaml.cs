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

namespace Quiz_in_CSHARP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer _beginScreen = new DispatcherTimer();
        Instructies _screen1 = new Instructies();
        Random _colorRandom = new Random();
        public MainWindow()
        {
            InitializeComponent();
            _beginScreen.Start();
            _beginScreen.Interval = TimeSpan.FromMilliseconds(900);
            _beginScreen.Tick += _beginScreen_Tick;
        }

        private void _beginScreen_Tick(object sender, EventArgs e)
        {
            btStart.Background = new SolidColorBrush(
            Color.FromRgb((byte)_colorRandom.Next(0, 256),
                      (byte)_colorRandom.Next(0, 256),
                      (byte)_colorRandom.Next(0, 256)));

            btStart.Foreground = new SolidColorBrush(
            Color.FromRgb((byte)_colorRandom.Next(0, 256),
                      (byte)_colorRandom.Next(0, 256),
                      (byte)_colorRandom.Next(0, 256)));
        }

        private void btStart_Click(object sender, RoutedEventArgs e)
        {
            _beginScreen.Stop();
            btStart.Visibility = Visibility.Hidden;
            this.Close();
            _screen1.ShowDialog();
        }
    }
}
