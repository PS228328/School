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

namespace Booleans
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool testing;
        double getal;
        string joris = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                getal = Double.Parse(Booltest.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Vul aub een geldig getal in!");
                return;
            }

            joris = Naam.Text;

            if(getal < 15)
            {
                testing = true;
            }
            else
            {
                testing = false;
            }

            MessageBox.Show("De uitkomst is " + testing + ", want je hebt het getal " + getal + " ingevuld. Dankjewel " + joris);

        }
    }
}
