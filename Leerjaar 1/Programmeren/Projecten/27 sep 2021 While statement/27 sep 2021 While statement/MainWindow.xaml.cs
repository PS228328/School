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

namespace _27_sep_2021_While_statement
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
            int endNumber = 0; //variabele endNumber
            string strTemp = tbInput.Text; //(in tbInput zet je een getal neer)
            endNumber = Int32.Parse(strTemp); //Endnumber wordt omgezet in getallen, StrTemp
            int counter = 0; //aparte variabele
            while (counter <= endNumber) //zolang dit is, wordt er iets gedaan

            {
                tbText.Text = counter.ToString(); //In het gele vak wordt de counter (Die telkens +1 wordt) omgezet in karakters
                counter = counter + 1; //simpele optelsom
                MessageBoxResult myMessageboxResult = MessageBox.Show("Stoppen of doorgaan?", "Titel", MessageBoxButton.YesNo, MessageBoxImage.Information);
                //Je maakt een variabele aan, die laat een message zien, en laat een ja of nee box zien
                if (myMessageboxResult == MessageBoxResult.No)
                {
                    return;
                }
            }
        }



        private void StackPanel_GotFocus(object sender, RoutedEventArgs e)
        {
            //tbInput.Text = "";
        }

     
    }
}
