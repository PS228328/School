using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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
using static System.Net.Mime.MediaTypeNames;

namespace WpfAppKickOffLeerjaar2
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

        private string FindBomb(string givenWord)
        {
            return givenWord.ToLower().Contains("bomb") ? "Duck!!!" : "There is no bomb, relax.";
        }

        private void btDuck_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(FindBomb(tbWord.Text.ToLower()).ToString());
        }

        private void btSwitch_Click(object sender, RoutedEventArgs e)
        {
            if (spGoud.Visibility == Visibility.Visible)
            {
                spGoud.Visibility = Visibility.Hidden;
                spZilver.Visibility = Visibility.Visible;
            }
            else
            {
                spGoud.Visibility = Visibility.Visible;
                spZilver.Visibility = Visibility.Hidden;
            }
        }

        private void btSocks_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(CountSocks(tbSocks.Text.ToUpper()).ToString());
        }

        private int CountSocks(string input)
        {
            return input.ToCharArray().GroupBy(c => c).Select(c => c.Count() / 2).Sum();
        }
    }
}
