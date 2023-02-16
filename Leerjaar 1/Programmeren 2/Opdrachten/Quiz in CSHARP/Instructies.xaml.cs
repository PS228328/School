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

namespace Quiz_in_CSHARP
{
    /// <summary>
    /// Interaction logic for Questions.xaml
    /// </summary>
    public partial class Instructies : Window
    {
        Onderdeel1 onderdeel1 = new Onderdeel1();
        public Instructies()
        {
            InitializeComponent();
        }

        private void btStartEx_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult myResult = MessageBox.Show("Terugkeren is niet meer mogelijk hierna!", "Verdergaan?", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (myResult == MessageBoxResult.Yes)
            {
                btStartEx.Visibility = Visibility.Hidden;
                this.Close();
                onderdeel1.ShowDialog();
            }
            else
            {
                return;
            }
        }
    }
}
