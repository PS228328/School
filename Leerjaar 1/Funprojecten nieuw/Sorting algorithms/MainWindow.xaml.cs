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

namespace Sorting_algorithms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double getal1;
        double getal2;
        double getal3;
        double getal4;
        double getal5;
        double getal6;
        double getal7;
        double getal8;
        double getal9;
        double getal10;
        double getal11;
        double getal12;
        double getal13;
        double getal14;
        double getal15;
        double getal16;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                getal1 = Double.Parse(box1.Text);
                getal2 = Double.Parse(box2.Text);
                getal3 = Double.Parse(box3.Text);
                getal4 = Double.Parse(box4.Text);
                getal5 = Double.Parse(box5.Text);
                getal6 = Double.Parse(box6.Text);
                getal7 = Double.Parse(box7.Text);
                getal8 = Double.Parse(box8.Text);
                getal9 = Double.Parse(box9.Text);
                getal10 = Double.Parse(box10.Text);
                getal11 = Double.Parse(box11.Text);
                getal12 = Double.Parse(box12.Text);
                getal13 = Double.Parse(box13.Text);
                getal14 = Double.Parse(box14.Text);
                getal15 = Double.Parse(box15.Text);
                getal16 = Double.Parse(box16.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Vul aub in alle 16 boxen een getal in!");
                return;
            }

            double[] myArrayNumbers = { getal1, getal2, getal3, getal4, getal5, getal6, getal7, getal8, getal9, getal10, getal11, getal12, getal13, getal14, getal15, getal16 };

            Array.Reverse(myArrayNumbers);
            Array.Sort(myArrayNumbers);

            foreach (double myNumber in myArrayNumbers)
            {
                MessageBox.Show(myNumber + "");
            }
        }
    }
}
