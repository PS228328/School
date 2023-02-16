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

namespace Voor_mezelf_oefenen_met_rgb_kleuren
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Red;
        int Green;
        int Blue;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void red_GotFocus(object sender, RoutedEventArgs e)
        {
            red.Text = "";
        }

        private void green_GotFocus(object sender, RoutedEventArgs e)
        {
            green.Text = "";
        }

        private void blue_GotFocus(object sender, RoutedEventArgs e)
        {
            blue.Text = "";
        }

        private void makeRGBsquare_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Red = Int32.Parse(red.Text);
                Green = Int32.Parse(green.Text);
                Blue = Int32.Parse(blue.Text);

                if (Red > 255 || Green > 255 || Blue > 255)
                {
                    MessageBox.Show("Vul aub nooit een hoger getal in dan 255!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            mySquare.Background = new SolidColorBrush(
                    Color.FromRgb((byte)Red,
                                  (byte)Green,
                                  (byte)Blue));
        }
    }
}
