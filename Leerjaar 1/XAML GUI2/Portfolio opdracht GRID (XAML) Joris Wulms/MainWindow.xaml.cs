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

namespace Portfolio_opdracht_GRID__XAML__Joris_Wulms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random myRandomizer = new Random();
        BitmapImage[] myImages = new BitmapImage[5];
        Button[] _myButtons = new Button[9];

        public MainWindow()
        {
            InitializeComponent();
            ArrayImages();
            createButtonArray();
        }

        private void ArrayImages()
        {
            myImages[0] = new BitmapImage(new Uri("Assets/infamous.jpg", UriKind.Relative));
            myImages[1] = new BitmapImage(new Uri("Assets/infamous2.jpg", UriKind.Relative));
            myImages[2] = new BitmapImage(new Uri("Assets/infamous3.jpg", UriKind.Relative));
            myImages[3] = new BitmapImage(new Uri("Assets/infamous4.jpg", UriKind.Relative));
            myImages[4] = new BitmapImage(new Uri("Assets/infamous5.jpg", UriKind.Relative));

            Image.Source = myImages[myRandomizer.Next(0, 5)];
        }

        private void createButtonArray()
        {
            _myButtons[0] = button1;
            _myButtons[1] = button2;
            _myButtons[2] = button3;
            _myButtons[3] = button4;
            _myButtons[4] = button5;
            _myButtons[5] = button6;
            _myButtons[6] = button7;
            _myButtons[7] = button8;
            _myButtons[8] = button9;

            foreach (Button btn in _myButtons)
            {
                btn.Background = new SolidColorBrush(
                    Color.FromRgb((byte)myRandomizer.Next(0, 256),
                                  (byte)myRandomizer.Next(0, 256),
                                  (byte)myRandomizer.Next(0, 256)));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ArrayImages();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            createButtonArray();
        }
    }
}
