using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Threading;

namespace Wpf_prg2_timers
{
    /// <summary>
    /// Interaction logic for WordRocket.xaml
    /// </summary>
    public partial class WordRocket : Window
    {
        //De timer die de linker margin van de raket aanpast       
        //De lijst waarin de woorden komen te staan        
        //Een random waarmee we random woorden uit de lijst kunnen kiezen       
        //de eindwaarde van de raket       

        public WordRocket(string sNamePlayer)
        {
            InitializeComponent();
            lblName.Content = sNamePlayer;

            //bewegen stopt bij breedte scherm - zwarte rectangle - lengte raket           
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //verschuif de Margin van het label van de raket
            lblWord.Margin = new Thickness(lblWord.Margin.Left + 10, lblWord.Margin.Top, 0, 0);

            //stop met bewegen al de linkerkant van de raket het eindpunt raakt

        }
        private void txtWordToCheck_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Alleen controleren wanneer beide controls geinitialiseerd zijn
            //Is het label gelijk aan het tekstvak en houdt geen rekening met hoofdletters                
            //punt erbij               
            //het volgende woord                        


        }
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {


        }
    }
}
