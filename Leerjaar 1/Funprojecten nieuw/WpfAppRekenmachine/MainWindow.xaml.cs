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

namespace WpfAppRekenmachine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double _uitkomst = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bt0_Click(object sender, RoutedEventArgs e)
        {
            tbboxInOutput.Text += "0";
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            tbboxInOutput.Text += "1";
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            tbboxInOutput.Text += "2";
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            tbboxInOutput.Text += "3";
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            tbboxInOutput.Text += "4";
        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            tbboxInOutput.Text += "5";
        }

        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            tbboxInOutput.Text += "6";
        }

        private void bt7_Click(object sender, RoutedEventArgs e)
        {
            tbboxInOutput.Text += "7";
        }

        private void bt8_Click(object sender, RoutedEventArgs e)
        {
            tbboxInOutput.Text += "8";
        }

        private void bt9_Click(object sender, RoutedEventArgs e)
        {
            tbboxInOutput.Text += "9";
        }

        private void btHerstel_Click(object sender, RoutedEventArgs e)
        {
            tbboxInOutput.Text = "";
            tbInput.Text = "";
        }

        private void btPlus_Click(object sender, RoutedEventArgs e)
        {
            tbboxInOutput.Text += " + ";
        }

        private void btMin_Click(object sender, RoutedEventArgs e)
        {
            tbboxInOutput.Text += " - ";
        }

        private void btKeer_Click(object sender, RoutedEventArgs e)
        {
            tbboxInOutput.Text += " * ";
        }

        private void btGedeeldDoor_Click(object sender, RoutedEventArgs e)
        {
            tbboxInOutput.Text += " / ";
        }

        private void btIs_Click(object sender, RoutedEventArgs e)
        {
            tbInput.Text = tbboxInOutput.Text + " =";
            int operatert = 1;
            int counter = 0;

            string sum = tbboxInOutput.Text;
            string[] numbers = sum.Split(' ');
            double getal1 = 0;
            double getal2 = 0;

            while (counter < (numbers.Length - 1))
            {
                try
                {
                    getal1 = Double.Parse(numbers[counter]);
                    counter += 2;
                    getal2 = Double.Parse(numbers[counter]);
                }
                catch (Exception)
                {
                    tbboxInOutput.Text = "ERROR";
                    return;
                }

                switch (numbers[operatert])
                {
                    case "+":
                        _uitkomst = getal1 + getal2;
                        break;
                    case "-":
                        _uitkomst = getal1 - getal2;
                        break;
                    case "*":
                        _uitkomst = getal1 * getal2;
                        break;
                    case "/":
                        _uitkomst = getal1 / getal2;
                        break;
                    default:
                        break;
                }
                operatert += 2;
                numbers[counter] = _uitkomst.ToString();
            }
            tbboxInOutput.Text = _uitkomst.ToString();
        }

        private void btPlusMin_Click(object sender, RoutedEventArgs e)
        {
            string sum = tbboxInOutput.Text;
            string[] numbers = sum.Split(' ');
            double number = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == (numbers.Length - 1))
                {
                    try
                    {
                        number = Double.Parse(numbers[i]);
                    }
                    catch (Exception)
                    {
                        tbboxInOutput.Text = "ERROR";
                        return;
                    }
                }
            }
            
            number = number * -1;
            int counter = 0;
            tbboxInOutput.Text = "";

            while(counter < numbers.Length)
            {
                if (counter == (numbers.Length - 1))
                {
                    tbboxInOutput.Text = tbboxInOutput.Text + number.ToString();
                }
                else
                {
                    tbboxInOutput.Text = tbboxInOutput.Text + numbers[counter] + " ";
                }
                counter++;
            }
        }

        private void btKomma_Click(object sender, RoutedEventArgs e)
        {
            tbboxInOutput.Text += ",";
        }

        private void btHaakOpen_Click(object sender, RoutedEventArgs e)
        {
            tbboxInOutput.Text += "( ";
        }

        private void btHaakSluit_Click(object sender, RoutedEventArgs e)
        {
            tbboxInOutput.Text += " )";
        }
    }
}
