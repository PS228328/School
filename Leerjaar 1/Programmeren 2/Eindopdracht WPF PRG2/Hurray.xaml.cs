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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Eindopdracht_WPF_PRG2
{
    /// <summary>
    /// Interaction logic for Hurray.xaml
    /// </summary>
    public partial class Hurray : Window
    {
        int aftelklok = 10;
        DispatcherTimer countdown = new DispatcherTimer();
        public Hurray(int klok, bool winorlose)
        {
            InitializeComponent();
            if (winorlose == false)
            {
                return;
            }
            win.Text = "Je hebt het spel gewonnen in " + klok + " seconde";
            countdown.Start();
            countdown.Interval = TimeSpan.FromSeconds(1);
            countdown.Tick += Countdown_Tick;
        }

        private void Countdown_Tick(object sender, EventArgs e)
        {
            aftelklok--;
            countdowner.Text = aftelklok.ToString();

            if (aftelklok == 0)
            {
                this.Close();
                countdown.Stop();
                aftelklok = 10;
                MessageBox.Show("Klik op start om nogmaals te spelen!");
            }
        }
    }
}
