using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfAppTake5_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        csTake5 _data = new csTake5();
        Random _myRandom = new Random();
        DispatcherTimer _waiter = new DispatcherTimer();
        bool _cardselected = false;
        bool _arrayfilled = false;
        int[] _selectedcards;
        int _counter = 0;

        public MainWindow()
        {
            InitializeComponent();
            bool checker = _data.NewGameOrResume();
            if (checker == true)
            {
                MessageBoxResult myResult = MessageBox.Show("Would you like to finish your unfinished game?", "Game in progress", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (myResult == MessageBoxResult.No)
                {
                    _data.UpdateProgress("1");
                }
            }
            _waiter.Interval = TimeSpan.FromSeconds(1);
            _waiter.Tick += _waiter_Tick;
        }

        private void btStartgame_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult myResult = MessageBox.Show("Would you like to create a game?", "Create game", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (myResult == MessageBoxResult.Yes)
            {
                GenerateNewGame();
                btStartgame.Visibility = Visibility.Hidden;
                aantalSpelers.Visibility = Visibility.Hidden;
            }
            else
            {
                return;
            }
        }

        private void GenerateNewGame()
        {
            int counter = 1;
            while (counter <= 104)
            {
                _data.GenerateCards(counter);
                counter++;
            }
            _data.UpdateProgress("0");

            cardsPlayer.Visibility = Visibility.Visible;
            int players = Int32.Parse(tbPlayers.Text);
            int counter1 = 1;
            int counter2 = 1;

            while (counter1 <= players)
            {
                _data.CreatePlayer(counter1);
                while (counter2 <= 10)
                {
                    DataTable kaarten = _data.haalAlleKaartenOp();
                    int card = _myRandom.Next(1, kaarten.Rows.Count);
                    string cardTake5 = kaarten.Rows[card]["Kaartnummer"].ToString();

                    _data.GiveCardToPlayer(counter2, counter1, cardTake5);
                    counter2++;
                }
                counter1++;
                counter2 = 1;
            }
            counter1 = 1;
            counter2 = 1;

            while (counter1 <= players)
            {
                DataTable speelgegevens = _data.haalSpeelgegevensOpVanEenSpeler(counter1);
                int[] kaarten = new int[10];

                while (counter2 <= 10)
                {
                    string kaart = speelgegevens.Rows[0]["Kaart" + counter2].ToString();
                    kaarten[counter2 - 1] = Convert.ToInt32(kaart);
                    counter2++;
                }
                counter2 = 0;
                Array.Sort(kaarten);

                while (counter2 < kaarten.Length)
                {
                    Button myButton = GenerateNewCard(kaarten[counter2]);
                    myButton.Click += MyButton_Click;
                    myButton.Content = kaarten[counter2].ToString();

                    if (counter1 == 1)
                    {
                        cardsPlayer.Children.Add(myButton);
                    }
                    else if (players == 2)
                    {
                        cardsCPU1.Children.Add(myButton);
                        textselBtplayer.Visibility = Visibility.Visible;
                        textselBtCPU1.Visibility = Visibility.Visible;
                    }
                    else if (players == 3)
                    {
                        textselBtplayer.Visibility = Visibility.Visible;
                        textselBtCPU2.Visibility = Visibility.Visible;
                        textselBtCPU2.Text = "CPU1";
                        textselBtCPU3.Visibility = Visibility.Visible;
                        textselBtCPU3.Text = "CPU2";

                        if (counter1 == 2)
                        {
                            cardsCPU2.Children.Add(myButton);
                        }
                        else
                        {
                            cardsCPU3.Children.Add(myButton);
                        }
                    }
                    else
                    {
                        textselBtplayer.Visibility = Visibility.Visible;
                        textselBtCPU1.Visibility = Visibility.Visible;
                        textselBtCPU1.Text = "CPU2";
                        textselBtCPU2.Visibility = Visibility.Visible;
                        textselBtCPU2.Text = "CPU1";
                        textselBtCPU3.Visibility = Visibility.Visible;
                        textselBtCPU3.Text = "CPU3";

                        if (counter1 == 2)
                        {
                            cardsCPU2.Children.Add(myButton);
                        }
                        else if (counter1 == 3)
                        {
                            cardsCPU1.Children.Add(myButton);
                        }
                        else
                        {
                            cardsCPU3.Children.Add(myButton);
                        }
                    }
                    counter2++;
                }

                counter1++;
                counter2 = 1;
            }

            int[] tafelkaarten = new int[4];
            counter2 = 0;

            DataTable kaarten2 = _data.haalAlleKaartenOp();

            while (counter2 < 4)
            {
                int card = _myRandom.Next(1, kaarten2.Rows.Count);
                tafelkaarten[counter2] = Convert.ToInt32(kaarten2.Rows[card]["Kaartnummer"]);
                counter2++;
            }
            Array.Sort(tafelkaarten);
            counter2 = 0;

            while (counter2 < 4)
            {
                _data.kaartenOpTafel(tafelkaarten[counter2], counter2 + 1);

                Button myButton = GenerateNewCard(tafelkaarten[counter2]);
                myButton.Content = tafelkaarten[counter2].ToString();

                if (counter2 == 0)
                {
                    tafel1.Children.Add(myButton);
                }
                else if (counter2 == 1)
                {
                    tafel2.Children.Add(myButton);
                }
                else if (counter2 == 2)
                {
                    tafel3.Children.Add(myButton);
                }
                else if (counter2 == 3)
                {
                    tafel4.Children.Add(myButton);
                }

                counter2++;
            }
        }

        private Button GenerateNewCard(int nr)
        {
            Button myButton = new Button();
            myButton.Width = 40;
            myButton.Height = 70;
            myButton.BorderBrush = Brushes.Black;
            myButton.BorderThickness = new Thickness(2, 2, 2, 2);
            myButton.Margin = new Thickness(5, 0, 5, 0);
            myButton.FontSize = 21;
            if (nr == 55)
            {
                myButton.Background = Brushes.Yellow;
            }
            else if (nr % 11 == 0)
            {
                myButton.Background = Brushes.Red;
            }
            else if (nr % 10 == 0)
            {
                myButton.Background = Brushes.Green;
            }
            else if (nr % 5 == 0)
            {
                myButton.Background = Brushes.Blue;
            }
            else
            {
                myButton.Background = Brushes.WhiteSmoke;
            }
            return myButton;
        }

        private void btaddplayer_Click(object sender, RoutedEventArgs e)
        {
            int x = Int32.Parse(tbPlayers.Text);
            if (x > 3)
            {
                MessageBox.Show("Maximumaantal bereikt");
                return;
            }
            x++;
            tbPlayers.Text = x.ToString();
        }

        private void btsubtrplayer_Click(object sender, RoutedEventArgs e)
        {
            int x = Int32.Parse(tbPlayers.Text);
            if (x < 3)
            {
                MessageBox.Show("Minimum aantal is 2");
                return;
            }
            x--;
            tbPlayers.Text = x.ToString();
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            if (_cardselected == false)
            {
                _cardselected = true;
                Button selectedBt = e.Source as Button;
                cardsPlayer.Children.Remove(selectedBt);
                selectedButton.Children.Add(selectedBt);

                DataTable spelerkaarten = _data.haalSpeelgegevensOpVanEenSpeler(1);

                int counter = 1;
                while (spelerkaarten.Rows[0]["Kaart" + counter].ToString() != selectedBt.Content.ToString())
                {
                    counter++;
                }
                _data.UpdateKaarten(1, counter);
                counter = 1;

                int kaartCPU = _myRandom.Next(1, cardsPlayer.Children.Count + 2);
                counter = 1;

                if (Int32.Parse(tbPlayers.Text) == 2)
                {
                    int cijfer = 0;
                    foreach (Button buttons in cardsCPU1.Children)
                    {
                        if (counter == kaartCPU)
                        {
                            cijfer = _data.UpdateKaarten(2, counter);
                        }
                        counter++;
                    }
                    ShowCPUcard(cijfer, 1);
                }
                else if (Int32.Parse(tbPlayers.Text) == 3)
                {
                    int cijfer = 0;
                    foreach (Button buttons in cardsCPU2.Children)
                    {
                        if (counter == kaartCPU)
                        {
                            cijfer = _data.UpdateKaarten(2, counter);
                        }
                        counter++;
                    }
                    ShowCPUcard(cijfer, 2);
                    cijfer = 0;
                    counter = 1;

                    foreach (Button buttons in cardsCPU3.Children)
                    {
                        if (counter == kaartCPU)
                        {
                            cijfer = _data.UpdateKaarten(3, counter);
                        }
                        counter++;
                    }
                    ShowCPUcard(cijfer, 3);
                }
                else
                {
                    int cijfer = 0;
                    foreach (Button buttons in cardsCPU2.Children)
                    {
                        if (counter == kaartCPU)
                        {
                            cijfer = _data.UpdateKaarten(2, counter);
                        }
                        counter++;
                    }
                    ShowCPUcard(cijfer, 2);
                    cijfer = 0;
                    counter = 1;

                    foreach (Button buttons in cardsCPU1.Children)
                    {
                        if (counter == kaartCPU)
                        {
                            cijfer = _data.UpdateKaarten(3, counter);
                        }
                        counter++;
                    }
                    ShowCPUcard(cijfer, 1);

                    counter = 1;
                    cijfer = 0;

                    foreach (Button buttons in cardsCPU3.Children)
                    {
                        if (counter == kaartCPU)
                        {
                            cijfer = _data.UpdateKaarten(4, counter);
                        }
                        counter++;
                    }
                    ShowCPUcard(cijfer, 3);
                }
                _waiter.Start();
            }
            else
            {
                MessageBox.Show("Je hebt al een kaart geselecteerd!");
                return;
            }
        }

        private void ShowCPUcard(int cijfer, int welkpanel)
        {
            if (welkpanel == 1)
            {
                foreach (Button buttons in cardsCPU1.Children)
                {
                    if (cijfer == Convert.ToInt32(buttons.Content.ToString()))
                    {
                        cardsCPU1.Children.Remove(buttons);
                        selectedButtonCPU1.Children.Add(buttons);
                        return;
                    }
                }
            }
            else if (welkpanel == 2)
            {
                foreach (Button buttons in cardsCPU2.Children)
                {
                    if (cijfer == Convert.ToInt32(buttons.Content.ToString()))
                    {
                        cardsCPU2.Children.Remove(buttons);
                        selectedButtonCPU2.Children.Add(buttons);
                        return;
                    }
                }
            }
            else
            {
                foreach (Button buttons in cardsCPU3.Children)
                {
                    if (cijfer == Convert.ToInt32(buttons.Content.ToString()))
                    {
                        cardsCPU3.Children.Remove(buttons);
                        selectedButtonCPU3.Children.Add(buttons);
                        return;
                    }
                }
            }
        }

        private void _waiter_Tick(object sender, EventArgs e)
        {
            int players = Int32.Parse(tbPlayers.Text);
            if (_arrayfilled == false)
            {
                _arrayfilled = true;
                _selectedcards = new int[players];
                foreach (Button mybutton in selectedButton.Children)
                {
                    _selectedcards[0] = Convert.ToInt32(mybutton.Content);
                }

                if (players == 2)
                {
                    foreach (Button mybutton in selectedButtonCPU1.Children)
                    {
                        _selectedcards[1] = Convert.ToInt32(mybutton.Content);
                    }
                }
                else if (players == 3)
                {
                    foreach (Button mybutton in selectedButtonCPU2.Children)
                    {
                        _selectedcards[1] = Convert.ToInt32(mybutton.Content);
                    }

                    foreach (Button mybutton in selectedButtonCPU3.Children)
                    {
                        _selectedcards[2] = Convert.ToInt32(mybutton.Content);
                    }
                }
                else
                {
                    foreach (Button mybutton in selectedButtonCPU2.Children)
                    {
                        _selectedcards[1] = Convert.ToInt32(mybutton.Content);
                    }

                    foreach (Button mybutton in selectedButtonCPU1.Children)
                    {
                        _selectedcards[2] = Convert.ToInt32(mybutton.Content);
                    }

                    foreach (Button mybutton in selectedButtonCPU3.Children)
                    {
                        _selectedcards[3] = Convert.ToInt32(mybutton.Content);
                    }
                }

                Array.Sort(_selectedcards);
            }          
            else
            {
                if (_counter < _selectedcards.Length)
                {
                    foreach (Button mybutton in selectedButton.Children)
                    {
                        if (Convert.ToInt32(mybutton.Content) == _selectedcards[_counter])
                        {
                            selectedButton.Children.Clear();
                            CheckWhichRow(mybutton);
                            return;
                        }
                    }

                    foreach (Button mybutton in selectedButtonCPU1.Children)
                    {
                        if (Convert.ToInt32(mybutton.Content) == _selectedcards[_counter])
                        {
                            selectedButtonCPU1.Children.Clear();
                            CheckWhichRow(mybutton);
                            return;
                        }
                    }

                    foreach (Button mybutton in selectedButtonCPU2.Children)
                    {
                        if (Convert.ToInt32(mybutton.Content) == _selectedcards[_counter])
                        {
                            selectedButtonCPU2.Children.Clear();
                            CheckWhichRow(mybutton);
                            return;
                        }
                    }

                    foreach (Button mybutton in selectedButtonCPU3.Children)
                    {
                        if (Convert.ToInt32(mybutton.Content) == _selectedcards[_counter])
                        {
                            selectedButtonCPU3.Children.Clear();
                            CheckWhichRow(mybutton);
                            return;
                        }
                    }
                    _counter++;
                }
                else
                {
                    _waiter.Stop();
                    _cardselected = false;
                    _arrayfilled = false;
                }
            }
        }

        private void CheckWhichRow(Button mybutton)
        {
            int number = Int32.Parse(mybutton.Content.ToString());
            int[] lastrownumbers = new int[4];
            int[] difference = new int[4];

            foreach (Button rowButton in tafel1.Children)
            {
                lastrownumbers[0] = Convert.ToInt32(rowButton.Content);
                difference[0] = number - lastrownumbers[0];
            }

            foreach (Button rowButton in tafel2.Children)
            {
                lastrownumbers[1] = Convert.ToInt32(rowButton.Content);
                difference[1] = number - lastrownumbers[1];
            }

            foreach (Button rowButton in tafel3.Children)
            {
                lastrownumbers[2] = Convert.ToInt32(rowButton.Content);
                difference[2] = number - lastrownumbers[2];
            }

            foreach (Button rowButton in tafel4.Children)
            {
                lastrownumbers[3] = Convert.ToInt32(rowButton.Content);
                difference[3] = number - lastrownumbers[3];
            }

            Array.Sort(difference);
            int counter = 0;

            while (difference[counter] < 0 && counter < difference.Length)
            {
                counter++;
            }

            int counter2 = 0;

            while (difference[counter] != number - lastrownumbers[counter2])
            {
                counter2++;
            }

            if (counter2 == 0)
            {
                tafel1.Children.Add(mybutton);
            }
            else if (counter2 == 1)
            {
                tafel2.Children.Add(mybutton);
            }
            else if (counter2 == 2)
            {
                tafel3.Children.Add(mybutton);
            }
            else if (counter2 == 3)
            {
                tafel4.Children.Add(mybutton);
            }
        }
    }
}
