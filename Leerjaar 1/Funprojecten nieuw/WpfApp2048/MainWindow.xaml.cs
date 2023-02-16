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

namespace WpfApp2048
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _myTimer.Tick += _myTimer_Tick;
            _myTimer.Start();
            PlaceBlock();
            PlaceBlock();
        }

        private void PlaceBlock()
        {
            //In deze method word een blok geplaatst, dit kan een blok zijn wat tijdens het spel gegenereerd word, maar ook op het begin worden er 2 generereerd

            bool decider = false;
            int place = 0;

            //We zetten het blok op een willekeurige plek. Als er al een blok staat (oftewel, deze bool staat op true), dan plaatsen we het blok niet. Net zolang tot we een plekje vinden dat nog vrij is
            while (decider == false)
            {
                place = GenerateInt();
                if (_filledBlocks[place] == false)
                {
                    _filledBlocks[place] = true;
                    decider = true;
                }
            }

            TextBlock block = GenerateBlock();

            //Op basis van het nummer plaatsen we het blok in een stackpanel
            switch (place)
            {
                case 0:
                    blockA1.Children.Add(block);
                    break;
                case 1:
                    blockA2.Children.Add(block);
                    break;
                case 2:
                    blockA3.Children.Add(block);
                    break;
                case 3:
                    blockA4.Children.Add(block);
                    break;
                case 4:
                    blockB1.Children.Add(block);
                    break;
                case 5:
                    blockB2.Children.Add(block);
                    break;
                case 6:
                    blockB3.Children.Add(block);
                    break;
                case 7:
                    blockB4.Children.Add(block);
                    break;
                case 8:
                    blockC1.Children.Add(block);
                    break;
                case 9:
                    blockC2.Children.Add(block);
                    break;
                case 10:
                    blockC3.Children.Add(block);
                    break;
                case 11:
                    blockC4.Children.Add(block);
                    break;
                case 12:
                    blockD1.Children.Add(block);
                    break;
                case 13:
                    blockD2.Children.Add(block);
                    break;
                case 14:
                    blockD3.Children.Add(block);
                    break;
                case 15:
                    blockD4.Children.Add(block);
                    break;
                default:
                    break;
            }
        }

        private void _myTimer_Tick(object sender, EventArgs e)
        {
            //We kijken iedere 10 milliseconden of dat er een pijl ingedrukt is, zo ja moeten er blokjes verplaatst worden

            if (Keyboard.IsKeyDown(Key.Up))
            {
                //Wanneer de pijl omhoog is ingedrukt, gaan we de blokjes naar omhoog verplaatsen
                MoveBlocksUp();
            }
            else if (Keyboard.IsKeyDown(Key.Down))
            {
                //Wanneer de pijl omlaag is ingedrukt, gaan we de blokjes naar omlaag verplaatsen
                MoveBlocksDown();
            }
            else if (Keyboard.IsKeyDown(Key.Left))
            {
                //Wanneer de pijl naar links is ingedrukt, gaan we de blokjes naar links verplaatsen
                MoveBlocksLeft();
            }
            else if (Keyboard.IsKeyDown(Key.Right))
            {
                //Wanneer de pijl naar rechts is ingedrukt, gaan we de blokjes naar rechts verplaatsen
                MoveBlocksRight();
            }
            else
            {
                return;
            }
        }

        //Hieronder hebben we een array waarmee we controleren op welke plekken in het raster blokjes staan
        //true betekent er staat een blokje in dit vak, false betekent er staat niks in. Omdat op het begin er nog helemaal niks staat, staan ze nu nog allemaal op false

        bool[] _filledBlocks = {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false};
        Random _myRandom = new Random();
        DispatcherTimer _myTimer = new DispatcherTimer();

        private TextBlock GenerateBlock()
        {
            //We genereren een textblock
            TextBlock block = new TextBlock();
            block.Width = 140;
            block.Height = 140;
            block.HorizontalAlignment = HorizontalAlignment.Center;
            block.VerticalAlignment = VerticalAlignment.Center;
            block.Margin = new Thickness(0, 4, 0, 0);
            block.Background = Brushes.White;
            block.Foreground = Brushes.Black;
            block.TextAlignment = TextAlignment.Center;
            block.Text = "2";
            block.FontSize = 100;
            block.FontWeight = FontWeights.Bold;
            return block;
        }

        private int GenerateInt()
        {
            //We genereren een integer en geven deze terug. Op deze manier word het blok telkens ergens anders geplaatst
            int placeofblock = _myRandom.Next(0, 16);
            return placeofblock;
        }

        private void MoveBlocksUp()
        {
            int counter = 0;
            int line = 12;
            int newplace = 0;
            string arrow = "Up";

            while (counter < 4)
            {
                while (line > -1)
                {
                    if (_filledBlocks[counter + line] == true && line > 3)
                    {
                        newplace = checknextblock(counter, line, arrow);
                        RefreshScreen(line + counter, newplace);
                    }
                    line = line - 4;
                }
                line = 12;
                counter++;
            }
        }

        private void MoveBlocksDown()
        {
            int counter = 0;
            while (counter < _filledBlocks.Length)
            {
                if (counter < 12 && _filledBlocks[counter] == true)
                {
                    _filledBlocks[counter] = false;
                    _filledBlocks[counter + 4] = true;

                    int oudeplek = counter;
                    int nieuweplek = counter + 4;

                    RefreshScreen(oudeplek, nieuweplek);
                }
                counter++;
            }
        }

        private void MoveBlocksLeft()
        {
            int counter = 0;
            while (counter < _filledBlocks.Length)
            {
                if ((counter != 0 && counter != 4 && counter != 8 && counter != 12) && _filledBlocks[counter] == true)
                {
                    _filledBlocks[counter] = false;
                    _filledBlocks[counter - 1] = true;

                    int oudeplek = counter;
                    int nieuweplek = counter - 1;

                    RefreshScreen(oudeplek, nieuweplek);
                }
                counter++;
            }
        }

        private void MoveBlocksRight()
        {
            int counter = 0;
            while (counter < _filledBlocks.Length)
            {
                if ((counter != 3 && counter != 7 && counter != 11 && counter != 15) && _filledBlocks[counter] == true)
                {
                    _filledBlocks[counter] = false;
                    _filledBlocks[counter + 1] = true;

                    int oudeplek = counter;
                    int nieuweplek = counter + 1;

                    RefreshScreen(oudeplek, nieuweplek);
                }
                counter++;
            }
        }

        private int checknextblock(int counter, int line, string arrow)
        {
            //Hier zoeken we een button die WEL rood is, we krijgen een index waarmee we de juiste button kunnen omwisselen.
            int index = line + counter;

            if (arrow == "Up")
            {
                line = line - 4;
                if(_filledBlocks[counter + line] == true || line < 0)
                {
                    return index;
                }
                else
                {
                    _filledBlocks[index] = false;
                    _filledBlocks[index - 4] = true;
                    return line + counter;
                }
            }
            else
            {
                return index;
            }
        }

        private void RefreshScreen(int oudeplek, int nieuweplek)
        {
            switch (oudeplek)
            {
                case 0:
                    blockA1.Children.Clear();
                    break;
                case 1:
                    blockA2.Children.Clear();
                    break;
                case 2:
                    blockA3.Children.Clear();
                    break;
                case 3:
                    blockA4.Children.Clear();
                    break;
                case 4:
                    blockB1.Children.Clear();
                    break;
                case 5:
                    blockB2.Children.Clear();
                    break;
                case 6:
                    blockB3.Children.Clear();
                    break;
                case 7:
                    blockB4.Children.Clear();
                    break;
                case 8:
                    blockC1.Children.Clear();
                    break;
                case 9:
                    blockC2.Children.Clear();
                    break;
                case 10:
                    blockC3.Children.Clear();
                    break;
                case 11:
                    blockC4.Children.Clear();
                    break;
                case 12:
                    blockD1.Children.Clear();
                    break;
                case 13:
                    blockD2.Children.Clear();
                    break;
                case 14:
                    blockD3.Children.Clear();
                    break;
                case 15:
                    blockD4.Children.Clear();
                    break;
                default:
                    break;
            }

            TextBlock block = GenerateBlock();

            switch (nieuweplek)
            {
                case 0:
                    blockA1.Children.Add(block);
                    break;
                case 1:
                    blockA2.Children.Add(block);
                    break;
                case 2:
                    blockA3.Children.Add(block);
                    break;
                case 3:
                    blockA4.Children.Add(block);
                    break;
                case 4:
                    blockB1.Children.Add(block);
                    break;
                case 5:
                    blockB2.Children.Add(block);
                    break;
                case 6:
                    blockB3.Children.Add(block);
                    break;
                case 7:
                    blockB4.Children.Add(block);
                    break;
                case 8:
                    blockC1.Children.Add(block);
                    break;
                case 9:
                    blockC2.Children.Add(block);
                    break;
                case 10:
                    blockC3.Children.Add(block);
                    break;
                case 11:
                    blockC4.Children.Add(block);
                    break;
                case 12:
                    blockD1.Children.Add(block);
                    break;
                case 13:
                    blockD2.Children.Add(block);
                    break;
                case 14:
                    blockD3.Children.Add(block);
                    break;
                case 15:
                    blockD4.Children.Add(block);
                    break;
                default:
                    break;
            }
        }
    }
}
