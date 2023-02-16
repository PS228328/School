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

namespace _20_sep_2021_Extra2_Joris_Wulms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            JorisWulms.Background = Brushes.Red;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            JorisWulms.Background = Brushes.Yellow;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            JorisWulms.Background = Brushes.Blue;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            JorisWulms.Background = Brushes.White;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            JorisWulms.Background = Brushes.Black;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            JorisWulms.Background = Brushes.Green;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            JorisWulms.Background = Brushes.Orange;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            JorisWulms.Background = Brushes.Purple;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            JorisWulms.Background = Brushes.Gray;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            JorisWulms.Background = Brushes.Pink;
        }
    }
}
