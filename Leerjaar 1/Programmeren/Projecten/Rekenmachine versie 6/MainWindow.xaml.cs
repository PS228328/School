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

namespace Rekenmachine_versie_6
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

        double getal1;
        double getal2;
        double getaluitkomst;

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
            if (btChanger.Background == Brushes.Red)
                tbGetal1.Text = tbGetal1.Text + "1";

            else if (btChanger.Background == Brushes.Green)
                tbGetal2.Text = tbGetal2.Text + "1";
        }

        private void btTwo_Click(object sender, RoutedEventArgs e)
        {
            if (btChanger.Background == Brushes.Red)
                tbGetal1.Text = tbGetal1.Text + "2";

            else if (btChanger.Background == Brushes.Green)
                tbGetal2.Text = tbGetal2.Text + "2";
        }

        private void btThree_Click(object sender, RoutedEventArgs e)
        {
            if (btChanger.Background == Brushes.Red)
                tbGetal1.Text = tbGetal1.Text + "3";

            else if (btChanger.Background == Brushes.Green)
                tbGetal2.Text = tbGetal2.Text + "3";
        }

        private void btFour_Click(object sender, RoutedEventArgs e)
        {
            if (btChanger.Background == Brushes.Red)
                tbGetal1.Text = tbGetal1.Text + "4";

            else if (btChanger.Background == Brushes.Green)
                tbGetal2.Text = tbGetal2.Text + "4";
        }

        private void btFive_Click(object sender, RoutedEventArgs e)
        {
            if (btChanger.Background == Brushes.Red)
                tbGetal1.Text = tbGetal1.Text + "5";

            else if (btChanger.Background == Brushes.Green)
                tbGetal2.Text = tbGetal2.Text + "5";
        }

        private void btSix_Click(object sender, RoutedEventArgs e)
        {
            if (btChanger.Background == Brushes.Red)
                tbGetal1.Text = tbGetal1.Text + "6";

            else if (btChanger.Background == Brushes.Green)
                tbGetal2.Text = tbGetal2.Text + "6";
        }

        private void btSeven_Click(object sender, RoutedEventArgs e)
        {
            if (btChanger.Background == Brushes.Red)
                tbGetal1.Text = tbGetal1.Text + "7";

            else if (btChanger.Background == Brushes.Green)
                tbGetal2.Text = tbGetal2.Text + "7";
        }

        private void btEight_Click(object sender, RoutedEventArgs e)
        {
            if (btChanger.Background == Brushes.Red)
                tbGetal1.Text = tbGetal1.Text + "8";

            else if (btChanger.Background == Brushes.Green)
                tbGetal2.Text = tbGetal2.Text + "8";
        }

        private void btNine_Click(object sender, RoutedEventArgs e)
        {
            if (btChanger.Background == Brushes.Red)
                tbGetal1.Text = tbGetal1.Text + "9";

            else if (btChanger.Background == Brushes.Green)
                tbGetal2.Text = tbGetal2.Text + "9";
        }

        private void btZero_Click(object sender, RoutedEventArgs e)
        {
            if (btChanger.Background == Brushes.Red)
                tbGetal1.Text = tbGetal1.Text + "0";

            else if (btChanger.Background == Brushes.Green)
                tbGetal2.Text = tbGetal2.Text + "0";
        }

        private void btKomma_Click(object sender, RoutedEventArgs e)
        {
            if (btChanger.Background == Brushes.Red)
                tbGetal1.Text = tbGetal1.Text + ",";

            else if (btChanger.Background == Brushes.Green)
                tbGetal2.Text = tbGetal2.Text + ",";
        }

        private void Button_Click(object sender, RoutedEventArgs e)


        {
            if (btChanger.Background == Brushes.Red)
            {
                btChanger.Background = Brushes.Green;
            }
            else if (btChanger.Background == Brushes.Green)
            {
                btChanger.Background = Brushes.Red;
            }
        }

        private void btEraser_Click(object sender, RoutedEventArgs e)
        {
            tbGetal1.Text = "";
            tbGetal2.Text = "";
            tbSymbool.Text = "";
        }

        private void btEqual_Click(object sender, RoutedEventArgs e)
        {
            getal1 = double.Parse(tbGetal1.Text);
            getal2 = double.Parse(tbGetal2.Text);
            getaluitkomst = double.Parse(tbAnswer.Text);

            if (tbSymbool.Text == "+")
            {
                getaluitkomst = getal1 + getal2;
                tbAnswer.Text = getaluitkomst.ToString();
            }
            else if (tbSymbool.Text == "-")
            {
                getaluitkomst = getal1 - getal2;
                tbAnswer.Text = getaluitkomst.ToString();
            }
            else if (tbSymbool.Text == "*")
            {
                getaluitkomst = getal1 * getal2;
                tbAnswer.Text = getaluitkomst.ToString();
            }
            else if (tbSymbool.Text == "/")
            {
                getaluitkomst = getal1 / getal2;
                tbAnswer.Text = getaluitkomst.ToString();
            }
        }
    }
}
