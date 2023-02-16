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

namespace Allereerste_opdracht_ooit_Joris_Wulms
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

        private void JW(object sender, RoutedEventArgs e)
        {
            JorisWulms.Background = Brushes.Red;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            JorisWulms.Background = Brushes.Yellow;
                
        }
    }
}
//UITLEG: Doormiddel van de property "Click" kun je een button programmeren. Dit gebeurt doordat de gebruiker 'klikt' op de button, en dan moet er iets gebeuren.
//Als er naast private void de naam van de button staat die je hebt ingevuld bij Click, kunnen we hem gaan programmeren.
//Tussen {} vul je de naam van je button in, (x:name) vervolgens typ je 'naam'.Background = Brushes.'JouwKleur'.
//Als je nu het programma start, krijg je een button die veranderd van kleur als je erop klikt.
