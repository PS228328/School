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

namespace OefeningWhilePokemonEvolutie
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

        private void btnLevelUp_Click(object sender, RoutedEventArgs e)
        {
            int counter = int.Parse(tbLevel.Text);
            counter++;
            tbLevel.Text = counter.ToString();

            if (counter > 99)
            {
                counter = counter - 1;
                tbLevel.Text = counter.ToString();

                MessageBox.Show("You reached the maximum amount");
            }

        }

        private void btnLevelToMax_Click(object sender, RoutedEventArgs e)
        {

        }
    
    }
}
