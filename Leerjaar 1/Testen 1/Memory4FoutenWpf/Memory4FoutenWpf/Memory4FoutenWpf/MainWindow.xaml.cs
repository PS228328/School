using Memory4FoutenWpf.Model;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace Memory4FoutenWpf
{
    public partial class MainWindow : Window
    {
        private Memory memory = null;
        private StackPanel[] panels = new StackPanel[4];
        private DateTime begintijd;
        DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();

            panels[0] = rij1;
            panels[1] = rij2;
            panels[2] = rij3;
            panels[3] = rij4;

            for (int i = 0; i < 4; i++)
            {
                panels[i].Orientation = Orientation.Horizontal;
            }
            memory = new Memory(Kaart_Click, this.panels);
            memory.NieuwSpel();
            ToonScore();

            timer.Interval = TimeSpan.FromSeconds(0.1);
            timer.Tick += timer_Tick;
            timer.Start();
            begintijd = DateTime.Now;
        }

        /** Start een nieuw Spel, verberg alle kaarten en zet de score op 0 en de verlopen tijd op 0 sekonden  **/
        private void NieuwSpel_Click(object sender, RoutedEventArgs e)
        {
            memory.NieuwSpel();
            ToonScore();
            begintijd = DateTime.Now;
        }

        /** Controleer of de zojuist geopende kaarten gelijk zijn, dan blijven deze open
         *  Anders gaan open kaarten 
         * **/

        private void Kaart_Click(object sender, MouseButtonEventArgs e)
        {
            Image pb = sender as Image;
            int x = (int)pb.Tag;
            memory.Beurt(x);
            ToonScore();
        }
        private void ToonScore()
        {
            score.Content = memory.Score.ToString() + " / 12";
        }
        void timer_Tick(object sender, EventArgs e)
        {
            sekonden.Content = (DateTime.Now - begintijd).Minutes + " minuten " + (DateTime.Now - begintijd).Seconds + " seconden";
            if (memory.Score == 12)
            {
                sekonden.Content = "Hoera! Geraden in: " + (DateTime.Now - begintijd).Minutes + " minuten " + (DateTime.Now - begintijd) + " seconden";
                timer.Stop();
            }

        }

    }
}
