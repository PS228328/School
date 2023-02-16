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

namespace Demo_Method
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double _getal1 = 0;
        double _getal2 = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btBereken_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _getal1 = double.Parse(tbGetal1.Text);
                _getal2 = double.Parse(tbGetal2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is iets fout gegaan \n" + ex.Message);
            }

            double result = TelOp(_getal1, _getal2);
            tbResult.Text = result.ToString();
            
        }


        private double TelOp(double getal1, double getal2)
        {
            double result = 0;

            result = _getal1 + _getal2;

            return result;

        }

    }
}
