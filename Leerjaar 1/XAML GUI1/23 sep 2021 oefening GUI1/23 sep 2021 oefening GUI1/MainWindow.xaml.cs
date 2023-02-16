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

namespace _23_sep_2021_oefening_GUI1
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

        private void Button_Click(object sender, RoutedEventArgs e)

        {
            MessageBox.Show("Dank voor uw reservering!");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Voornaam.Text = "";
            Achternaam.Text = "";
            Eventuelebijzonderheden.Text = "";
        }
    }
}
