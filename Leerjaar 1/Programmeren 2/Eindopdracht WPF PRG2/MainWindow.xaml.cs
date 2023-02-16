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
using System.Windows.Threading;

namespace Eindopdracht_WPF_PRG2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer moveTimer = new DispatcherTimer();
        DispatcherTimer counter = new DispatcherTimer();
        DispatcherTimer smallscreen = new DispatcherTimer();
        DispatcherTimer fastcounter = new DispatcherTimer();
        bool startgame = true;
        bool winorlose;
        Random marginPicker = new Random();
        int width;
        int height;
        int klok;
        int snelheid = 1000;
        int partyWidth = 1536;
        int partyHeight = 864;

        public MainWindow()
        {
            InitializeComponent();
            counter.Interval = TimeSpan.FromMilliseconds(1000);
            counter.Tick += Counter_Tick;
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            if (startgame == true)
            {
                ComboBoxItem SelectedCharacter = (ComboBoxItem)cbCharacters.SelectedItem;
                if (SelectedCharacter == null)
                {
                    MessageBox.Show("Selecteer aub een character!");
                    return;
                }
                startgame = false;
                moveTimer.Start();
                counter.Start();
                startButton.Content = "Stop";
            }
            else
            {
                startgame = true;
                moveTimer.Stop();
                counter.Stop();
                startButton.Content = "Start!";
            }
            moveTimer.Interval = TimeSpan.FromMilliseconds(snelheid);
            moveTimer.Tick += MoveTimer_Tick;
            goParty.Visibility = Visibility.Visible;
        }

        private void Counter_Tick(object sender, EventArgs e)
        { 
            klok = Int32.Parse(timer.Text);
            klok++;
            timer.Text = klok.ToString();
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            moveTimer.Interval = TimeSpan.FromMilliseconds(snelheid);

            width = ((int)gameGrid.ActualWidth);
            height = ((int)gameGrid.ActualHeight);

            width = width - 40;
            height = height - 60;

            ptRoadrunner.Margin = new Thickness(marginPicker.Next(0, width), marginPicker.Next(0, height), 0, 0);
            ptRock.Margin = new Thickness(marginPicker.Next(0, width), marginPicker.Next(0, height), 0, 0);
            ptSpeedy.Margin = new Thickness(marginPicker.Next(0, width), marginPicker.Next(0, height), 0, 0);
        }

        private void goFaster_Click(object sender, RoutedEventArgs e)
        {
            if (snelheid <= 100)
            {
                MessageBox.Show("De foto beweegt al op zijn snelst");
                return;
            }
            snelheid = snelheid - 100;
        }

        private void goSlower_Click(object sender, RoutedEventArgs e)
        {
            if (snelheid > 2000)
            {
                MessageBox.Show("De foto beweegt al op zijn langzaamst");
                return;
            }
            snelheid = snelheid + 100;
        }

        private void ptRoadrunner_MouseEnter(object sender, MouseEventArgs e)
        {
            if (ptRoadrunner.Visibility == Visibility.Hidden)
            {
                return;
            }
            if (ptRoadrunner.Margin == new Thickness(0,0,0,0))
            {
                return;
            }
            else
            {
                returnGame();
            }
        }

        private void ptSpeedy_MouseEnter(object sender, MouseEventArgs e)
        {
            if (ptSpeedy.Visibility == Visibility.Hidden)
            {
                return;
            }
            if (ptSpeedy.Margin == new Thickness(0, 0, 0, 0))
            {
                return;
            }
            else
            {
                returnGame();
            }
        }

        private void ptRock_MouseEnter(object sender, MouseEventArgs e)
        {
            if (ptRock.Visibility == Visibility.Hidden)
            {
                return;
            }
            if (ptRock.Margin == new Thickness(0, 0, 0, 0))
            {
                return;
            }
            else
            {
                returnGame();
            }
        }

        private void returnGame()
        {
            moveTimer.Stop();
            counter.Stop();
            smallscreen.Stop();
            fastcounter.Stop();
            cbCharacters.Text = "";
            SetImagesInvisible();
            ptRoadrunner.Margin = new Thickness(0, 0, 0, 0);
            ptRock.Margin = new Thickness(0, 0, 0, 0);
            ptSpeedy.Margin = new Thickness(0, 0, 0, 0);
            startButton.Content = "Start!";
            if (klok != 0)
            {
                winorlose = true;
                Hurray newscreen = new Hurray(klok, winorlose);
                newscreen.ShowDialog(); 
            }
            startgame = true;
            timer.Text = "0";
            timer.Background = Brushes.Transparent;
            timer.Foreground = Brushes.Black;
            klok = 0;
            goParty.Visibility = Visibility.Hidden;
            goSlower.Visibility = Visibility.Visible;
            goFaster.Visibility = Visibility.Visible;
            winorlose = false;
        }

        private void SetImagesInvisible()
        {
            ptRoadrunner.Visibility = Visibility.Hidden;
            ptRock.Visibility = Visibility.Hidden;
            ptSpeedy.Visibility = Visibility.Hidden;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SetImagesInvisible();
            ComboBoxItem SelectedCharacter = (ComboBoxItem)cbCharacters.SelectedItem;
            if (SelectedCharacter == null)
            {
                return;
            }
            string selectCharacter = SelectedCharacter.Content.ToString();

            if (selectCharacter == "Roadrunner")
            {
                ptRoadrunner.Visibility = Visibility.Visible;
            }
            else if (selectCharacter == "Speedy")
            {
                ptSpeedy.Visibility = Visibility.Visible;
            }
            else if (selectCharacter == "Rock")
            {
                ptRock.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("Selecteer aub een character!!");
            }
        }

        private void goParty_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Party = ON!");
            goSlower.Visibility = Visibility.Hidden;
            goFaster.Visibility = Visibility.Hidden;
            goParty.Visibility = Visibility.Hidden;
            timer.Text = "30";
            klok = 30;
            smallscreen.Start();
            smallscreen.Interval = TimeSpan.FromSeconds(1);
            fastcounter.Start();
            fastcounter.Interval = TimeSpan.FromMilliseconds(300);
            fastcounter.Tick += Fastcounter_Tick;
            counter.Stop();
            smallscreen.Tick += Smallscreen_Tick;
        }

        private void Fastcounter_Tick(object sender, EventArgs e)
        {
            ptRoadrunner.Margin = new Thickness(marginPicker.Next(0, width), marginPicker.Next(0, height), 0, 0);
            ptRock.Margin = new Thickness(marginPicker.Next(0, width), marginPicker.Next(0, height), 0, 0);
            ptSpeedy.Margin = new Thickness(marginPicker.Next(0, width), marginPicker.Next(0, height), 0, 0);

            partyWidth = partyWidth - 10;
            partyHeight = partyHeight - 5;

            this.Width = partyWidth;
            this.Height = partyHeight;
            this.Margin = new Thickness(0, 0, 0, 0);
            this.WindowStartupLocation = WindowStartupLocation.Manual;
            this.Left = 0;
            this.Top = 0;
        }

        private void Smallscreen_Tick(object sender, EventArgs e)
        {
            klok = Int32.Parse(timer.Text);
            klok--;
            timer.Text = klok.ToString();
            Random color = new Random();
            timer.Background = new SolidColorBrush(
                Color.FromRgb((byte)color.Next(0, 256),
                              (byte)color.Next(0, 256),
                              (byte)color.Next(0, 256)));

            timer.Foreground = new SolidColorBrush(
                Color.FromRgb((byte)color.Next(0, 256),
                              (byte)color.Next(0, 256),
                              (byte)color.Next(0, 256)));

            if (klok == 0)
            {
                MessageBox.Show("Helaas, je hebt het niet gehaald...");
                returnGame();
                return;
            }
        }
    }
}
