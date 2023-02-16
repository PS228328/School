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
        DispatcherTimer timer = new DispatcherTimer();
        //De lijst waarin de woorden komen te staan        
        List<string> lstWords = new List<string>();
        //Een random waarmee we random woorden uit de lijst kunnen kiezen
        Random rRandom = new Random();
        int myInt;
        int counter;
        //de eindwaarde van de raket       
        double dEndpoint = 0;

        public WordRocket(string sNamePlayer)
        {
            InitializeComponent();
            lblName.Content = sNamePlayer;

            timer.Interval = new TimeSpan(0, 0, 0, 0, 50);
            timer.Tick += Timer_Tick;
            //bewegen stopt bij breedte scherm - zwarte rectangle - lengte raket
            dEndpoint = this.Width - rEndGame.Width - lblWord.Width;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //verschuif de Margin van het label van de raket
            lblWord.Margin = new Thickness(lblWord.Margin.Left + 10, lblWord.Margin.Top, 0, 0);
            if (lblWord.Width + lblWord.Margin.Left > myGrid.ActualWidth - 60 )
            {
                timer.Stop();
                MessageBox.Show("Te laat!");
                lblWord.Content = "";
            }

            //stop met bewegen al de linkerkant van de raket het eindpunt raakt
            
        }
        private void txtWordToCheck_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (lblWord != null && txtWordToCheck != null)
            {
                if (txtWordToCheck.Text.Length == 0)
                {
                    return;
                }
                //Is het label gelijk aan het tekstvak en houdt geen rekening met hoofdletters
                //punt erbij
                //het volgende woord   
            }
            try
            {
                if (txtWordToCheck.Text == lstWords[myInt])
                {
                    lstWords.RemoveAt(myInt);
                    txtWordToCheck.Text = "";
                    lblWord.Margin = new Thickness(0, 0, 0, 0);
                    counter++;
                    lblNrCorrect.Content = counter.ToString();

                    myInt = rRandom.Next(0, lstWords.Count);

                    try
                    {
                        lblWord.Content = lstWords[myInt];
                    }
                    catch (Exception)
                    {
                        lblWord.Content = "";
                        timer.Stop();
                        MessageBox.Show("Je hebt ze allemaal gevonden!");
                        lblWord.Content = "HOERA!!";
                        return;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Het spel is afgelopen!");
                return;
            }

        }
        private void ReadWords()
        {
            lstWords.Clear();
            lstWords.AddRange(File.ReadAllLines("Resources\\woorden.txt"));
            myInt = rRandom.Next(0, lstWords.Count);
            lblWord.Content = lstWords[myInt];
        }
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            btnStart.Visibility = Visibility.Hidden;
            timer.Start();
            ReadWords();
        }
    }
}
