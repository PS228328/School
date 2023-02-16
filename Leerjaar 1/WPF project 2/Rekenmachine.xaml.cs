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
using System.Windows.Shapes;

namespace WPF_project_2
{
    /// <summary>
    /// Interaction logic for Rekenmachine.xaml
    /// </summary>
    public partial class Rekenmachine : Window
    {
        public Rekenmachine()
        {
            InitializeComponent();
        }

        string input = string.Empty;
        double _getal1 = 0;
        double _getal2 = 0;
        string _getal3 = "";
        string _operator = null;
        string _getal = "";
        bool _getal1IsSet = false;
        bool _operatorIsSet = false;

        private void Nul_Click(object sender, RoutedEventArgs e)
        {
            string input = "0";
            LaatZien(Double.Parse(input));
        }

        private void Een_Click(object sender, RoutedEventArgs e)
        {
            string input = "1";
            LaatZien(Double.Parse(input));
        }

        private void Twee_Click(object sender, RoutedEventArgs e)
        {
            string input = "2";
            LaatZien(Double.Parse(input));
        }

        private void Drie_Click(object sender, RoutedEventArgs e)
        {
            string input = "3";
            LaatZien(Double.Parse(input));
        }

        private void Vier_Click(object sender, RoutedEventArgs e)
        {
            string input = "4";
            LaatZien(Double.Parse(input));
        }

        private void Vijf_Click(object sender, RoutedEventArgs e)
        {
            string input = "5";
            LaatZien(Double.Parse(input));
        }

        private void Zes_Click(object sender, RoutedEventArgs e)
        {
            string input = "6";
            LaatZien(Double.Parse(input));
        }

        private void Zeven_Click(object sender, RoutedEventArgs e)
        {
            string input = "7";
            LaatZien(Double.Parse(input));
        }

        private void Acht_Click(object sender, RoutedEventArgs e)
        {
            string input = "8";
            LaatZien(Double.Parse(input));
        }

        private void Negen_Click(object sender, RoutedEventArgs e)
        {
            string input = "9";
            LaatZien(Double.Parse(input));

        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {

            input = "";
            tbCal.Text = "";
            _getal = "";
            _getal1 = 0;
            _getal2 = 0;
            _getal3 = "";
            _operator = null;
            _operatorIsSet = false;
            _getal1IsSet = false;

        }

        private void Procent_Click(object sender, RoutedEventArgs e)
        {
            if (!_operatorIsSet)
            {
                _operator = "%";
                _operatorIsSet = true;
            }

            LaatZien();
        }

        private void Gedeeld_Click(object sender, RoutedEventArgs e)
        {
            if (!_operatorIsSet)
            {
                _operator = "÷";
                _operatorIsSet = true;
            }

            LaatZien();
        }

        private void Keer_Click(object sender, RoutedEventArgs e)
        {
            if (!_operatorIsSet)
            {
                _operator = "x";
                _operatorIsSet = true;
            }

            LaatZien();
        }

        private void Min_Click(object sender, RoutedEventArgs e)
        {
            if (!_operatorIsSet)
            {
                _operator = "-";
                _operatorIsSet = true;
            }

            LaatZien();
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            if (!_operatorIsSet)
            {
                _operator = "+";
                _operatorIsSet = true;
            }

            LaatZien();
        }

        private void Comma_Click(object sender, RoutedEventArgs e)
        {
            if (!_operatorIsSet)
            {
                _operator = ",";
                _operatorIsSet = true;
            }

            this.tbCal.Text = _getal1 + _operator + _getal2;
        }

        private void Is_Click(object sender, RoutedEventArgs e)
        {
            double uitkomst = 0;
            try
            {
                _getal1 = Double.Parse(_getal);
                _getal2 = Double.Parse(_getal3);
            }
            catch (Exception)
            {
                MessageBox.Show("Vul aub geldige waardes in!");
            }
            switch (_operator)
            {
                case ("-"):
                    uitkomst = _getal1 - _getal2;
                    break;
                case ("+"):
                    uitkomst = _getal1 + _getal2;
                    break;
                case ("x"):
                    uitkomst = _getal1 * _getal2;
                    break;
                case ("÷"):
                    uitkomst = _getal1 / _getal2;
                    break;
            }
            input = "";
            tbCal.Text = "";
            _getal1 = 0;
            _getal2 = 0;
            _getal3 = "";
            _getal = "";
            _operator = null;
            _getal1IsSet = false;
            _operatorIsSet = false;
            this.tbCal.Text = uitkomst.ToString();
            return;



        }

        private void LaatZien(double input)
        {
            if (!_operatorIsSet)
            {
                string StringInput = input.ToString();
                _getal += StringInput;
            }
            else
            {
                string StringInput2 = input.ToString();
                _getal3 += StringInput2;
            }

            if (_getal3 == "")
            {

                this.tbCal.Text = _getal + _operator;
            }
            else
            {
                this.tbCal.Text = _getal + _operator + _getal3;
            }



        }

        private void LaatZien()
        {

            if (_getal3 == "")
            {
                this.tbCal.Text = _getal + _operator;
            }
            else
            {
                this.tbCal.Text = _getal + _operator + _getal3;
            }

        }

        private void Mingetal_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Plusgetal_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
