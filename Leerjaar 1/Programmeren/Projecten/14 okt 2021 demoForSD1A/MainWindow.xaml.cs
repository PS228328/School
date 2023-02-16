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

namespace _14_okt_2021_demoForSD1A
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

        private void BtGo_Click(object sender, RoutedEventArgs e)
        {
            string[] myArrayDieren = { "Leeuw", "Tijger", "Krokodil", "Aap", "Giraf", "Olifant" };

            tbOutput.Text = myArrayDieren[8];
            //\n betekent ga naar de volgende regel


        }
    }
}
