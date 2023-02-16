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

namespace WpfAppWhile
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
            {
                int endValue = 0;
                try
                {
                    endValue = int.Parse(tbCounter.Text);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("fout" + ex);
                }
                int counter = 0;

                while (counter < endValue)
                {
                    counter++;
                    MessageBox.Show("Dit is de" + counter + "e keer dat we de loop doorgaan ");
                }

                
            }
        }

        private void btPink_Click(object sender, RoutedEventArgs e)
        {
            int endValue = Int32.Parse(tbCounter.Text);
            int counter = 0;

            while (counter < endValue)
            {
                counter++;
                MessageBox.Show("Dit is de " + counter + " de keer dat we de loop doorgaan.");
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            tbCounter.Text = .ToString(); //In het gele vak wordt de counter (Die telkens +1 wordt) omgezet in karakters
            counter = counter + 1; //simpele optelsom
            MessageBoxResult myMessageboxResult = MessageBox.Show("Stoppen of doorgaan?", "Titel", MessageBoxButton.YesNo, MessageBoxImage.Information);
            //Je maakt een variabele aan, die laat een message zien, en laat een ja of nee box zien
            if (myMessageboxResult == MessageBoxResult.No)
            {
                return;
            }
        }
    }
}
