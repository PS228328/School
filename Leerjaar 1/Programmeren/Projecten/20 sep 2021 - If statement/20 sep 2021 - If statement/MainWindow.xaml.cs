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

namespace _20_sep_2021___If_statement
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
            double Joris = Double.Parse(tbTemp.Text); //Hier maak je een variabele aan, in dit geval 'Joris'. Double.Parse zet dit om in getallen. TbTemp wordt hier dus een getal

            if (Joris < -273) //Als Joris een kleinere waarde heeft dan -273, dan verschijnt er deze melding
            {
                MessageBox.Show("You can't give a temperature lower than -273");
            }

            else if (Joris < 0) //Tussen -273 en 0 verschijnt er ice
            {
                MessageBox.Show("Ice");
            }

            else if (Joris < 100) //Anders, als Joris een waarde heeft tussen 0 en 100 dan verschijnt er water
            {
                MessageBox.Show("Water");
            }
            else //Helemaal anders, als Joris een hogere waarde heeft dan 100, dan komt er gas te staan
            {
                MessageBox.Show("Gas");
            }
            

        } //UITLEG: Een foto wordt ingevoegd op de volgende manier:
        //1. Foto selecteren bureaublad 2. In een nieuwe folder slepen (die maak je aan door rechtermuisknop 'add' 'new folder' 
        //3. Vervolgens doe je het volgende: /NewFolder/Foto.jpg en je foto staat er
    }
}
