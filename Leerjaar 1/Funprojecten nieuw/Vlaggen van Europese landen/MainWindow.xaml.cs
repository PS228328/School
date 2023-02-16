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

namespace Vlaggen_van_Europese_landen
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

        private void Checkitout_Click(object sender, RoutedEventArgs e)
        {
            if (tbNederland.Text == "Nederland" && tbBelgië.Text == "België" && tbDuitsland.Text == "Duitsland" && tbFrankrijk.Text == "Frankrijk" && tbItalië.Text == "Italië" && tbOostenrijk.Text == "Oostenrijk" && tbVerenigdKoninkrijk.Text == "Verenigd Koninkrijk")
            {
                MessageBox.Show("Goed zo! Je hebt ze allemaal goed!");
            }
            else if (tbNederland.Text != "Nederland" && tbBelgië.Text == "België" && tbDuitsland.Text == "Duitsland" && tbFrankrijk.Text == "Frankrijk" && tbItalië.Text == "Italië" && tbOostenrijk.Text == "Oostenrijk" && tbVerenigdKoninkrijk.Text == "Verenigd Koninkrijk")
            {
                MessageBox.Show("6/7 goed, hmmm... zo te zien moet je de vlag van je eigen land nog leren???");
            }
            else if (tbNederland.Text == "Nederland" && tbBelgië.Text != "België" && tbDuitsland.Text == "Duitsland" && tbFrankrijk.Text == "Frankrijk" && tbItalië.Text == "Italië" && tbOostenrijk.Text == "Oostenrijk" && tbVerenigdKoninkrijk.Text == "Verenigd Koninkrijk")
            {
                MessageBox.Show("6/7 goed, hmmm... zo te zien heb je nog te weinig friet gegeten in je leven!");
            }
            else if (tbNederland.Text == "Nederland" && tbBelgië.Text == "België" && tbDuitsland.Text != "Duitsland" && tbFrankrijk.Text == "Frankrijk" && tbItalië.Text == "Italië" && tbOostenrijk.Text == "Oostenrijk" && tbVerenigdKoninkrijk.Text == "Verenigd Koninkrijk")
            {
                MessageBox.Show("6/7 goed, hmmm... zo te zien heb je nog te weinig curryworsten gegeten in je leven!");
            }
            else if(tbNederland.Text == "Nederland" && tbBelgië.Text == "België" && tbDuitsland.Text == "Duitsland" && tbFrankrijk.Text != "Frankrijk" && tbItalië.Text == "Italië" && tbOostenrijk.Text == "Oostenrijk" && tbVerenigdKoninkrijk.Text == "Verenigd Koninkrijk")
            {
                MessageBox.Show("6/7 goed, hmmm... zo te zien heb je nog te weinig croissants gegeten in je leven!");
            }
            else if (tbNederland.Text == "Nederland" && tbBelgië.Text == "België" && tbDuitsland.Text == "Duitsland" && tbFrankrijk.Text == "Frankrijk" && tbItalië.Text != "Italië" && tbOostenrijk.Text == "Oostenrijk" && tbVerenigdKoninkrijk.Text == "Verenigd Koninkrijk")
            {
                MessageBox.Show("6/7 goed, hmmm... zo te zien heb je nog te weinig pizza's gegeten in je leven!");
            }
            else if (tbNederland.Text == "Nederland" && tbBelgië.Text == "België" && tbDuitsland.Text == "Duitsland" && tbFrankrijk.Text == "Frankrijk" && tbItalië.Text == "Italië" && tbOostenrijk.Text != "Oostenrijk" && tbVerenigdKoninkrijk.Text == "Verenigd Koninkrijk")
            {
                MessageBox.Show("6/7 goed, hmmm... zo te zien heb je nog te weinig schnitzels gegeten in je leven!");
            }
            else if (tbNederland.Text == "Nederland" && tbBelgië.Text == "België" && tbDuitsland.Text == "Duitsland" && tbFrankrijk.Text == "Frankrijk" && tbItalië.Text == "Italië" && tbOostenrijk.Text == "Oostenrijk" && tbVerenigdKoninkrijk.Text != "Verenigd Koninkrijk")
            {
                MessageBox.Show("6/7 goed, hmmm... zo te zien heb je nog te weinig fish & chips gegeten in je leven!");
            }
            else
            {
                MessageBox.Show("Hmmm... je moet nog wat vlaggen gaan leren!");
            }
        }
    }
}
