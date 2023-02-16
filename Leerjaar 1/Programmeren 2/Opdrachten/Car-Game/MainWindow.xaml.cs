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

namespace Car_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer _counttime = new DispatcherTimer();
        DispatcherTimer _mover = new DispatcherTimer();
        DispatcherTimer _spawnOil = new DispatcherTimer();
        DispatcherTimer _oilRain = new DispatcherTimer();

        Random rndRandomizer = new Random();

        int _time = 0;
        int _carMargin = 0;
        double _difficulty = 2;
        double _oilwidth = 60;
        double _oilheight = 90;
        int _oilsizerTick = 0;

        public MainWindow()
        {
            InitializeComponent();
            _counttime.Interval = TimeSpan.FromSeconds(1);
            _counttime.Tick += _counttime_Tick;

            _mover.Interval = TimeSpan.FromMilliseconds(10);
            _mover.Tick += _mover_Tick;

            _spawnOil.Interval = TimeSpan.FromSeconds(_difficulty);
            _spawnOil.Tick += _spawnOil_Tick;

            _oilRain.Interval = TimeSpan.FromMilliseconds(20);
            _oilRain.Tick += _oilRain_Tick;
        }

        private void btOilRain_Click(object sender, RoutedEventArgs e)
        {
            spOptions.Visibility = Visibility.Hidden;
            car.Visibility = Visibility.Visible;
            MessageBox.Show("Welcome to the Oil Rain game! Press OK to continue");

            StackPanel Explanation = new StackPanel();
            Explanation.HorizontalAlignment = HorizontalAlignment.Center;
            Explanation.VerticalAlignment = VerticalAlignment.Center;
            myGrid.Children.Add(Explanation);

            TextBlock explain1 = new TextBlock();
            explain1.Text = "The black car is your car. You have to avoid the oil drops. It's game over when you hit 3 oil drops with your car";
            explain1.Background = Brushes.Red;
            explain1.Foreground = Brushes.White;
            explain1.FontSize = 23;
            explain1.FontWeight = FontWeights.Bold;
            explain1.Height = 50;
            explain1.Width = 1200;

            Button startGame = new Button();
            startGame.Content = "Start!";
            startGame.Background = Brushes.LightBlue;
            startGame.FontSize = 18;
            startGame.Foreground = Brushes.Black;
            startGame.Width = 150;
            startGame.Margin = new Thickness(0, 30, 0, 0);
            startGame.Click += StartGame_Click;

            Explanation.Children.Add(explain1);
            Explanation.Children.Add(startGame);
        }

        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            _counttime.Start();
            _mover.Start();
            _spawnOil.Start();
            _oilRain.Start();

            Button myButton = e.Source as Button;
            StackPanel parent = (StackPanel)myButton.Parent;
            myGrid.Children.Remove(parent);

            spFunctions.Visibility = Visibility.Visible;
            spFaults.Visibility = Visibility.Visible;
        }

        private void _counttime_Tick(object sender, EventArgs e)
        {
            _time++;
            _oilsizerTick++;
            tbPoints.Text = _time.ToString();
        }

        private void _mover_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.Right))
            {
                car.Source = new BitmapImage(new Uri("C:/School/Programmeren 2/Opdrachten/Car-Game/Assets/car right.jpg"));
                if (_carMargin > myGrid.ActualWidth - 110)
                {
                    return;
                }
                _carMargin += 3;
            }

            if (Keyboard.IsKeyDown(Key.Left))
            {
                car.Source = new BitmapImage(new Uri("C:/School/Programmeren 2/Opdrachten/Car-Game/Assets/car left.jpg"));
                if (_carMargin < 1)
                {
                    return;
                }
                _carMargin -= 3;
            }

            car.Margin = new Thickness(_carMargin, 0, 0, 170);
        }

        private void _spawnOil_Tick(object sender, EventArgs e)
        {
            Image img = new Image();
            img.Source = new BitmapImage(new Uri("C:/School/Programmeren 2/Opdrachten/Car-Game/Assets/oil.jpg"));
            img.Width = _oilwidth;
            img.Height = _oilheight;

            double dbLeft = (rndRandomizer.NextDouble() * myGrid.ActualWidth) - img.Width;
            img.HorizontalAlignment = HorizontalAlignment.Left;
            img.VerticalAlignment = VerticalAlignment.Top;
            img.Margin = new Thickness(dbLeft, 0, 0, 0);
            myGrid.Children.Add(img);

            if(_oilsizerTick > 10)
            {
                _oilsizerTick = 0;
                if(_oilwidth < 150)
                {
                    _oilwidth += 15;
                    _oilheight += 30;
                }
                if(_difficulty > 0.5)
                {
                    _difficulty -= 0.2;
                }
            }
        }

        private void _oilRain_Tick(object sender, EventArgs e)
        {
            foreach (Image img in myGrid.Children.OfType<Image>())
            {
                if (img != car)
                {
                    img.Margin = new Thickness(img.Margin.Left, img.Margin.Top + 2, 0, 0);

                    if (GetRectOfImage(img).IntersectsWith(GetRectOfImage(car)))
                    {
                        myGrid.Children.Remove(img);
                        if(fault3.Background == Brushes.Green)
                        {
                            fault3.Background = Brushes.Red;
                        }
                        else if(fault2.Background == Brushes.Green)
                        {
                            fault2.Background = Brushes.Red;
                        }
                        else if(fault1.Background == Brushes.Green)
                        {
                            fault1.Background = Brushes.Red;
                            MessageBox.Show("Game over...");
                            _counttime.Stop();
                            _mover.Stop();
                            _spawnOil.Stop();
                            _oilRain.Stop();
                            removeAllItems();
                        }
                        return;
                    }
                    else if (img.Margin.Top >= myGrid.ActualHeight - img.ActualHeight)
                    {
                        myGrid.Children.Remove(img);
                        return;
                    }
                }
            }
        }

        private Rect GetRectOfImage(Image img)
        {
            Point pRectLocation = img.TranslatePoint(new Point(0, 0), myGrid);
            return new Rect(pRectLocation.X, pRectLocation.Y, img.ActualWidth, img.ActualHeight);
        }

        private void removeAllItems()
        {
            myGrid.Children.Clear();
        }

        private void btPause_Click(object sender, RoutedEventArgs e)
        {
            if (btPause.Background == Brushes.Orange)
            {
                btPause.Content = "Resume";
                btPause.Background = Brushes.Green;
                _counttime.Stop();
                _mover.Stop();
                _spawnOil.Stop();
                _oilRain.Stop();
                MessageBox.Show("Game in pause mode");
            }
            else
            {
                btPause.Content = "Pause";
                btPause.Background = Brushes.Orange;
                _counttime.Start();
                _mover.Start();
                _spawnOil.Start();
                _oilRain.Start();
            }
        }

        private void btStop_Click(object sender, RoutedEventArgs e)
        {
            _counttime.Stop();
            _mover.Stop();
            _spawnOil.Stop();
            _oilRain.Stop();
            MessageBoxResult myResult = MessageBox.Show("Do you really want to stop?", "Stop game", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (myResult != MessageBoxResult.Yes)
            {
                _counttime.Start();
                _mover.Start();
                _spawnOil.Start();
                _oilRain.Start();
            }
            else
            {
                spOptions.Visibility = Visibility.Visible;
                spFunctions.Visibility = Visibility.Hidden;
                _time = 0;
            }
        }
    }
}
