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

namespace _14_okt_2021_oefenen_met_stringen
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

        int counter = 0;

        private void btJoris_Click(object sender, RoutedEventArgs e)

        {
            string[] collegaLijst = { "Joris", "Shaelyn", "Bjork", "Reuske", "Nicole", "Emel", "Damien", "Meike", "Nikki", "Emma", "Pleun", "Kimberley", "Vienne", "Amber", "Natascha", "Merle" };
            int aantalCollegas = collegaLijst.Length;

            if (counter < aantalCollegas)
            {
                tbJoris.Text = collegaLijst[counter] + "\n";
            }
            counter++;

        }
    }
}
