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

namespace Gewoon_maar_wat_programmeren
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random myRandom = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Speelveldcreeren_Click(object sender, RoutedEventArgs e)
        {
            int myresource = myRandom.Next(1, 6);

            if(myresource == 1)
            {
                topleft.Background = Brushes.DarkGreen;
            }
            else if(myresource == 2)
            {
                topleft.Background = Brushes.Red;
            }
            else if (myresource == 3)
            {
                topleft.Background = Brushes.LightGreen;
            }
            else if (myresource == 4)
            {
                topleft.Background = Brushes.Yellow;
            }
            else if (myresource == 5)
            {
                topleft.Background = Brushes.LightGray;
            }

            int myresource2 = myRandom.Next(1, 6);

            if (myresource2 == 1)
            {
                topmiddle.Background = Brushes.DarkGreen;
            }
            else if (myresource2 == 2)
            {
                topmiddle.Background = Brushes.Red;
            }
            else if (myresource2 == 3)
            {
                topmiddle.Background = Brushes.LightGreen;
            }
            else if (myresource2 == 4)
            {
                topmiddle.Background = Brushes.Yellow;
            }
            else if (myresource2 == 5)
            {
                topmiddle.Background = Brushes.LightGray;
            }
        }
    }
}
