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

namespace WpfAppSimpleCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double doubleGetal1; //Hier maak je een variabele aan, (een getal met komma's), die heet doubleGetal1
        double doubleGetal2;
        double doubleUitkomst;
        bool boolUitkomst; //Hier geef je aan dat boolUitkomst een bool is (dus true or false)

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            doubleGetal1 = Double.Parse(tbGetal1.Text); //Hier geef je aan dat doubleGetal1 het nummer is wat je invult in box tb_Getal 1 (en dit wordt door Double.Parse omgezet naar een getal)
            doubleGetal2 = Double.Parse(tbGetal2.Text); //Je mag zowel Int32 als double gebruiken
            doubleUitkomst = doubleGetal1 + doubleGetal2; //Hier tel je twee variabelen bij elkaar op
            tbUitkomst.Text = doubleUitkomst.ToString(); //Hier zorg je ervoor dat in het vak tbUitkomst de uitkomst van doubleUitkomst komt te staan, maar dan in een string
            boolUitkomst = (doubleGetal1 < doubleGetal2); //Met een bool is het true or false. Dus als het bovenste getal kleiner is dan het onderste getal zal er true komen te staan 
            MessageBox.Show(boolUitkomst.ToString()); //De bool wordt omgezet in string (gewone tekst)
        }
    }
    //UITLEG: Hier worden doubles gezien als getallen, vervolgens worden die opgeteld (zie regel 23, 24 en 25), doordat je dit vervolgens weer omzet in een string, snapt de gebruiker dit.
}   //UITLEG: Het commando ToString zorgt ervoor dat getallen (zoals de computer die ziet) dat die worden omgezet in tekst (getallen kunnen immers ook tekst zijn)
