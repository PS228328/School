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

namespace WpfAppSimpleCalculator
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

        private void btPlus_Click(object sender, RoutedEventArgs e)
        {
            tbSymbool.Text = "+";
        }

        private void btMin_Click(object sender, RoutedEventArgs e)
        {
            tbSymbool.Text = "-";
        }

        private void btKeer_Click(object sender, RoutedEventArgs e)
        {
            tbSymbool.Text = "*";
        }

        private void btGedeeldDoor_Click(object sender, RoutedEventArgs e)
        {
            tbSymbool.Text = "/";
        }

        private void btOne_Click(object sender, RoutedEventArgs e)
        {
            tbGetal1.Text = "1";
        }

    }
}
