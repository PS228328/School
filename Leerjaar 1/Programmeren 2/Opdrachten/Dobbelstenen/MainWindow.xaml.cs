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

namespace Dobbelstenen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random _myRandom = new Random();
        DispatcherTimer _myTimer = new DispatcherTimer();
        int getal1 = 0;
        int getal2 = 0;
        int getal3 = 0;
        int getal4 = 0;
        int getal5 = 0;
        bool timerStarter = false;

        public MainWindow()
        {
            InitializeComponent();
            InitializeTimer();
        }

        public void InitializeTimer()
        {
            _myTimer.Interval = TimeSpan.FromSeconds(1);
            _myTimer.Tick += _myTimer_Tick;
        }

        private void _myTimer_Tick(object sender, EventArgs e)
        {
            if (!(bool)cbOne.IsChecked)
            {
                getal1 = _myRandom.Next(1, 7);
                imgOne.Source = GetImage(getal1);
            }
            if (!(bool)cbTwo.IsChecked)
            {
                getal2 = _myRandom.Next(1, 7);
                imgTwo.Source = GetImage(getal2);
            }
            if (!(bool)cbThree.IsChecked)
            {
                getal3 = _myRandom.Next(1, 7);
                imgThree.Source = GetImage(getal3);
            }
            if (!(bool)cbFour.IsChecked)
            {
                getal4 = _myRandom.Next(1, 7);
                imgFour.Source = GetImage(getal4);
            }
            if (!(bool)cbFive.IsChecked)
            {
                getal5 = _myRandom.Next(1, 7);
                imgFive.Source = GetImage(getal5);
            }

            CheckAllSixes();
        }

        private void btThrow_Click(object sender, RoutedEventArgs e)
        {
            if (timerStarter == true)
            {
                _myTimer.Stop();
                timerStarter = false;
                btThrow.Content = "Throw";
            }
            else
            {
                _myTimer.Start();
                timerStarter = true;
                btThrow.Content = "Stop throwing";
            }
        }

        private BitmapImage GetImage(int throwedNumber)
        {
            BitmapImage myImage = null;
            switch (throwedNumber)
            {
                case 1:
                    myImage = new BitmapImage(new Uri("NewFolder1/Dice_one.JPG", UriKind.Relative));
                    break;
                case 2:
                    myImage = new BitmapImage(new Uri("NewFolder1/Dice_two.JPG", UriKind.Relative));
                    break;
                case 3:
                    myImage = new BitmapImage(new Uri("NewFolder1/Dice_threes.JPG", UriKind.Relative));
                    break;
                case 4:
                    myImage = new BitmapImage(new Uri("NewFolder1/Dice_fours.JPG", UriKind.Relative));
                    break;
                case 5:
                    myImage = new BitmapImage(new Uri("NewFolder1/Dice_fives.JPG", UriKind.Relative));
                    break;
                case 6:
                    myImage = new BitmapImage(new Uri("NewFolder1/Dice_sixes.JPG", UriKind.Relative));
                    break;
                default:
                    MessageBox.Show("Wat raar...");
                    break;
            }
            return myImage;
        }

        private void btReset_Click(object sender, RoutedEventArgs e)
        {

        }
        private void CheckAllSixes()
        { 
            if (getal1 == 6)
            {
                cbOne.IsChecked = true;
            }
            if (getal2 == 6)
            {
                cbTwo.IsChecked = true;
            }
            if (getal3 == 6)
            {
                cbThree.IsChecked = true;
            }
            if (getal4 == 6)
            {
                cbFour.IsChecked = true;
            }
            if (getal5 == 6)
            {
                cbFive.IsChecked = true;
            }

            if (getal1 == 6 && getal2 == 6 && getal3 == 6 && getal4 == 6 && getal5 == 6)
            {
                allsixes allsixes = new allsixes();
                allsixes.ShowDialog();
                resetValues();
            }
        }
        private void resetValues()
        {
            getal1 = 0;
            getal2 = 0;
            getal3 = 0;
            getal4 = 0;
            getal5 = 0;
            imgOne.Source = new BitmapImage(new Uri("/NewFolder1/waiting.jpg", UriKind.Relative));
            imgTwo.Source = new BitmapImage(new Uri("/NewFolder1/waiting.jpg", UriKind.Relative));
            imgThree.Source = new BitmapImage(new Uri("/NewFolder1/waiting.jpg", UriKind.Relative));
            imgFour.Source = new BitmapImage(new Uri("/NewFolder1/waiting.jpg", UriKind.Relative));
            imgFive.Source = new BitmapImage(new Uri("/NewFolder1/waiting.jpg", UriKind.Relative));

            cbOne.IsChecked = false;
            cbTwo.IsChecked = false;
            cbThree.IsChecked = false;
            cbFour.IsChecked = false;
            cbFive.IsChecked = false;

            _myTimer.Stop();
            timerStarter = false;
            btThrow.Content = "Throw";
        }
    }
}