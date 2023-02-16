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

namespace Project_voor_video
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double getal1;
        double getal2;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            getal1 = double.Parse(tbGetal1.Text);

            if (getal1 < 5)
            {
                tbUitkomst.Background = Brushes.Red;
                tbUitkomst.Width = 250;
                tbUitkomst.Height = 100;
            }
            else
            {
                tbUitkomst.Background = Brushes.Yellow;
                tbUitkomst.Width = 200;
                tbUitkomst.Height = 100;
            }
            
        }
    }
}
