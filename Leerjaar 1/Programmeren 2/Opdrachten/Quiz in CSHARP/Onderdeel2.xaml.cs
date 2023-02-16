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
    /// Interaction logic for Onderdeel2.xaml
    /// </summary>
    public partial class Onderdeel2 : Window
    {
        public Onderdeel2()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tijdens dit onderdeel kun je, in tegenstelling tot onderdeel 1, door de vragen heen bladeren. Je krijgt 12 vragen waar je er minimaal 10 goed moet hebben. Je krijgt voor alle vragen samen 15 minuten de tijd.");
            MessageBoxResult myResult = MessageBox.Show("Wil je doorgaan? Terugkeren is niet meer mogelijk hierna", "Doorgaan?", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (myResult == MessageBoxResult.Yes)
            {
                tbOnderdeel.Visibility = Visibility.Hidden;
                btStart.Visibility = Visibility.Hidden;

                int counter = 0;
                while (counter < 12)
                {
                    counter++;
                    Button myButton = new Button();
                    myButton.Width = 70;
                    myButton.Height = 70;
                    myButton.Background = Brushes.Cyan;
                    myButton.Foreground = Brushes.White;
                    myButton.Content = counter.ToString();
                    myButton.FontSize = 20;
                    myButton.FontWeight = FontWeights.Bold;
                    myPanel.Children.Add(myButton);
                }
            }
            else
            {
                return;
            }
        }
    }
}
