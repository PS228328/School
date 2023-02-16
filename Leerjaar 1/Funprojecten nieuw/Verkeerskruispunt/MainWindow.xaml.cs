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

namespace Verkeerskruispunt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer _myTimer = new DispatcherTimer();
        bool stoporstart = false;
        public MainWindow()
        {
            InitializeComponent();
            _myTimer.Interval = TimeSpan.FromSeconds(1);
            _myTimer.Tick += _myTimer_Tick;
        }

        private void _myTimer_Tick(object sender, EventArgs e)
        {
            newCarLeft();
            newCarRight();
            newCarTop();
            newCarBottom();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (stoporstart == true)
            {
                _myTimer.Stop();
                stoporstart = false;
                myButton.Content = "Start!";
            }
            else
            {
                _myTimer.Start();
                stoporstart = true;
                myButton.Content = "Stop";
            }
        }

        private void newCarLeft()
        {
            Image img = new Image();
            img.Source = new BitmapImage(new Uri("Assets/car.jpg", UriKind.Relative));
            img.Width = 100;
            img.Height = 120;

            img.HorizontalAlignment = HorizontalAlignment.Left;
            img.VerticalAlignment = VerticalAlignment.Center;
            img.Margin = new Thickness(0, 0, 0, 0);
            spawnLeft.Children.Add(img);
        }

        private void newCarRight()
        {
            Image img = new Image();
            img.Source = new BitmapImage(new Uri("Assets/car-right.jpg", UriKind.Relative));
            img.Width = 100;
            img.Height = 120;

            img.HorizontalAlignment = HorizontalAlignment.Right;
            img.VerticalAlignment = VerticalAlignment.Center;
            img.Margin = new Thickness(0, 0, 0, 0);
            spawnRight.Children.Add(img);
        }

        private void newCarTop()
        {
            Image img = new Image();
            img.Source = new BitmapImage(new Uri("Assets/car-down.jpg", UriKind.Relative));
            img.Width = 100;
            img.Height = 120;

            img.HorizontalAlignment = HorizontalAlignment.Center;
            img.VerticalAlignment = VerticalAlignment.Top;
            img.Margin = new Thickness(0, 0, 0, 0);
            spawnTop.Children.Add(img);
        }

        private void newCarBottom()
        {
            Image img = new Image();
            img.Source = new BitmapImage(new Uri("Assets/car-up.jpg", UriKind.Relative));
            img.Width = 100;
            img.Height = 120;

            img.HorizontalAlignment = HorizontalAlignment.Center;
            img.VerticalAlignment = VerticalAlignment.Bottom;
            img.Margin = new Thickness(0, 0, 0, 0);
            spawnBottom.Children.Add(img);
        }
    }
}
