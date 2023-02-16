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

namespace Opfrisopdracht_WPF_Joris_Wulms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int counter = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void tbGetal_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbGetal.Text == "")
            {
                return;
            }
            try
            {
                counter = Int32.Parse(tbGetal.Text);
            }
            catch
            {
                MessageBox.Show("Vul aub een heel getal in!");
                return;
            }

            if (counter == 0)
            {
                MessageBox.Show("We zijn bij 0, je bent klaar!");
                tbGetal.Text = "";
                return;
            }

            while (counter > 0)
            {
                MessageBoxResult mijnresult = MessageBox.Show("De counter is nu " + counter + "\n" + "Druk op yes om deze met 1 te verhogen" + "\n" + "Druk op no om deze met 1 te verlagen" + "\n" + "Druk op cancel om dit proces af te breken", "Getal verhogen of verlagen", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);

                if (mijnresult == MessageBoxResult.Yes)
                {
                    counter++;
                    tbGetal.Text = counter.ToString();
                }
                else if (mijnresult == MessageBoxResult.No)
                {
                    counter--;
                    tbGetal.Text = counter.ToString();
                }
                else
                {
                    counter = 0;
                    tbGetal.Text = "";
                    return;
                }
            }
        }
    }
}
