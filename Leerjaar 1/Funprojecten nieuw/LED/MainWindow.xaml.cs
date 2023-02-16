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

namespace LED
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

        int counter = 0;

        private void Up_Click(object sender, RoutedEventArgs e)
        {
            pijltop.Background = Brushes.Red;
            pijl2.Background = Brushes.Red;
            pijl3.Background = Brushes.Red;
            pijl4.Background = Brushes.Red;
            pijl5.Background = Brushes.Red;
            pijl6.Background = Brushes.Red;
            pijl7.Background = Brushes.Red;
            pijlboven1.Background = Brushes.Red;
            pijlboven2.Background = Brushes.Red;
            pijlboven3.Background = Brushes.Red;
            pijlboven4.Background = Brushes.Red;
            pijlonder1.Background = Brushes.Black;
            pijlonder2.Background = Brushes.Black;
            pijlonder3.Background = Brushes.Black;
            pijlonder4.Background = Brushes.Black;

            if (counter == 0 || counter == 10 || counter == 20 || counter == 30 || counter == 40 || counter == 50 || counter == 60 || counter == 70 || counter == 80 || counter == 90)

            {
                BovenLinks.Background = Brushes.Black;
                Links2.Background = Brushes.Black;
                Links3.Background = Brushes.Black;
                Links4.Background = Brushes.Black;
                Links5.Background = Brushes.Black;
                Links6.Background = Brushes.Black;
                OnderLinks.Background = Brushes.Black;
                Onder2.Background = Brushes.Black;
                Onder3.Background = Brushes.Black;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Black;
                Boven2.Background = Brushes.Black;
                Midden2.Background = Brushes.Black;
                Midden3.Background = Brushes.Black;
            }

            else if (counter == 1 || counter == 11 || counter == 21 || counter == 31 || counter == 41 || counter == 51 || counter == 61 || counter == 71 || counter == 81 || counter == 91)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Black;
                Links3.Background = Brushes.Black;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Red;
                Links6.Background = Brushes.Red;
                OnderLinks.Background = Brushes.Red;
                Onder2.Background = Brushes.Red;
                Onder3.Background = Brushes.Red;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Black;
                Rechts5.Background = Brushes.Black;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Red;
                Midden3.Background = Brushes.Red;
            }

            else if (counter == 2 || counter == 12 || counter == 22 || counter == 32 || counter == 42 || counter == 52 || counter == 62 || counter == 72 || counter == 82 || counter == 92)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Black;
                Links3.Background = Brushes.Black;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Black;
                Links6.Background = Brushes.Black;
                OnderLinks.Background = Brushes.Red;
                Onder2.Background = Brushes.Red;
                Onder3.Background = Brushes.Red;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Red;
                Midden3.Background = Brushes.Red;
            }
            else if (counter == 3 || counter == 13 || counter == 23 || counter == 33 || counter == 43 || counter == 53 || counter == 63 || counter == 73 || counter == 83 || counter == 93)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Red;
                Links3.Background = Brushes.Red;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Black;
                Links6.Background = Brushes.Black;
                OnderLinks.Background = Brushes.Black;
                Onder2.Background = Brushes.Black;
                Onder3.Background = Brushes.Black;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Black;
                Boven2.Background = Brushes.Black;
                Midden2.Background = Brushes.Red;
                Midden3.Background = Brushes.Red;
            }
            else if (counter == 4 || counter == 14 || counter == 24 || counter == 34 || counter == 44 || counter == 54 || counter == 64 || counter == 74 || counter == 84 || counter == 94)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Red;
                Links3.Background = Brushes.Red;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Black;
                Links6.Background = Brushes.Black;
                OnderLinks.Background = Brushes.Red;
                Onder2.Background = Brushes.Red;
                Onder3.Background = Brushes.Red;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Black;
                Rechts2.Background = Brushes.Black;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Red;
                Midden3.Background = Brushes.Red;
            }
            else if (counter == 5 || counter == 15 || counter == 25 || counter == 35 || counter == 45 || counter == 55 || counter == 65 || counter == 75 || counter == 85 || counter == 95)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Red;
                Links3.Background = Brushes.Red;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Red;
                Links6.Background = Brushes.Red;
                OnderLinks.Background = Brushes.Red;
                Onder2.Background = Brushes.Red;
                Onder3.Background = Brushes.Red;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Black;
                Rechts2.Background = Brushes.Black;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Red;
                Midden3.Background = Brushes.Red;
            }
            else if (counter == 6 || counter == 16 || counter == 26 || counter == 36 || counter == 46 || counter == 56 || counter == 66 || counter == 76 || counter == 86 || counter == 96) 
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Red;
                Links3.Background = Brushes.Black;
                Links4.Background = Brushes.Black;
                Links5.Background = Brushes.Black;
                Links6.Background = Brushes.Black;
                OnderLinks.Background = Brushes.Black;
                Onder2.Background = Brushes.Black;
                Onder3.Background = Brushes.Black;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Black;
                Midden3.Background = Brushes.Black;
            }
            else if (counter == 7 || counter == 17 || counter == 27 || counter == 37 || counter == 47 || counter == 57 || counter == 67 || counter == 77 || counter == 87 || counter == 97)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Red;
                Links3.Background = Brushes.Red;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Red;
                Links6.Background = Brushes.Red;
                OnderLinks.Background = Brushes.Red;
                Onder2.Background = Brushes.Red;
                Onder3.Background = Brushes.Red;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Red;
                Midden3.Background = Brushes.Red;
            }
            else if (counter == 8 || counter == 18 || counter == 28 || counter == 38 || counter == 48 || counter == 58 || counter == 68 || counter == 78 || counter == 88 || counter == 98)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Red;
                Links3.Background = Brushes.Red;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Black;
                Links6.Background = Brushes.Black;
                OnderLinks.Background = Brushes.Red;
                Onder2.Background = Brushes.Red;
                Onder3.Background = Brushes.Red;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Red;
                Midden3.Background = Brushes.Red;
            }
            else if (counter == 9)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Red;
                Links3.Background = Brushes.Red;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Red;
                Links6.Background = Brushes.Red;
                OnderLinks.Background = Brushes.Red;
                Onder2.Background = Brushes.Red;
                Onder3.Background = Brushes.Red;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Black;
                Midden3.Background = Brushes.Black;

                BovenRechtstiental.Background = Brushes.Red;
                Rechts2tiental.Background = Brushes.Red;
                Rechts3tiental.Background = Brushes.Red;
                Rechts4tiental.Background = Brushes.Red;
                Rechts5tiental.Background = Brushes.Red;
                Rechts6tiental.Background = Brushes.Red;
                OnderRechtstiental.Background = Brushes.Red;
            }
            else if (counter == 19)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Red;
                Links3.Background = Brushes.Red;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Red;
                Links6.Background = Brushes.Red;
                OnderLinks.Background = Brushes.Red;
                Onder2.Background = Brushes.Red;
                Onder3.Background = Brushes.Red;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Black;
                Midden3.Background = Brushes.Black;

                BovenLinkstiental.Background = Brushes.Red;
                Links2tiental.Background = Brushes.Black;
                Links3tiental.Background = Brushes.Black;
                Links4tiental.Background = Brushes.Red;
                Links5tiental.Background = Brushes.Red;
                Links6tiental.Background = Brushes.Red;
                OnderLinkstiental.Background = Brushes.Red;
                Onder2tiental.Background = Brushes.Red;
                Onder3tiental.Background = Brushes.Red;
                OnderRechtstiental.Background = Brushes.Red;
                Rechts6tiental.Background = Brushes.Black;
                Rechts5tiental.Background = Brushes.Black;
                Rechts4tiental.Background = Brushes.Red;
                Rechts3tiental.Background = Brushes.Red;
                Rechts2tiental.Background = Brushes.Red;
                BovenRechtstiental.Background = Brushes.Red;
                Boven2tiental.Background = Brushes.Red;
                Boven3tiental.Background = Brushes.Red;
                Midden2tiental.Background = Brushes.Red;
                Midden3tiental.Background = Brushes.Red;
            }
            else if (counter == 29)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Red;
                Links3.Background = Brushes.Red;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Red;
                Links6.Background = Brushes.Red;
                OnderLinks.Background = Brushes.Red;
                Onder2.Background = Brushes.Red;
                Onder3.Background = Brushes.Red;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Black;
                Midden3.Background = Brushes.Black;

                BovenLinkstiental.Background = Brushes.Red;
                Links2tiental.Background = Brushes.Black;
                Links3tiental.Background = Brushes.Black;
                Links4tiental.Background = Brushes.Red;
                Links5tiental.Background = Brushes.Black;
                Links6tiental.Background = Brushes.Black;
                OnderLinkstiental.Background = Brushes.Red;
                Onder2tiental.Background = Brushes.Red;
                Onder3tiental.Background = Brushes.Red;
                OnderRechtstiental.Background = Brushes.Red;
                Rechts6tiental.Background = Brushes.Red;
                Rechts5tiental.Background = Brushes.Red;
                Rechts4tiental.Background = Brushes.Red;
                Rechts3tiental.Background = Brushes.Red;
                Rechts2tiental.Background = Brushes.Red;
                BovenRechtstiental.Background = Brushes.Red;
                Boven2tiental.Background = Brushes.Red;
                Boven3tiental.Background = Brushes.Red;
                Midden2tiental.Background = Brushes.Red;
                Midden3tiental.Background = Brushes.Red;
            }
            else if (counter == 39)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Red;
                Links3.Background = Brushes.Red;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Red;
                Links6.Background = Brushes.Red;
                OnderLinks.Background = Brushes.Red;
                Onder2.Background = Brushes.Red;
                Onder3.Background = Brushes.Red;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Black;
                Midden3.Background = Brushes.Black;

                BovenLinkstiental.Background = Brushes.Red;
                Links2tiental.Background = Brushes.Red;
                Links3tiental.Background = Brushes.Red;
                Links4tiental.Background = Brushes.Red;
                Links5tiental.Background = Brushes.Black;
                Links6tiental.Background = Brushes.Black;
                OnderLinkstiental.Background = Brushes.Black;
                Onder2tiental.Background = Brushes.Black;
                Onder3tiental.Background = Brushes.Black;
                OnderRechtstiental.Background = Brushes.Red;
                Rechts6tiental.Background = Brushes.Red;
                Rechts5tiental.Background = Brushes.Red;
                Rechts4tiental.Background = Brushes.Red;
                Rechts3tiental.Background = Brushes.Red;
                Rechts2tiental.Background = Brushes.Red;
                BovenRechtstiental.Background = Brushes.Red;
                Boven2tiental.Background = Brushes.Black;
                Boven3tiental.Background = Brushes.Black;
                Midden2tiental.Background = Brushes.Red;
                Midden3tiental.Background = Brushes.Red;
            }
            else if (counter == 49)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Red;
                Links3.Background = Brushes.Red;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Red;
                Links6.Background = Brushes.Red;
                OnderLinks.Background = Brushes.Red;
                Onder2.Background = Brushes.Red;
                Onder3.Background = Brushes.Red;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Black;
                Midden3.Background = Brushes.Black;

                BovenLinkstiental.Background = Brushes.Red;
                Links2tiental.Background = Brushes.Red;
                Links3tiental.Background = Brushes.Red;
                Links4tiental.Background = Brushes.Red;
                Links5tiental.Background = Brushes.Black;
                Links6tiental.Background = Brushes.Black;
                OnderLinkstiental.Background = Brushes.Red;
                Onder2tiental.Background = Brushes.Red;
                Onder3tiental.Background = Brushes.Red;
                OnderRechtstiental.Background = Brushes.Red;
                Rechts6tiental.Background = Brushes.Red;
                Rechts5tiental.Background = Brushes.Red;
                Rechts4tiental.Background = Brushes.Red;
                Rechts3tiental.Background = Brushes.Black;
                Rechts2tiental.Background = Brushes.Black;
                BovenRechtstiental.Background = Brushes.Red;
                Boven2tiental.Background = Brushes.Red;
                Boven3tiental.Background = Brushes.Red;
                Midden2tiental.Background = Brushes.Red;
                Midden3tiental.Background = Brushes.Red;
            }
            else if (counter == 59)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Red;
                Links3.Background = Brushes.Red;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Red;
                Links6.Background = Brushes.Red;
                OnderLinks.Background = Brushes.Red;
                Onder2.Background = Brushes.Red;
                Onder3.Background = Brushes.Red;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Black;
                Midden3.Background = Brushes.Black;

                BovenLinkstiental.Background = Brushes.Red;
                Links2tiental.Background = Brushes.Red;
                Links3tiental.Background = Brushes.Red;
                Links4tiental.Background = Brushes.Red;
                Links5tiental.Background = Brushes.Red;
                Links6tiental.Background = Brushes.Red;
                OnderLinkstiental.Background = Brushes.Red;
                Onder2tiental.Background = Brushes.Red;
                Onder3tiental.Background = Brushes.Red;
                OnderRechtstiental.Background = Brushes.Red;
                Rechts6tiental.Background = Brushes.Red;
                Rechts5tiental.Background = Brushes.Red;
                Rechts4tiental.Background = Brushes.Red;
                Rechts3tiental.Background = Brushes.Black;
                Rechts2tiental.Background = Brushes.Black;
                BovenRechtstiental.Background = Brushes.Red;
                Boven2tiental.Background = Brushes.Red;
                Boven3tiental.Background = Brushes.Red;
                Midden2tiental.Background = Brushes.Red;
                Midden3tiental.Background = Brushes.Red;
            }
            else if (counter == 69)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Red;
                Links3.Background = Brushes.Red;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Red;
                Links6.Background = Brushes.Red;
                OnderLinks.Background = Brushes.Red;
                Onder2.Background = Brushes.Red;
                Onder3.Background = Brushes.Red;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Black;
                Midden3.Background = Brushes.Black;

                BovenLinkstiental.Background = Brushes.Red;
                Links2tiental.Background = Brushes.Red;
                Links3tiental.Background = Brushes.Black;
                Links4tiental.Background = Brushes.Black;
                Links5tiental.Background = Brushes.Black;
                Links6tiental.Background = Brushes.Black;
                OnderLinkstiental.Background = Brushes.Black;
                Onder2tiental.Background = Brushes.Black;
                Onder3tiental.Background = Brushes.Black;
                OnderRechtstiental.Background = Brushes.Red;
                Rechts6tiental.Background = Brushes.Red;
                Rechts5tiental.Background = Brushes.Red;
                Rechts4tiental.Background = Brushes.Red;
                Rechts3tiental.Background = Brushes.Red;
                Rechts2tiental.Background = Brushes.Red;
                BovenRechtstiental.Background = Brushes.Red;
                Boven2tiental.Background = Brushes.Red;
                Boven3tiental.Background = Brushes.Red;
                Midden2tiental.Background = Brushes.Black;
                Midden3tiental.Background = Brushes.Black;
            }
            else if (counter == 79)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Red;
                Links3.Background = Brushes.Red;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Red;
                Links6.Background = Brushes.Red;
                OnderLinks.Background = Brushes.Red;
                Onder2.Background = Brushes.Red;
                Onder3.Background = Brushes.Red;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Black;
                Midden3.Background = Brushes.Black;

                BovenLinkstiental.Background = Brushes.Red;
                Links2tiental.Background = Brushes.Red;
                Links3tiental.Background = Brushes.Red;
                Links4tiental.Background = Brushes.Red;
                Links5tiental.Background = Brushes.Red;
                Links6tiental.Background = Brushes.Red;
                OnderLinkstiental.Background = Brushes.Red;
                Onder2tiental.Background = Brushes.Red;
                Onder3tiental.Background = Brushes.Red;
                OnderRechtstiental.Background = Brushes.Red;
                Rechts6tiental.Background = Brushes.Red;
                Rechts5tiental.Background = Brushes.Red;
                Rechts4tiental.Background = Brushes.Red;
                Rechts3tiental.Background = Brushes.Red;
                Rechts2tiental.Background = Brushes.Red;
                BovenRechtstiental.Background = Brushes.Red;
                Boven2tiental.Background = Brushes.Red;
                Boven3tiental.Background = Brushes.Red;
                Midden2tiental.Background = Brushes.Red;
                Midden3tiental.Background = Brushes.Red;
            }
            else if (counter == 89)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Red;
                Links3.Background = Brushes.Red;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Red;
                Links6.Background = Brushes.Red;
                OnderLinks.Background = Brushes.Red;
                Onder2.Background = Brushes.Red;
                Onder3.Background = Brushes.Red;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Black;
                Midden3.Background = Brushes.Black;

                BovenLinkstiental.Background = Brushes.Red;
                Links2tiental.Background = Brushes.Red;
                Links3tiental.Background = Brushes.Red;
                Links4tiental.Background = Brushes.Red;
                Links5tiental.Background = Brushes.Black;
                Links6tiental.Background = Brushes.Black;
                OnderLinkstiental.Background = Brushes.Red;
                Onder2tiental.Background = Brushes.Red;
                Onder3tiental.Background = Brushes.Red;
                OnderRechtstiental.Background = Brushes.Red;
                Rechts6tiental.Background = Brushes.Red;
                Rechts5tiental.Background = Brushes.Red;
                Rechts4tiental.Background = Brushes.Red;
                Rechts3tiental.Background = Brushes.Red;
                Rechts2tiental.Background = Brushes.Red;
                BovenRechtstiental.Background = Brushes.Red;
                Boven2tiental.Background = Brushes.Red;
                Boven3tiental.Background = Brushes.Red;
                Midden2tiental.Background = Brushes.Red;
                Midden3tiental.Background = Brushes.Red;
            }
            else if (counter == 99)
            {
                MessageBox.Show("Het getal kan niet hoger zijn dan 99");
                return;
            }
                counter++;

        }

        private void Down_Click(object sender, RoutedEventArgs e)
        {
            pijltop.Background = Brushes.Red;
            pijl2.Background = Brushes.Red;
            pijl3.Background = Brushes.Red;
            pijl4.Background = Brushes.Red;
            pijl5.Background = Brushes.Red;
            pijl6.Background = Brushes.Red;
            pijl7.Background = Brushes.Red;
            pijlboven1.Background = Brushes.Black;
            pijlboven2.Background = Brushes.Black;
            pijlboven3.Background = Brushes.Black;
            pijlboven4.Background = Brushes.Black;
            pijlonder1.Background = Brushes.Red;
            pijlonder2.Background = Brushes.Red;
            pijlonder3.Background = Brushes.Red;
            pijlonder4.Background = Brushes.Red;

            if (counter == 99 || counter == 89 || counter == 79 || counter == 69 || counter == 59 || counter == 49 || counter == 39 || counter == 29 || counter == 19 || counter == 9)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Red;
                Links3.Background = Brushes.Red;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Red;
                Links6.Background = Brushes.Red;
                OnderLinks.Background = Brushes.Red;
                Onder2.Background = Brushes.Red;
                Onder3.Background = Brushes.Red;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Red;
                Midden3.Background = Brushes.Red;
            }
            else if (counter == 98 || counter == 88 || counter == 78 || counter == 68 || counter == 58 || counter == 48 || counter == 38 || counter == 28 || counter == 18 || counter == 8)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Red;
                Links3.Background = Brushes.Black;
                Links4.Background = Brushes.Black;
                Links5.Background = Brushes.Black;
                Links6.Background = Brushes.Black;
                OnderLinks.Background = Brushes.Black;
                Onder2.Background = Brushes.Black;
                Onder3.Background = Brushes.Black;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Black;
                Midden3.Background = Brushes.Black;
            }
            else if (counter == 97 || counter == 87 || counter == 77 || counter == 67 || counter == 57 || counter == 47 || counter == 37 || counter == 27 || counter == 17 || counter == 7)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Red;
                Links3.Background = Brushes.Red;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Red;
                Links6.Background = Brushes.Red;
                OnderLinks.Background = Brushes.Red;
                Onder2.Background = Brushes.Red;
                Onder3.Background = Brushes.Red;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Black;
                Rechts2.Background = Brushes.Black;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Red;
                Midden3.Background = Brushes.Red;
            }
            else if (counter == 96 || counter == 86 || counter == 76 || counter == 66 || counter == 56 || counter == 46 || counter == 36 || counter == 26 || counter == 16 || counter == 6)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Red;
                Links3.Background = Brushes.Red;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Black;
                Links6.Background = Brushes.Black;
                OnderLinks.Background = Brushes.Red;
                Onder2.Background = Brushes.Red;
                Onder3.Background = Brushes.Red;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Black;
                Rechts2.Background = Brushes.Black;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Red;
                Midden3.Background = Brushes.Red;
            }
            else if (counter == 95 || counter == 85 || counter == 75 || counter == 65 || counter == 55 || counter == 45 || counter == 35 || counter == 25 || counter == 15 || counter == 5)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Red;
                Links3.Background = Brushes.Red;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Black;
                Links6.Background = Brushes.Black;
                OnderLinks.Background = Brushes.Black;
                Onder2.Background = Brushes.Black;
                Onder3.Background = Brushes.Black;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Black;
                Boven2.Background = Brushes.Black;
                Midden2.Background = Brushes.Red;
                Midden3.Background = Brushes.Red;
            }
            else if (counter == 94 || counter == 84 || counter == 74 || counter == 64 || counter == 54 || counter == 44 || counter == 34 || counter == 24 || counter == 14 || counter == 4)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Black;
                Links3.Background = Brushes.Black;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Black;
                Links6.Background = Brushes.Black;
                OnderLinks.Background = Brushes.Red;
                Onder2.Background = Brushes.Red;
                Onder3.Background = Brushes.Red;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Red;
                Midden3.Background = Brushes.Red;
            }
            else if (counter == 93 || counter == 83 || counter == 73 || counter == 63 || counter == 53 || counter == 43 || counter == 33 || counter == 23 || counter == 13 || counter == 3)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Black;
                Links3.Background = Brushes.Black;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Red;
                Links6.Background = Brushes.Red;
                OnderLinks.Background = Brushes.Red;
                Onder2.Background = Brushes.Red;
                Onder3.Background = Brushes.Red;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Black;
                Rechts5.Background = Brushes.Black;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Red;
                Midden3.Background = Brushes.Red;
            }
            else if (counter == 92 || counter == 82 || counter == 72 || counter == 62 || counter == 52 || counter == 42 || counter == 32 || counter == 22 || counter == 12 || counter == 2)
            {
                BovenLinks.Background = Brushes.Black;
                Links2.Background = Brushes.Black;
                Links3.Background = Brushes.Black;
                Links4.Background = Brushes.Black;
                Links5.Background = Brushes.Black;
                Links6.Background = Brushes.Black;
                OnderLinks.Background = Brushes.Black;
                Onder2.Background = Brushes.Black;
                Onder3.Background = Brushes.Black;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Black;
                Boven2.Background = Brushes.Black;
                Midden2.Background = Brushes.Black;
                Midden3.Background = Brushes.Black;
            }
            else if (counter == 91 || counter == 81 || counter == 71 || counter == 61 || counter == 51 || counter == 41 || counter == 31 || counter == 21 || counter == 11 || counter == 1)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Red;
                Links3.Background = Brushes.Red;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Red;
                Links6.Background = Brushes.Red;
                OnderLinks.Background = Brushes.Red;
                Onder2.Background = Brushes.Red;
                Onder3.Background = Brushes.Red;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Black;
                Midden3.Background = Brushes.Black;
            }
            else if (counter == 10)
            {
                BovenRechtstiental.Background = Brushes.Black;
                Rechts2tiental.Background = Brushes.Black;
                Rechts3tiental.Background = Brushes.Black;
                Rechts4tiental.Background = Brushes.Black;
                Rechts5tiental.Background = Brushes.Black;
                Rechts6tiental.Background = Brushes.Black;
                OnderRechtstiental.Background = Brushes.Black;

                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Red;
                Links3.Background = Brushes.Red;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Black;
                Links6.Background = Brushes.Black;
                OnderLinks.Background = Brushes.Red;
                Onder2.Background = Brushes.Red;
                Onder3.Background = Brushes.Red;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Red;
                Midden3.Background = Brushes.Red;
            }
            else if (counter == 20)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Red;
                Links3.Background = Brushes.Red;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Black;
                Links6.Background = Brushes.Black;
                OnderLinks.Background = Brushes.Red;
                Onder2.Background = Brushes.Red;
                Onder3.Background = Brushes.Red;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Red;
                Midden3.Background = Brushes.Red;

                BovenRechtstiental.Background = Brushes.Red;
                Rechts2tiental.Background = Brushes.Red;
                Rechts3tiental.Background = Brushes.Red;
                Rechts4tiental.Background = Brushes.Red;
                Rechts5tiental.Background = Brushes.Red;
                Rechts6tiental.Background = Brushes.Red;
                OnderRechtstiental.Background = Brushes.Red;
                Onder3tiental.Background = Brushes.Black;
                Onder2tiental.Background = Brushes.Black;
                OnderLinkstiental.Background = Brushes.Black;
                Links6tiental.Background = Brushes.Black;
                Links5tiental.Background = Brushes.Black;
                Links4tiental.Background = Brushes.Black;
                Links3tiental.Background = Brushes.Black;
                Links2tiental.Background = Brushes.Black;
                BovenLinkstiental.Background = Brushes.Black;
                Boven2tiental.Background = Brushes.Black;
                Boven3tiental.Background = Brushes.Black;
                Midden2tiental.Background = Brushes.Black;
                Midden3tiental.Background = Brushes.Black;
            }
            else if (counter == 30)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Red;
                Links3.Background = Brushes.Red;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Black;
                Links6.Background = Brushes.Black;
                OnderLinks.Background = Brushes.Red;
                Onder2.Background = Brushes.Red;
                Onder3.Background = Brushes.Red;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Red;
                Midden3.Background = Brushes.Red;

                BovenRechtstiental.Background = Brushes.Red;
                Rechts2tiental.Background = Brushes.Red;
                Rechts3tiental.Background = Brushes.Red;
                Rechts4tiental.Background = Brushes.Red;
                Rechts5tiental.Background = Brushes.Black;
                Rechts6tiental.Background = Brushes.Black;
                OnderRechtstiental.Background = Brushes.Red;
                Onder3tiental.Background = Brushes.Red;
                Onder2tiental.Background = Brushes.Red;
                OnderLinkstiental.Background = Brushes.Red;
                Links6tiental.Background = Brushes.Red;
                Links5tiental.Background = Brushes.Red;
                Links4tiental.Background = Brushes.Red;
                Links3tiental.Background = Brushes.Black;
                Links2tiental.Background = Brushes.Black;
                BovenLinkstiental.Background = Brushes.Red;
                Boven2tiental.Background = Brushes.Red;
                Boven3tiental.Background = Brushes.Red;
                Midden2tiental.Background = Brushes.Red;
                Midden3tiental.Background = Brushes.Red;
            }
            else if (counter == 40)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Red;
                Links3.Background = Brushes.Red;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Black;
                Links6.Background = Brushes.Black;
                OnderLinks.Background = Brushes.Red;
                Onder2.Background = Brushes.Red;
                Onder3.Background = Brushes.Red;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Red;
                Midden3.Background = Brushes.Red;

                BovenRechtstiental.Background = Brushes.Red;
                Rechts2tiental.Background = Brushes.Red;
                Rechts3tiental.Background = Brushes.Red;
                Rechts4tiental.Background = Brushes.Red;
                Rechts5tiental.Background = Brushes.Red;
                Rechts6tiental.Background = Brushes.Red;
                OnderRechtstiental.Background = Brushes.Red;
                Onder3tiental.Background = Brushes.Red;
                Onder2tiental.Background = Brushes.Red;
                OnderLinkstiental.Background = Brushes.Red;
                Links6tiental.Background = Brushes.Black;
                Links5tiental.Background = Brushes.Black;
                Links4tiental.Background = Brushes.Red;
                Links3tiental.Background = Brushes.Black;
                Links2tiental.Background = Brushes.Black;
                BovenLinkstiental.Background = Brushes.Red;
                Boven2tiental.Background = Brushes.Red;
                Boven3tiental.Background = Brushes.Red;
                Midden2tiental.Background = Brushes.Red;
                Midden3tiental.Background = Brushes.Red;
            }
            else if (counter == 50)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Red;
                Links3.Background = Brushes.Red;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Black;
                Links6.Background = Brushes.Black;
                OnderLinks.Background = Brushes.Red;
                Onder2.Background = Brushes.Red;
                Onder3.Background = Brushes.Red;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Red;
                Midden3.Background = Brushes.Red;

                BovenRechtstiental.Background = Brushes.Red;
                Rechts2tiental.Background = Brushes.Red;
                Rechts3tiental.Background = Brushes.Red;
                Rechts4tiental.Background = Brushes.Red;
                Rechts5tiental.Background = Brushes.Red;
                Rechts6tiental.Background = Brushes.Red;
                OnderRechtstiental.Background = Brushes.Red;
                Onder3tiental.Background = Brushes.Black;
                Onder2tiental.Background = Brushes.Black;
                OnderLinkstiental.Background = Brushes.Black;
                Links6tiental.Background = Brushes.Black;
                Links5tiental.Background = Brushes.Black;
                Links4tiental.Background = Brushes.Red;
                Links3tiental.Background = Brushes.Red;
                Links2tiental.Background = Brushes.Red;
                BovenLinkstiental.Background = Brushes.Red;
                Boven2tiental.Background = Brushes.Black;
                Boven3tiental.Background = Brushes.Black;
                Midden2tiental.Background = Brushes.Red;
                Midden3tiental.Background = Brushes.Red;
            }
            else if (counter == 60)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Red;
                Links3.Background = Brushes.Red;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Black;
                Links6.Background = Brushes.Black;
                OnderLinks.Background = Brushes.Red;
                Onder2.Background = Brushes.Red;
                Onder3.Background = Brushes.Red;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Red;
                Midden3.Background = Brushes.Red;

                BovenRechtstiental.Background = Brushes.Red;
                Rechts2tiental.Background = Brushes.Black;
                Rechts3tiental.Background = Brushes.Black;
                Rechts4tiental.Background = Brushes.Red;
                Rechts5tiental.Background = Brushes.Red;
                Rechts6tiental.Background = Brushes.Red;
                OnderRechtstiental.Background = Brushes.Red;
                Onder3tiental.Background = Brushes.Red;
                Onder2tiental.Background = Brushes.Red;
                OnderLinkstiental.Background = Brushes.Red;
                Links6tiental.Background = Brushes.Black;
                Links5tiental.Background = Brushes.Black;
                Links4tiental.Background = Brushes.Red;
                Links3tiental.Background = Brushes.Red;
                Links2tiental.Background = Brushes.Red;
                BovenLinkstiental.Background = Brushes.Red;
                Boven2tiental.Background = Brushes.Red;
                Boven3tiental.Background = Brushes.Red;
                Midden2tiental.Background = Brushes.Red;
                Midden3tiental.Background = Brushes.Red;
            }
            else if (counter == 70)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Red;
                Links3.Background = Brushes.Red;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Black;
                Links6.Background = Brushes.Black;
                OnderLinks.Background = Brushes.Red;
                Onder2.Background = Brushes.Red;
                Onder3.Background = Brushes.Red;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Red;
                Midden3.Background = Brushes.Red;

                BovenRechtstiental.Background = Brushes.Red;
                Rechts2tiental.Background = Brushes.Black;
                Rechts3tiental.Background = Brushes.Black;
                Rechts4tiental.Background = Brushes.Red;
                Rechts5tiental.Background = Brushes.Red;
                Rechts6tiental.Background = Brushes.Red;
                OnderRechtstiental.Background = Brushes.Red;
                Onder3tiental.Background = Brushes.Red;
                Onder2tiental.Background = Brushes.Red;
                OnderLinkstiental.Background = Brushes.Red;
                Links6tiental.Background = Brushes.Red;
                Links5tiental.Background = Brushes.Red;
                Links4tiental.Background = Brushes.Red;
                Links3tiental.Background = Brushes.Red;
                Links2tiental.Background = Brushes.Red;
                BovenLinkstiental.Background = Brushes.Red;
                Boven2tiental.Background = Brushes.Red;
                Boven3tiental.Background = Brushes.Red;
                Midden2tiental.Background = Brushes.Red;
                Midden3tiental.Background = Brushes.Red;
            }
            else if (counter == 80)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Red;
                Links3.Background = Brushes.Red;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Black;
                Links6.Background = Brushes.Black;
                OnderLinks.Background = Brushes.Red;
                Onder2.Background = Brushes.Red;
                Onder3.Background = Brushes.Red;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Red;
                Midden3.Background = Brushes.Red;

                BovenRechtstiental.Background = Brushes.Red;
                Rechts2tiental.Background = Brushes.Red;
                Rechts3tiental.Background = Brushes.Red;
                Rechts4tiental.Background = Brushes.Red;
                Rechts5tiental.Background = Brushes.Red;
                Rechts6tiental.Background = Brushes.Red;
                OnderRechtstiental.Background = Brushes.Red;
                Onder3tiental.Background = Brushes.Black;
                Onder2tiental.Background = Brushes.Black;
                OnderLinkstiental.Background = Brushes.Black;
                Links6tiental.Background = Brushes.Black;
                Links5tiental.Background = Brushes.Black;
                Links4tiental.Background = Brushes.Black;
                Links3tiental.Background = Brushes.Black;
                Links2tiental.Background = Brushes.Red;
                BovenLinkstiental.Background = Brushes.Red;
                Boven2tiental.Background = Brushes.Red;
                Boven3tiental.Background = Brushes.Red;
                Midden2tiental.Background = Brushes.Black;
                Midden3tiental.Background = Brushes.Black;
            }
            else if (counter == 90)
            {
                BovenLinks.Background = Brushes.Red;
                Links2.Background = Brushes.Red;
                Links3.Background = Brushes.Red;
                Links4.Background = Brushes.Red;
                Links5.Background = Brushes.Black;
                Links6.Background = Brushes.Black;
                OnderLinks.Background = Brushes.Red;
                Onder2.Background = Brushes.Red;
                Onder3.Background = Brushes.Red;
                OnderRechts.Background = Brushes.Red;
                Rechts6.Background = Brushes.Red;
                Rechts5.Background = Brushes.Red;
                Rechts4.Background = Brushes.Red;
                Rechts3.Background = Brushes.Red;
                Rechts2.Background = Brushes.Red;
                BovenRechts.Background = Brushes.Red;
                Boven3.Background = Brushes.Red;
                Boven2.Background = Brushes.Red;
                Midden2.Background = Brushes.Red;
                Midden3.Background = Brushes.Red;

                BovenRechtstiental.Background = Brushes.Red;
                Rechts2tiental.Background = Brushes.Red;
                Rechts3tiental.Background = Brushes.Red;
                Rechts4tiental.Background = Brushes.Red;
                Rechts5tiental.Background = Brushes.Red;
                Rechts6tiental.Background = Brushes.Red;
                OnderRechtstiental.Background = Brushes.Red;
                Onder3tiental.Background = Brushes.Red;
                Onder2tiental.Background = Brushes.Red;
                OnderLinkstiental.Background = Brushes.Red;
                Links6tiental.Background = Brushes.Red;
                Links5tiental.Background = Brushes.Red;
                Links4tiental.Background = Brushes.Red;
                Links3tiental.Background = Brushes.Red;
                Links2tiental.Background = Brushes.Red;
                BovenLinkstiental.Background = Brushes.Red;
                Boven2tiental.Background = Brushes.Red;
                Boven3tiental.Background = Brushes.Red;
                Midden2tiental.Background = Brushes.Red;
                Midden3tiental.Background = Brushes.Red;
            }


            else if (counter == 0)
            {
                MessageBox.Show("Het getal kan niet lager zijn dan 0");
                return;
            }

            counter--;
        }
    }
}
