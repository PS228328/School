using ConsoleAppEindopdrachtDD2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using WpfAppEindopdrachtDD2.Views;

namespace WpfAppEindopdrachtDD2
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

        private void btnBinnenwedstrijd_Click(object sender, RoutedEventArgs e)
        {
            new WedstrijdBinnen().Show();
            this.Close();
        }

        private void btnBuitenwedstrijd_Click(object sender, RoutedEventArgs e)
        {
            new WedstrijdBuiten().Show();
            this.Close();
        }

        private void btnBioscoopuitje_Click(object sender, RoutedEventArgs e)
        {
            new UitjeBioscoop().Show();
            this.Close();
        }

        private void btnMuseumuitje_Click(object sender, RoutedEventArgs e)
        {
            new UitjeMuseum().Show();
            this.Close();
        }
    }
}
