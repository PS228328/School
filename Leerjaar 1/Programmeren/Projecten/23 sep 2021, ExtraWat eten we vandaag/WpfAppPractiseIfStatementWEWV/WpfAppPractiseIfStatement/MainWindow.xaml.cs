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

namespace WpfAppPractiseIfStatement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string ValueCombobox1 = null;
        private string ValueCombobox2 = null;
        private string ValueCombobox3 = null;
        private string[] _arrayGerechten = {/* optie 0 */ "Kunnen we in ieder geval een broodje kaas eten", 
            /* optie 1 */ "We kunnen een broodje kaas eten of een tosti maken", 
            /* optie 2 */ "We kunnen pannenkoeken bakken", 
            /* optie 3 */ "Niets te vreten" };
        public MainWindow()
        {
            InitializeComponent();
            //Hier kunt je de method selectElementComboBox() aanroepen zodat er een element wordt geselecteerd

        }

        private void btStart_Click(object sender, RoutedEventArgs e)
        { 
             ComboBoxItem ComboItemSelectedcbOne = (ComboBoxItem)cbOne.SelectedItem; //Met deze 2 regels kun je instellen dat je bij elke keuze een verschillende melding krijgt
              ValueCombobox1 = ComboItemSelectedcbOne.Content.ToString();
           
            watKunnenWeEten();
            MessageBox.Show("De waarde die in Box 1 is geselecteerd" + ValueCombobox1 + "\n" + " ComboBox 2 is: " + ValueCombobox2 + "\n" + " en ComboBox 3 is: " + ValueCombobox3);
        }

        private void watKunnenWeEten()
        {
            ComboBoxItem ComboItemSelectedcbOne = (ComboBoxItem)cbOne.SelectedItem; //Met deze 2 regels kun je instellen dat je bij elke keuze een verschillende melding krijgt
            ValueCombobox1 = ComboItemSelectedcbOne.Content.ToString();


            if (cbOne.Text == "Eieren, bloem en melk" && cbTwo.Text == "Koekenpan" && cbThree.Text == "Al het keukengerei werkt naar behoren")
            {
                tbGerecht.Text = ("We kunnen pannenkoeken bakken");
                return;
            }
            else if (cbOne.Text == "Kaas en brood" && cbTwo.Text == "Tosti-ijzer" && cbThree.Text == "Kaas is verschimmeld")
            {
                tbGerecht.Text = ("Niets te vreten");
            }
            else if (cbOne.Text == "Kaas en brood" && cbTwo.Text == "Tosti-ijzer")
            {
                tbGerecht.Text = ("We kunnen een broodje kaas eten of een tosti maken");
                return;
            }
            else if (cbOne.Text == "Kaas en brood" && cbTwo.Text != "Tosti-ijzer" && cbThree.Text != "Kaas is verschimmeld")
            {
                tbGerecht.Text = ("Kunnen we in ieder geval een broodje kaas eten");
                return;
            }
            else if (cbOne.Text == "Kaas en brood" && cbThree.Text == "Kaas is verschimmeld")
            {
                tbGerecht.Text = ("Niets te vreten");
            }
            else
            {
                tbGerecht.Text = ("Niets te vreten");
            }


              ComboBoxItem ComboItemSelectedcbTwo = (ComboBoxItem)cbTwo.SelectedItem; //Met deze 2 regels kun je instellen dat je bij elke keuze een verschillende melding krijgt

            ValueCombobox2 = ComboItemSelectedcbTwo.Content.ToString();

            ComboBoxItem ComboItemSelectedcbThree = (ComboBoxItem)cbOne.SelectedItem; //Met deze 2 regels kun je instellen dat je bij elke keuze een verschillende melding krijgt
            ValueCombobox3 = ComboItemSelectedcbThree.Content.ToString();

        }

        private void selectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //watKunnenWeEten();
        }

        private void selectElementComboBox()
        {
            cbOne.SelectedIndex = 0;
            cbTwo.SelectedIndex = 0;
            cbThree.SelectedIndex = 0;
        }
    }
}
