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

namespace Opdracht_van_Patrick_PRG_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int _aantalknoppen;
        int _counter = 0;
        int _colorselector = 1;
        int tempcounter = 0;

        DispatcherTimer _timer = new DispatcherTimer();
        Random myRandom = new Random();

        TextBox _tbGetal = new TextBox();
        Button _btGenerate = new Button(); 
        Button _btMix = new Button();
        Button _btSort = new Button();
        WrapPanel _myPanel = new WrapPanel();

        Button[] myArrayButtons;

        public MainWindow()
        {
            InitializeComponent();
            _timer.Interval = new TimeSpan(0, 0, 0, 0, 500);
            _timer.Tick += _timer_Tick;
        }

        private void btGenerate_Click(object sender, RoutedEventArgs e)
        {
            _myPanel.Children.Clear(); //Maak het panel eerst leeg, zodat er opnieuw een hoeveelheid buttons kan worden toegevoegd
            int counter = 0;
            int selectcolor = 1;
            try
            {
                _aantalknoppen = Int32.Parse(_tbGetal.Text); //Kijk of we kunnen rekenen met het ingevulde getal, anders vangen we dat af.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vul aub een geldig getal in!" + "\n" + ex.Message);
                return;
            }

            if (_aantalknoppen < 5)
            {
                MessageBox.Show("Vul aub een hoger getal in dan 4");
                return;
            }
            else
            {
                try
                {
                    myGrid.Children.Add(_btSort);
                    myGrid.Children.Add(_btMix);
                }
                catch (Exception)
                {
                    //Nothing
                }
            }

            myArrayButtons = new Button[_aantalknoppen]; //Genereer een array van buttons (lengte is het ingevulde getal)

            while (counter < _aantalknoppen)
            {
                //We voegen elke knop uit de array toe aan ons wrappanel (zolang counter een kleinere waarde heeft dan de lengte van de array)
                myArrayButtons[counter] = new Button();
                myArrayButtons[counter].Width = 50;
                myArrayButtons[counter].Height = 30;

                //De selectcolor geeft aan wat voor kleur de button heeft, zo verdelen we elke kleur eerlijk

                if (selectcolor == 1)
                {
                    selectcolor++;
                    myArrayButtons[counter].Background = Brushes.Red;
                }
                else if(selectcolor == 2)
                {
                    selectcolor++;
                    myArrayButtons[counter].Background = Brushes.Yellow;
                }
                else if (selectcolor == 3)
                {
                    selectcolor++;
                    myArrayButtons[counter].Background = Brushes.Blue;
                }
                else 
                {
                    selectcolor = 1;
                    myArrayButtons[counter].Background = Brushes.Green;
                }
                _myPanel.Children.Add(myArrayButtons[counter]);
                counter++;
            }
            _aantalknoppen = 0;
        }

        private void btSort_Click(object sender, RoutedEventArgs e)
        {
            //We starten de timer, zodat elke seconde een knop verwisseld word (zie volgende method)
            _timer.Start();
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            //controleer of de huidige de kleur heeft die we aan het sorteren zijn. Zo ja joepie, zo nee dan gaan we verder
            //We zoeken de eerstvolgende met de juiste kleur (method), je krijgt de index terug en hier kunnen we mee verder
            //We ruilen de niet juiste kleur om met de juiste
            //Nu kunnen we eentje verder gaan met sorteren

            //Zolang _counter een kleinere waarde heeft dan onze array moeten we sorteren. (Anders zouden we foutmeldingen krijgen omdat bijvoorbeeld het 55e element uit een array niet bestaat)
            if (_counter < myArrayButtons.Length)
            { 
                //Colorselector hogen we op zodra we klaar zijn met een kleur sorteren, op deze manier komt elke kleur aan de beurt
                if (_colorselector == 1 && myArrayButtons[_counter].Background != Brushes.Red)
                {
                    tempcounter = checknextred();
                    //De colorselector is 1 zolang we de rode sorteren, alleen zodra een knop NIET rood is moeten we iets doen (anders staat deze button al goed)
                }
                else if (_colorselector == 2 && myArrayButtons[_counter].Background != Brushes.Yellow)
                {
                    tempcounter = checknextyellow();
                }
                else if (_colorselector == 3 && myArrayButtons[_counter].Background != Brushes.Blue)
                {
                    tempcounter = checknextblue();
                }
                else if (_colorselector == 4)
                {
                    //Als de laatste kleur aan de beurt is, zijn die altijd al gesorteerd (test maar uit!), daardoor kunnen we er direct mee ophouden...
                    MessageBox.Show("Done!");
                    _colorselector = 1;
                    _counter = 0;
                    _timer.Stop();
                    return;
                }
                else
                {
                    _counter++;
                    return;
                }

                if (tempcounter >= myArrayButtons.Length)
                {
                    //We controleren of de tempcounter (index van de methods) niet hoger is dan de arraylengte, anders krijgen we foutmeldingen.
                    //Hierdoor weten we automatisch dat we klaar zijn met een bepaalde kleur, we hogen colorselector op zodat we de volgende seconde met de volgende kleur verder kunnen
                    _colorselector++;
                    tempcounter = 0;
                    return;
                }

                //We wisselen de twee knoppen hieronder om

                Button item = myArrayButtons[_counter];
                Button item2 = myArrayButtons[tempcounter];
                myArrayButtons[_counter] = item2;
                myArrayButtons[tempcounter] = item;
                _myPanel.Children.Clear();

                //Tot slot zetten we alles weer terug in onze wrappanel

                int counter = 0;
                while (counter < myArrayButtons.Length)
                {
                    _myPanel.Children.Add(myArrayButtons[counter]);
                    counter++;
                }
                _counter++;
            }
        }

        private int checknextred()
        {
            //Hier zoeken we een button die WEL rood is, we krijgen een index waarmee we de juiste button kunnen omwisselen.
            int counter2 = 0;
            counter2 = _counter;

            while (counter2 < myArrayButtons.Length && myArrayButtons[counter2].Background != Brushes.Red)
            {
                counter2++;
            }
            return counter2;
        }

        private int checknextyellow()
        {
            //Hier doen we hetzelfde, maar dan voor de gele knoppen
            int counter2 = 0;
            counter2 = _counter;

            while (counter2 < myArrayButtons.Length && myArrayButtons[counter2].Background != Brushes.Yellow)
            {
                counter2++;
            }
            return counter2;
        }

        private int checknextblue()
        {
            //Hier doen we hetzelfde, maar dan voor de blauwe knoppen
            int counter2 = 0;
            counter2 = _counter;

            while (counter2 < myArrayButtons.Length && myArrayButtons[counter2].Background != Brushes.Blue)
            {
                counter2++;
            }
            return counter2;
        }

        private void btMix_Click(object sender, RoutedEventArgs e)
        {
            int counter = 0;
            while(counter < myArrayButtons.Length)
            {
                //We kiezen een random plek uit de array, en vervolgens husselen we de knoppen om.
                int nieuweplek = myRandom.Next(1, myArrayButtons.Length);

                var oud = myArrayButtons[counter];
                var nieuw = myArrayButtons[nieuweplek];

                myArrayButtons[counter] = nieuw;
                myArrayButtons[nieuweplek] = oud;

                _myPanel.Children.Clear();

                int counter2 = 0;
                while(counter2 < myArrayButtons.Length)
                {
                    _myPanel.Children.Add(myArrayButtons[counter2]);
                    counter2++;
                }

                counter++;
                //Dit blijven we doen tot we alle buttons gehad hebben.
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _myPanel.Background = Brushes.Purple;
            _myPanel.Height = 650;
            _myPanel.VerticalAlignment = VerticalAlignment.Top;

            _btGenerate.Width = 120;
            _btGenerate.Height = 40;
            _btGenerate.HorizontalAlignment = HorizontalAlignment.Center;
            _btGenerate.VerticalAlignment = VerticalAlignment.Bottom;
            _btGenerate.Margin = new Thickness(0, 0, 150, 70);
            _btGenerate.Background = Brushes.Black;
            _btGenerate.Foreground = Brushes.White;
            _btGenerate.Content = "Genereer";
            _btGenerate.FontSize = 20;
            _btGenerate.Click += btGenerate_Click;

            _btSort.Width = 120;
            _btSort.Height = 40;
            _btSort.HorizontalAlignment = HorizontalAlignment.Center;
            _btSort.VerticalAlignment = VerticalAlignment.Bottom;
            _btSort.Margin = new Thickness(150, 0, 0, 20);
            _btSort.Background = Brushes.Black;
            _btSort.Foreground = Brushes.White;
            _btSort.Content = "Sorteer";
            _btSort.FontSize = 20;
            _btSort.Click += btSort_Click;

            _btMix.Width = 120;
            _btMix.Height = 40;
            _btMix.HorizontalAlignment = HorizontalAlignment.Center;
            _btMix.VerticalAlignment = VerticalAlignment.Bottom;
            _btMix.Margin = new Thickness(150, 0, 0, 70);
            _btMix.Background = Brushes.Black;
            _btMix.Foreground = Brushes.White;
            _btMix.Content = "Mix";
            _btMix.FontSize = 20;
            _btMix.Click += btMix_Click;


            _tbGetal.Width = 120;
            _tbGetal.Height = 40;
            _tbGetal.HorizontalAlignment = HorizontalAlignment.Center;
            _tbGetal.VerticalAlignment = VerticalAlignment.Bottom;
            _tbGetal.Margin = new Thickness(0, 0, 150, 20);
            _tbGetal.FontSize = 20;
            _tbGetal.FontWeight = FontWeights.Bold;
            _tbGetal.TextAlignment = TextAlignment.Center;
            _tbGetal.Name = "tbGetal";

            myGrid.Children.Add(_btGenerate);
            myGrid.Children.Add(_tbGetal);
            myGrid.Children.Add(_myPanel);
        }
    }
}

