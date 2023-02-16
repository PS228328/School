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

namespace EXTRA_opdracht_2_WPF_PRG_2_Joris_Wulms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int myInt = 0;
        Window2 myWindow2;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            tbGetal.Text = "";
        }

        private void btGo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                myInt = Int32.Parse(tbGetal.Text);
                this.Hide();
                myWindow2 = new Window2(myInt);
                myWindow2.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBoxResult myResult = MessageBox.Show(ex.Message + " Wil je toch doorgaan?" + "\n", "Foutmelding", MessageBoxButton.YesNo, MessageBoxImage.Warning);

                if (myResult == MessageBoxResult.Yes)
                {
                    MessageBox.Show("Geef nu een goed getal in");
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
