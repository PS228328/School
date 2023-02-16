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

namespace Euro_Truck_Simulator_2___Levelrankings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int level;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                level = Int32.Parse(levelchecker.Text);

                if (level < 0)
                {
                    MessageBox.Show("Dit getal is niet geldig");
                }
                else if (level >= 0 && level < 5)
                {
                    MessageBox.Show("Je bent een beginner op level " + level);
                }
                else if (level >= 5 && level < 10)
                {
                    MessageBox.Show("Je bent een enthousiasteling op level " + level);
                }
                else if (level >= 10 && level < 15)
                {
                    MessageBox.Show("Je bent een ervaren werken op level " + level);
                }
                else if (level >= 15 && level < 20)
                {
                    MessageBox.Show("Je bent een professional op level " + level);
                }
                else if (level >= 20 && level < 25)
                {
                    MessageBox.Show("Je bent een meester op level " + level);
                }
                else if (level >= 25 && level < 30)
                {
                    MessageBox.Show("Je bent een instructeur op level " + level);
                }
                else if (level >= 30 && level < 40)
                {
                    MessageBox.Show("Je bent een elite op level " + level);
                }
                else if (level >= 40 && level < 50)
                {
                    MessageBox.Show("Je bent een koning op level " + level);
                }
                else if (level >= 30 && level < 40)
                {
                    MessageBox.Show("Je bent een elite op level " + level);
                }
                else if (level >= 40 && level < 50)
                {
                    MessageBox.Show("Je bent een koning op level " + level);
                }
                else if (level >= 50 && level < 100)
                {
                    MessageBox.Show("Je bent een legende op level " + level);
                }
                else if (level >= 100)
                {
                    MessageBox.Show("Je bent een kampioen op level " + level);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Vul alsjeblieft een getal in");
            }
        }
    }
}
