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

namespace Yahtzee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random _myRandom1 = new Random();
        int MyInt1;
        int MyInt2;
        int MyInt3;
        int MyInt4;
        int MyInt5;
        int aantalworpen;
        int playernumbercounter;
        int numberofPlayers;
        int aantalspelers;
        int counter1;
        int counterP11;
        int counterP12;
        int counterP13;
        int counterP14;
        int counterP15;
        int counterP16;
        int counter2;
        int counterP21;
        int counterP22;
        int counterP23;
        int counterP24;
        int counterP25;
        int counterP26;
        int counter3;
        int counterP31;
        int counterP32;
        int counterP33;
        int counterP34;
        int counterP35;
        int counterP36;
        int counter4;
        int counterP41;
        int counterP42;
        int counterP43;
        int counterP44;
        int counterP45;
        int counterP46;
        int counter5;
        int counterP51;
        int counterP52;
        int counterP53;
        int counterP54;
        int counterP55;
        int counterP56;
        int counter6;
        int counterP61;
        int counterP62;
        int counterP63;
        int counterP64;
        int counterP65;
        int counterP66;

        int helft2P1; //telt het aantal punten in part 2
        int helft2P2;
        int helft2P3;
        int helft2P4;
        int helft2P5;
        int helft2P6;

        int counterchangeP1;
        int counterchangeP2;
        int counterchangeP3;
        int counterchangeP4;
        int counterchangeP5;
        int counterchangeP6;

        int topscoreP1;
        int topscoreP2;
        int topscoreP3;
        int topscoreP4;
        int topscoreP5;
        int topscoreP6;

        int grotestraatP1;
        int grotestraatP2;
        int grotestraatP3;
        int grotestraatP4;
        int grotestraatP5;
        int grotestraatP6;

        int kleinestraatP1;
        int kleinestraatP2;
        int kleinestraatP3;
        int kleinestraatP4;
        int kleinestraatP5;
        int kleinestraatP6;

        int fullhouseP1;
        int fullhouseP2;
        int fullhouseP3;
        int fullhouseP4;
        int fullhouseP5;
        int fullhouseP6;

        int bonusP1 = 0;
        int bonusP2 = 0;
        int bonusP3 = 0;
        int bonusP4 = 0;
        int bonusP5 = 0;
        int bonusP6 = 0;

        int grandtotalP1Part1;
        int grandtotalP1Part2;
        int totalgrandP1;
        int grandtotalP2Part1;
        int grandtotalP2Part2;
        int totalgrandP2;
        int grandtotalP3Part1;
        int grandtotalP3Part2;
        int totalgrandP3;
        int grandtotalP4Part1;
        int grandtotalP4Part2;
        int totalgrandP4;
        int grandtotalP5Part1;
        int grandtotalP5Part2;
        int totalgrandP5;
        int grandtotalP6Part1;
        int grandtotalP6Part2;
        int totalgrandP6;

        string speler11 = "";
        string speler12 = "";
        string speler13 = "";
        string speler14 = "";
        string speler15 = "";
        string speler16 = "";
        string speler21 = "";
        string speler22 = "";
        string speler23 = "";
        string speler24 = "";
        string speler25 = "";
        string speler26 = "";
        string speler31 = "";
        string speler32 = "";
        string speler33 = "";
        string speler34 = "";
        string speler35 = "";
        string speler36 = "";
        string speler41 = "";
        string speler42 = "";
        string speler43 = "";
        string speler44 = "";
        string speler45 = "";
        string speler46 = "";
        string speler51 = "";
        string speler52 = "";
        string speler53 = "";
        string speler54 = "";
        string speler55 = "";
        string speler56 = "";
        string speler61 = "";
        string speler62 = "";
        string speler63 = "";
        string speler64 = "";
        string speler65 = "";
        string speler66 = "";

        string spelerchange1 = "";
        string spelerchange2 = "";
        string spelerchange3 = "";
        string spelerchange4 = "";
        string spelerchange5 = "";
        string spelerchange6 = "";

        string spelertop1 = "";
        string spelertop2 = "";
        string spelertop3 = "";
        string spelertop4 = "";
        string spelertop5 = "";
        string spelertop6 = "";

        string threeofakindP1 = "";
        string threeofakindP2 = "";
        string threeofakindP3 = "";
        string threeofakindP4 = "";
        string threeofakindP5 = "";
        string threeofakindP6 = "";

        string fourofakindP1 = "";
        string fourofakindP2 = "";
        string fourofakindP3 = "";
        string fourofakindP4 = "";
        string fourofakindP5 = "";
        string fourofakindP6 = "";

        string largestraatP1 = "";
        string largestraatP2 = "";
        string largestraatP3 = "";
        string largestraatP4 = "";
        string largestraatP5 = "";
        string largestraatP6 = "";

        string smallstraatP1 = "";
        string smallstraatP2 = "";
        string smallstraatP3 = "";
        string smallstraatP4 = "";
        string smallstraatP5 = "";
        string smallstraatP6 = "";

        string fullhuisP1 = "";
        string fullhuisP2 = "";
        string fullhuisP3 = "";
        string fullhuisP4 = "";
        string fullhuisP5 = "";
        string fullhuisP6 = "";

        int stopP1 = 0;
        int stopP2 = 0;
        int stopP3 = 0;
        int stopP4 = 0;
        int stopP5 = 0;
        int stopP6 = 0;

        int endcounter;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (aantalwerpen.Text == "Roll")
            {
                aantalwerpen.Text = "0";
            }

            if (aantalwerpen.Text == "Max")
            {
                MessageBox.Show("Maximum dice rolls reached");
                return;
            }
            try
            {
                aantalworpen = Int32.Parse(aantalwerpen.Text);
            }
            catch (Exception)
            {
                //Nothing
            }

            if (aantalworpen >= 3)
            {
                aantalwerpen.Text = "Max";
                MessageBox.Show("Maximum dice rolls reached");
                return;
            }

            aantalworpen++;
            aantalwerpen.Text = aantalworpen.ToString();

            if (checkbox1.Background == Brushes.Red)
            {
                MyInt1 = _myRandom1.Next(1, 7);
            }

            if (checkbox2.Background == Brushes.Red)
            {
                MyInt2 = _myRandom1.Next(1, 7);
            }

            if (checkbox3.Background == Brushes.Red)
            {
                MyInt3 = _myRandom1.Next(1, 7);
            }

            if (checkbox4.Background == Brushes.Red)
            {
                MyInt4 = _myRandom1.Next(1, 7);
            }

            if (checkbox5.Background == Brushes.Red)
            {
                MyInt5 = _myRandom1.Next(1, 7);
            }

            if (checkbox1.Background == Brushes.Red)
            {
                if (MyInt1 == 1 && aantalworpen < 4)
                {
                    SetAllElementsInvisible1();
                    block11.Visibility = Visibility.Visible;
                }
                else if (MyInt1 == 2 && aantalworpen < 4)
                {
                    SetAllElementsInvisible1();
                    block12.Visibility = Visibility.Visible;
                }
                else if (MyInt1 == 3 && aantalworpen < 4)
                {
                    SetAllElementsInvisible1();
                    block13.Visibility = Visibility.Visible;
                }
                else if (MyInt1 == 4 && aantalworpen < 4)
                {
                    SetAllElementsInvisible1();
                    block14.Visibility = Visibility.Visible;
                }
                else if (MyInt1 == 5 && aantalworpen < 4)
                {
                    SetAllElementsInvisible1();
                    block15.Visibility = Visibility.Visible;
                }
                else if (MyInt1 == 6 && aantalworpen < 4)
                {
                    SetAllElementsInvisible1();
                    block16.Visibility = Visibility.Visible;
                }
            }

            if (checkbox2.Background == Brushes.Red)
            {
                if (MyInt2 == 1 && aantalworpen < 4)
                {
                    SetAllElementsInvisible2();
                    block21.Visibility = Visibility.Visible;
                }
                else if (MyInt2 == 2 && aantalworpen < 4)
                {
                    SetAllElementsInvisible2();
                    block22.Visibility = Visibility.Visible;
                }
                else if (MyInt2 == 3 && aantalworpen < 4)
                {
                    SetAllElementsInvisible2();
                    block23.Visibility = Visibility.Visible;
                }
                else if (MyInt2 == 4 && aantalworpen < 4)
                {
                    SetAllElementsInvisible2();
                    block24.Visibility = Visibility.Visible;
                }
                else if (MyInt2 == 5 && aantalworpen < 4)
                {
                    SetAllElementsInvisible2();
                    block25.Visibility = Visibility.Visible;
                }
                else if (MyInt2 == 6 && aantalworpen < 4)
                {
                    SetAllElementsInvisible2();
                    block26.Visibility = Visibility.Visible;
                }
            }

            if (checkbox3.Background == Brushes.Red)
            {
                if (MyInt3 == 1 && aantalworpen < 4)
                {
                    SetAllElementsInvisible3();
                    block31.Visibility = Visibility.Visible;
                }
                else if (MyInt3 == 2 && aantalworpen < 4)
                {
                    SetAllElementsInvisible3();
                    block32.Visibility = Visibility.Visible;
                }
                else if (MyInt3 == 3 && aantalworpen < 4)
                {
                    SetAllElementsInvisible3();
                    block33.Visibility = Visibility.Visible;
                }
                else if (MyInt3 == 4 && aantalworpen < 4)
                {
                    SetAllElementsInvisible3();
                    block34.Visibility = Visibility.Visible;
                }
                else if (MyInt3 == 5 && aantalworpen < 4)
                {
                    SetAllElementsInvisible3();
                    block35.Visibility = Visibility.Visible;
                }
                else if (MyInt3 == 6 && aantalworpen < 4)
                {
                    SetAllElementsInvisible3();
                    block36.Visibility = Visibility.Visible;
                }
            }

            if (checkbox4.Background == Brushes.Red)
            {
                if (MyInt4 == 1 && aantalworpen < 4)
                {
                    SetAllElementsInvisible4();
                    block41.Visibility = Visibility.Visible;
                }
                else if (MyInt4 == 2 && aantalworpen < 4)
                {
                    SetAllElementsInvisible4();
                    block42.Visibility = Visibility.Visible;
                }
                else if (MyInt4 == 3 && aantalworpen < 4)
                {
                    SetAllElementsInvisible4();
                    block43.Visibility = Visibility.Visible;
                }
                else if (MyInt4 == 4 && aantalworpen < 4)
                {
                    SetAllElementsInvisible4();
                    block44.Visibility = Visibility.Visible;
                }
                else if (MyInt4 == 5 && aantalworpen < 4)
                {
                    SetAllElementsInvisible4();
                    block45.Visibility = Visibility.Visible;
                }
                else if (MyInt4 == 6 && aantalworpen < 4)
                {
                    SetAllElementsInvisible4();
                    block46.Visibility = Visibility.Visible;
                }
            }

            if (checkbox5.Background == Brushes.Red)
            {
                if (MyInt5 == 1 && aantalworpen < 4)
                {
                    SetAllElementsInvisible5();
                    block51.Visibility = Visibility.Visible;
                }
                else if (MyInt5 == 2 && aantalworpen < 4)
                {
                    SetAllElementsInvisible5();
                    block52.Visibility = Visibility.Visible;
                }
                else if (MyInt5 == 3 && aantalworpen < 4)
                {
                    SetAllElementsInvisible5();
                    block53.Visibility = Visibility.Visible;
                }
                else if (MyInt5 == 4 && aantalworpen < 4)
                {
                    SetAllElementsInvisible5();
                    block54.Visibility = Visibility.Visible;
                }
                else if (MyInt5 == 5 && aantalworpen < 4)
                {
                    SetAllElementsInvisible5();
                    block55.Visibility = Visibility.Visible;
                }
                else if (MyInt5 == 6 && aantalworpen < 4)
                {
                    SetAllElementsInvisible5();
                    block56.Visibility = Visibility.Visible;
                }
            }

            if (CancelGuide.Visibility == Visibility.Visible)
            {
                pijl2.Visibility = Visibility.Hidden;
                MessageBox.Show("The number in the blue textbox, next to the dice blocks, shows how many times you rolled.");
                MessageBox.Show("Now, you can lay aside dice to keep. Click on the red buttons to turn them into green. When a button is red, the dice is not saved. When it's green, this dice is saved. On the next rolls, this dice keeps his value. When you click on a green button, he turns red. Then, this dice is not saved anymore.");

                MessageBox.Show("This is everything you need to know! The player with the most points, wins the game!");
                CancelGuide.Visibility = Visibility.Hidden;
            }
        }

        private void SetAllElementsInvisible1()
        {
            block11.Visibility = Visibility.Hidden;
            block12.Visibility = Visibility.Hidden;
            block13.Visibility = Visibility.Hidden;
            block14.Visibility = Visibility.Hidden;
            block15.Visibility = Visibility.Hidden;
            block16.Visibility = Visibility.Hidden;
        }
        private void SetAllElementsInvisible2()
        {
            block21.Visibility = Visibility.Hidden;
            block22.Visibility = Visibility.Hidden;
            block23.Visibility = Visibility.Hidden;
            block24.Visibility = Visibility.Hidden;
            block25.Visibility = Visibility.Hidden;
            block26.Visibility = Visibility.Hidden;
        }
        private void SetAllElementsInvisible3()
        {
            block31.Visibility = Visibility.Hidden;
            block32.Visibility = Visibility.Hidden;
            block33.Visibility = Visibility.Hidden;
            block34.Visibility = Visibility.Hidden;
            block35.Visibility = Visibility.Hidden;
            block36.Visibility = Visibility.Hidden;
        }
        private void SetAllElementsInvisible4()
        {
            block41.Visibility = Visibility.Hidden;
            block42.Visibility = Visibility.Hidden;
            block43.Visibility = Visibility.Hidden;
            block44.Visibility = Visibility.Hidden;
            block45.Visibility = Visibility.Hidden;
            block46.Visibility = Visibility.Hidden;
        }
        private void SetAllElementsInvisible5()
        {
            block51.Visibility = Visibility.Hidden;
            block52.Visibility = Visibility.Hidden;
            block53.Visibility = Visibility.Hidden;
            block54.Visibility = Visibility.Hidden;
            block55.Visibility = Visibility.Hidden;
            block56.Visibility = Visibility.Hidden;
        }
        private void counttheplayers()
        {
            numberofPlayers = Int32.Parse(players.Text);


            playernumbercounter = Int32.Parse(playernumbercount.Text);
            playernumbercounter++;

            playernumbercount.Text = playernumbercounter.ToString();

            if (playernumbercounter > numberofPlayers)
            {
                playernumbercounter = 1;
                playernumbercount.Text = playernumbercounter.ToString();
            }

            if (playernumbercounter == 1)
            {
                backgroundcounter.Background = Brushes.White;
            }
            else if (playernumbercounter == 2)
            {
                backgroundcounter.Background = Brushes.Yellow;
            }
            else if (playernumbercounter == 3)
            {
                backgroundcounter.Background = Brushes.Blue;
            }
            else if (playernumbercounter == 4)
            {
                backgroundcounter.Background = Brushes.Red;
            }
            else if (playernumbercounter == 5)
            {
                backgroundcounter.Background = Brushes.Green;
            }
            else if (playernumbercounter == 6)
            {
                backgroundcounter.Background = Brushes.Brown;
            }
        }

        private void checkbox1_Click(object sender, RoutedEventArgs e)
        {
            if (checkbox1.Background == Brushes.Red)
            {
                checkbox1.Background = Brushes.LightGreen;
            }
            else
            {
                checkbox1.Background = Brushes.Red;
            }
        }

        private void checkbox2_Click(object sender, RoutedEventArgs e)
        {
            if (checkbox2.Background == Brushes.Red)
            {
                checkbox2.Background = Brushes.LightGreen;
            }
            else
            {
                checkbox2.Background = Brushes.Red;
            }
        }

        private void checkbox3_Click(object sender, RoutedEventArgs e)
        {
            if (checkbox3.Background == Brushes.Red)
            {
                checkbox3.Background = Brushes.LightGreen;
            }
            else
            {
                checkbox3.Background = Brushes.Red;
            }
        }

        private void checkbox4_Click(object sender, RoutedEventArgs e)
        {
            if (checkbox4.Background == Brushes.Red)
            {
                checkbox4.Background = Brushes.LightGreen;
            }
            else
            {
                checkbox4.Background = Brushes.Red;
            }
        }

        private void checkbox5_Click(object sender, RoutedEventArgs e)
        {
            if (checkbox5.Background == Brushes.Red)
            {
                checkbox5.Background = Brushes.LightGreen;
            }
            else
            {
                checkbox5.Background = Brushes.Red;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                aantalspelers = Int32.Parse(players.Text);

                if (aantalspelers == 2)
                {
                    endcounter = 26;
                }
                else if (aantalspelers == 3)
                {
                    endcounter = 39;
                }
                else if (aantalspelers == 4)
                {
                    endcounter = 52;
                }
                else if (aantalspelers == 5)
                {
                    endcounter = 65;
                }
                else if (aantalspelers == 6)
                {
                    endcounter = 78;
                }

                if (aantalspelers > 1 && aantalspelers < 7)
                {
                    witteachtergrond.Visibility = Visibility.Visible;
                    checkbox1.Visibility = Visibility.Visible;
                    checkbox2.Visibility = Visibility.Visible;
                    checkbox3.Visibility = Visibility.Visible;
                    checkbox4.Visibility = Visibility.Visible;
                    checkbox5.Visibility = Visibility.Visible;
                    rolldice.Visibility = Visibility.Visible;
                    aantalwerpen.Visibility = Visibility.Visible;
                    Norules.Visibility = Visibility.Hidden;
                    players.Visibility = Visibility.Hidden;
                    nop.Visibility = Visibility.Hidden;
                    Part1.Visibility = Visibility.Visible;
                    Player1part1.Visibility = Visibility.Visible;
                    Player2part1.Visibility = Visibility.Visible;
                    Part2.Visibility = Visibility.Visible;
                    Player1part2.Visibility = Visibility.Visible;
                    Player2part2.Visibility = Visibility.Visible;
                    backgroundcounter.Visibility = Visibility.Visible;
                    playertekst.Visibility = Visibility.Visible;
                    playernumbercount.Visibility = Visibility.Visible;
                    question.Visibility = Visibility.Hidden;
                    Yesrules.Visibility = Visibility.Hidden;

                    if (aantalspelers == 3)
                    {
                        Player3part1.Visibility = Visibility.Visible;
                        Player3part2.Visibility = Visibility.Visible;
                    }
                    else if (aantalspelers == 4)
                    {
                        Player3part1.Visibility = Visibility.Visible;
                        Player4part1.Visibility = Visibility.Visible;
                        Player3part2.Visibility = Visibility.Visible;
                        Player4part2.Visibility = Visibility.Visible;
                    }
                    else if (aantalspelers == 5)
                    {
                        Player3part1.Visibility = Visibility.Visible;
                        Player4part1.Visibility = Visibility.Visible;
                        Player5part1.Visibility = Visibility.Visible;
                        Player3part2.Visibility = Visibility.Visible;
                        Player4part2.Visibility = Visibility.Visible;
                        Player5part2.Visibility = Visibility.Visible;
                    }
                    else if (aantalspelers == 6)
                    {
                        Player3part1.Visibility = Visibility.Visible;
                        Player4part1.Visibility = Visibility.Visible;
                        Player5part1.Visibility = Visibility.Visible;
                        Player6part1.Visibility = Visibility.Visible;
                        Player3part2.Visibility = Visibility.Visible;
                        Player4part2.Visibility = Visibility.Visible;
                        Player5part2.Visibility = Visibility.Visible;
                        Player6part2.Visibility = Visibility.Visible;
                    }

                    MessageBox.Show("Have fun!");
                }
                else
                {
                    MessageBox.Show("Please fill in a number between 2 and 6");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill in a number between 2 and 6");
            }
        }

        private void P1ones_Click(object sender, RoutedEventArgs e)
        {
            int p1ones = 0;

            if(aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if(speler11 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP11 = Int32.Parse(tbP1ones.Text);

            if (playernumbercount.Text == "1")
            {
                if (MyInt1 == 1)
                {
                    p1ones++;
                    counterP11++;
                }

                if (MyInt2 == 1)
                {
                    p1ones++;
                    counterP11++;
                }

                if (MyInt3 == 1)
                {
                    p1ones++;
                    counterP11++;
                }

                if (MyInt4 == 1)
                {
                    p1ones++;
                    counterP11++;
                }

                if (MyInt5 == 1)
                {
                    p1ones++;
                    counterP11++;
                }
                P1ones.Content = p1ones.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler11 = P1ones.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter1 = counterP11 + counterP12 + counterP13 + counterP14 + counterP15 + counterP16;

                totalP1.Text = counter1.ToString();

                if (counter1 >= 63 && stopP1 < 1)
                {
                    bonusP1 = 35;
                    P1bonus.Text = "35";
                    P1bonus.Background = Brushes.Green;

                    counter1 = counter1 + bonusP1;
                    grandtotalP1.Text = counter1.ToString();
                    stopP1++;
                }
                else if (counter1 >= 63 && stopP1 >= 1)
                {
                    P1bonus.Background = Brushes.Green;
                    counter1 = counter1 + bonusP1;
                    grandtotalP1.Text = counter1.ToString();
                }
                else
                {
                    grandtotalP1.Text = totalP1.Text;
                }

                totalP1part2.Text = grandtotalP1.Text;

                grandtotalP1Part1 = Int32.Parse(totalP1part1.Text);
                grandtotalP1Part2 = Int32.Parse(totalP1part2.Text);
                totalgrandP1 = grandtotalP1Part1 + grandtotalP1Part2;

                allP1.Text = totalgrandP1.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 1's turn");
            }
        }

        private void P1twos_Click(object sender, RoutedEventArgs e)
        {
            int p1twos = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler12 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP12 = Int32.Parse(tbP1twos.Text);

            if (playernumbercount.Text == "1")
            {
                if (MyInt1 == 2)
                {
                    p1twos = p1twos + 2;
                    counterP12 = counterP12 + 2;
                }

                if (MyInt2 == 2)
                {
                    p1twos = p1twos + 2;
                    counterP12 = counterP12 + 2;
                }

                if (MyInt3 == 2)
                {
                    p1twos = p1twos + 2;
                    counterP12 = counterP12 + 2;
                }

                if (MyInt4 == 2)
                {
                    p1twos = p1twos + 2;
                    counterP12 = counterP12 + 2;
                }

                if (MyInt5 == 2)
                {
                    p1twos = p1twos + 2;
                    counterP12 = counterP12 + 2;
                }
                P1twos.Content = p1twos.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler12 = P1twos.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter1 = counterP11 + counterP12 + counterP13 + counterP14 + counterP15 + counterP16;

                totalP1.Text = counter1.ToString();

                if (counter1 >= 63 && stopP1 < 1)
                {
                    bonusP1 = 35;
                    P1bonus.Text = "35";
                    P1bonus.Background = Brushes.Green;

                    counter1 = counter1 + bonusP1;
                    grandtotalP1.Text = counter1.ToString();
                    stopP1++;
                }
                else if (counter1 >= 63 && stopP1 >= 1)
                {
                    P1bonus.Background = Brushes.Green;
                    counter1 = counter1 + bonusP1;
                    grandtotalP1.Text = counter1.ToString();
                }
                else
                {
                    grandtotalP1.Text = totalP1.Text;
                }

                totalP1part2.Text = grandtotalP1.Text;

                grandtotalP1Part1 = Int32.Parse(totalP1part1.Text);
                grandtotalP1Part2 = Int32.Parse(totalP1part2.Text);
                totalgrandP1 = grandtotalP1Part1 + grandtotalP1Part2;

                allP1.Text = totalgrandP1.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }

            }
            else
            {
                MessageBox.Show("It's not player 1's turn");
            }
        }

        private void P1threes_Click(object sender, RoutedEventArgs e)
        {
            int p1threes = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler13 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP13 = Int32.Parse(tbP1threes.Text);

            if (playernumbercount.Text == "1")
            {
                if (MyInt1 == 3)
                {
                    p1threes = p1threes + 3;
                    counterP13 = counterP13 + 3;
                }

                if (MyInt2 == 3)
                {
                    p1threes = p1threes + 3;
                    counterP13 = counterP13 + 3;
                }

                if (MyInt3 == 3)
                {
                    p1threes = p1threes + 3;
                    counterP13 = counterP13 + 3;
                }

                if (MyInt4 == 3)
                {
                    p1threes = p1threes + 3;
                    counterP13 = counterP13 + 3;
                }

                if (MyInt5 == 3)
                {
                    p1threes = p1threes + 3;
                    counterP13 = counterP13 + 3;
                }
                P1threes.Content = p1threes.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler13 = P1threes.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter1 = counterP11 + counterP12 + counterP13 + counterP14 + counterP15 + counterP16;

                totalP1.Text = counter1.ToString();

                if (counter1 >= 63 && stopP1 < 1)
                {
                    bonusP1 = 35;
                    P1bonus.Text = "35";
                    P1bonus.Background = Brushes.Green;

                    counter1 = counter1 + bonusP1;
                    grandtotalP1.Text = counter1.ToString();
                    stopP1++;
                }
                else if (counter1 >= 63 && stopP1 >= 1)
                {
                    P1bonus.Background = Brushes.Green;
                    counter1 = counter1 + bonusP1;
                    grandtotalP1.Text = counter1.ToString();
                }
                else
                {
                    grandtotalP1.Text = totalP1.Text;
                }

                totalP1part2.Text = grandtotalP1.Text;

                grandtotalP1Part1 = Int32.Parse(totalP1part1.Text);
                grandtotalP1Part2 = Int32.Parse(totalP1part2.Text);
                totalgrandP1 = grandtotalP1Part1 + grandtotalP1Part2;

                allP1.Text = totalgrandP1.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }

            }
            else
            {
                MessageBox.Show("It's not player 1's turn");
            }
        }

        private void P1fours_Click(object sender, RoutedEventArgs e)
        {
            int p1fours = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler14 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP14 = Int32.Parse(tbP1fours.Text);

            if (playernumbercount.Text == "1")
            {
                if (MyInt1 == 4)
                {
                    p1fours = p1fours + 4;
                    counterP14 = counterP14 + 4;
                }

                if (MyInt2 == 4)
                {
                    p1fours = p1fours + 4;
                    counterP14 = counterP14 + 4;
                }

                if (MyInt3 == 4)
                {
                    p1fours = p1fours + 4;
                    counterP14 = counterP14 + 4;
                }

                if (MyInt4 == 4)
                {
                    p1fours = p1fours + 4;
                    counterP14 = counterP14 + 4;
                }

                if (MyInt5 == 4)
                {
                    p1fours = p1fours + 4;
                    counterP14 = counterP14 + 4;
                }
                P1fours.Content = p1fours.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler14 = P1fours.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter1 = counterP11 + counterP12 + counterP13 + counterP14 + counterP15 + counterP16;

                totalP1.Text = counter1.ToString();

                if (counter1 >= 63 && stopP1 < 1)
                {
                    bonusP1 = 35;
                    P1bonus.Text = "35";
                    P1bonus.Background = Brushes.Green;

                    counter1 = counter1 + bonusP1;
                    grandtotalP1.Text = counter1.ToString();
                    stopP1++;
                }
                else if (counter1 >= 63 && stopP1 >= 1)
                {
                    P1bonus.Background = Brushes.Green;
                    counter1 = counter1 + bonusP1;
                    grandtotalP1.Text = counter1.ToString();
                }
                else
                {
                    grandtotalP1.Text = totalP1.Text;
                }

                totalP1part2.Text = grandtotalP1.Text;

                grandtotalP1Part1 = Int32.Parse(totalP1part1.Text);
                grandtotalP1Part2 = Int32.Parse(totalP1part2.Text);
                totalgrandP1 = grandtotalP1Part1 + grandtotalP1Part2;

                allP1.Text = totalgrandP1.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }

            }
            else
            {
                MessageBox.Show("It's not player 1's turn");
            }
        }

        private void P1fives_Click(object sender, RoutedEventArgs e)
        {
            int p1fives = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler15 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP15 = Int32.Parse(tbP1fives.Text);

            if (playernumbercount.Text == "1")
            {
                if (MyInt1 == 5)
                {
                    p1fives = p1fives + 5;
                    counterP15 = counterP15 + 5;
                }

                if (MyInt2 == 5)
                {
                    p1fives = p1fives + 5;
                    counterP15 = counterP15 + 5;
                }

                if (MyInt3 == 5)
                {
                    p1fives = p1fives + 5;
                    counterP15 = counterP15 + 5;
                }

                if (MyInt4 == 5)
                {
                    p1fives = p1fives + 5;
                    counterP15 = counterP15 + 5;
                }

                if (MyInt5 == 5)
                {
                    p1fives = p1fives + 5;
                    counterP15 = counterP15 + 5;
                }
                P1fives.Content = p1fives.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler15 = P1fives.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter1 = counterP11 + counterP12 + counterP13 + counterP14 + counterP15 + counterP16;

                totalP1.Text = counter1.ToString();

                if (counter1 >= 63 && stopP1 < 1)
                {
                    bonusP1 = 35;
                    P1bonus.Text = "35";
                    P1bonus.Background = Brushes.Green;

                    counter1 = counter1 + bonusP1;
                    grandtotalP1.Text = counter1.ToString();
                    stopP1++;
                }
                else if (counter1 >= 63 && stopP1 >= 1)
                {
                    P1bonus.Background = Brushes.Green;
                    counter1 = counter1 + bonusP1;
                    grandtotalP1.Text = counter1.ToString();
                }
                else
                {
                    grandtotalP1.Text = totalP1.Text;
                }

                totalP1part2.Text = grandtotalP1.Text;

                grandtotalP1Part1 = Int32.Parse(totalP1part1.Text);
                grandtotalP1Part2 = Int32.Parse(totalP1part2.Text);
                totalgrandP1 = grandtotalP1Part1 + grandtotalP1Part2;

                allP1.Text = totalgrandP1.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }

            }
            else
            {
                MessageBox.Show("It's not player 1's turn");
            }
        }

        private void P1sixes_Click(object sender, RoutedEventArgs e)
        {
            int p1sixes = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler16 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP16 = Int32.Parse(tbP1sixes.Text);

            if (playernumbercount.Text == "1")
            {
                if (MyInt1 == 6)
                {
                    p1sixes = p1sixes + 6;
                    counterP16 = counterP16 + 6;
                }

                if (MyInt2 == 6)
                {
                    p1sixes = p1sixes + 6;
                    counterP16 = counterP16 + 6;
                }

                if (MyInt3 == 6)
                {
                    p1sixes = p1sixes + 6;
                    counterP16 = counterP16 + 6;
                }

                if (MyInt4 == 6)
                {
                    p1sixes = p1sixes + 6;
                    counterP16 = counterP16 + 6;
                }

                if (MyInt5 == 6)
                {
                    p1sixes = p1sixes + 6;
                    counterP16 = counterP16 + 6;
                }
                P1sixes.Content = p1sixes.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler16 = P1sixes.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter1 = counterP11 + counterP12 + counterP13 + counterP14 + counterP15 + counterP16;

                totalP1.Text = counter1.ToString();

                if (counter1 >= 63 && stopP1 < 1)
                {
                    bonusP1 = 35;
                    P1bonus.Text = "35";
                    P1bonus.Background = Brushes.Green;

                    counter1 = counter1 + bonusP1;
                    grandtotalP1.Text = counter1.ToString();
                    stopP1++;
                }
                else if (counter1 >= 63 && stopP1 >= 1)
                {
                    P1bonus.Background = Brushes.Green;
                    counter1 = counter1 + bonusP1;
                    grandtotalP1.Text = counter1.ToString();
                }
                else
                {
                    grandtotalP1.Text = totalP1.Text;
                }

                totalP1part2.Text = grandtotalP1.Text;

                grandtotalP1Part1 = Int32.Parse(totalP1part1.Text);
                grandtotalP1Part2 = Int32.Parse(totalP1part2.Text);
                totalgrandP1 = grandtotalP1Part1 + grandtotalP1Part2;

                allP1.Text = totalgrandP1.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 1's turn");
            }
        }

        private void P2ones_Click(object sender, RoutedEventArgs e)
        {
            int p2ones = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler21 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP21 = Int32.Parse(tbP2ones.Text);

            if (playernumbercount.Text == "2")
            {
                if (MyInt1 == 1)
                {
                    p2ones = p2ones + 1;
                    counterP21++;

                }

                if (MyInt2 == 1)
                {
                    p2ones = p2ones + 1;
                    counterP21++;
                }

                if (MyInt3 == 1)
                {
                    p2ones = p2ones + 1;
                    counterP21++;
                }

                if (MyInt4 == 1)
                {
                    p2ones = p2ones + 1;
                    counterP21++;
                }

                if (MyInt5 == 1)
                {
                    p2ones = p2ones + 1;
                    counterP21++;
                }
                P2ones.Content = p2ones.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler21 = P2ones.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter2 = counterP21 + counterP22 + counterP23 + counterP24 + counterP25 + counterP26;

                totalP2.Text = counter2.ToString();

                if (counter2 >= 63 && stopP2 < 1)
                {
                    bonusP2 = 35;
                    P2bonus.Text = "35";
                    P2bonus.Background = Brushes.Green;

                    counter2 = counter2 + bonusP2;
                    grandtotalP2.Text = counter2.ToString();
                    stopP2++;
                }
                else if (counter2 >= 63 && stopP2 >= 1)
                {
                    P2bonus.Background = Brushes.Green;
                    counter2 = counter2 + bonusP2;
                    grandtotalP2.Text = counter2.ToString();
                }
                else
                {
                    grandtotalP2.Text = totalP2.Text;
                }

                totalP2part2.Text = grandtotalP2.Text;

                grandtotalP2Part1 = Int32.Parse(totalP2part1.Text);
                grandtotalP2Part2 = Int32.Parse(totalP2part2.Text);
                totalgrandP2 = grandtotalP2Part1 + grandtotalP2Part2;

                allP2.Text = totalgrandP2.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 2's turn");
            }
        }

        private void P2twos_Click(object sender, RoutedEventArgs e)
        {
            int p2twos = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler22 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP22 = Int32.Parse(tbP2twos.Text);

            if (playernumbercount.Text == "2")
            {
                if (MyInt1 == 2)
                {
                    p2twos = p2twos + 2;
                    counterP22 = counterP22 + 2;
                }

                if (MyInt2 == 2)
                {
                    p2twos = p2twos + 2;
                    counterP22 = counterP22 + 2;
                }

                if (MyInt3 == 2)
                {
                    p2twos = p2twos + 2;
                    counterP22 = counterP22 + 2;
                }

                if (MyInt4 == 2)
                {
                    p2twos = p2twos + 2;
                    counterP22 = counterP22 + 2;
                }

                if (MyInt5 == 2)
                {
                    p2twos = p2twos + 2;
                    counterP22 = counterP22 + 2;
                }
                P2twos.Content = p2twos.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler22 = P2twos.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter2 = counterP21 + counterP22 + counterP23 + counterP24 + counterP25 + counterP26;

                totalP2.Text = counter2.ToString();

                if (counter2 >= 63 && stopP2 < 1)
                {
                    bonusP2 = 35;
                    P2bonus.Text = "35";
                    P2bonus.Background = Brushes.Green;

                    counter2 = counter2 + bonusP2;
                    grandtotalP2.Text = counter2.ToString();
                    stopP2++;
                }
                else if (counter2 >= 63 && stopP2 >= 1)
                {
                    P2bonus.Background = Brushes.Green;
                    counter2 = counter2 + bonusP2;
                    grandtotalP2.Text = counter2.ToString();
                }
                else
                {
                    grandtotalP2.Text = totalP2.Text;
                }

                totalP2part2.Text = grandtotalP2.Text;

                grandtotalP2Part1 = Int32.Parse(totalP2part1.Text);
                grandtotalP2Part2 = Int32.Parse(totalP2part2.Text);
                totalgrandP2 = grandtotalP2Part1 + grandtotalP2Part2;

                allP2.Text = totalgrandP2.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 2's turn");
            }
        }

        private void P2threes_Click(object sender, RoutedEventArgs e)
        {
            int p2threes = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler23 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP23 = Int32.Parse(tbP2threes.Text);

            if (playernumbercount.Text == "2")
            {
                if (MyInt1 == 3)
                {
                    p2threes = p2threes + 3;
                    counterP23 = counterP23 + 3;
                }

                if (MyInt2 == 3)
                {
                    p2threes = p2threes + 3;
                    counterP23 = counterP23 + 3;
                }

                if (MyInt3 == 3)
                {
                    p2threes = p2threes + 3;
                    counterP23 = counterP23 + 3;
                }

                if (MyInt4 == 3)
                {
                    p2threes = p2threes + 3;
                    counterP23 = counterP23 + 3;
                }

                if (MyInt5 == 3)
                {
                    p2threes = p2threes + 3;
                    counterP23 = counterP23 + 3;
                }
                P2threes.Content = p2threes.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler23 = P2threes.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter2 = counterP21 + counterP22 + counterP23 + counterP24 + counterP25 + counterP26;

                totalP2.Text = counter2.ToString();

                if (counter2 >= 63 && stopP2 < 1)
                {
                    bonusP2 = 35;
                    P2bonus.Text = "35";
                    P2bonus.Background = Brushes.Green;

                    counter2 = counter2 + bonusP2;
                    grandtotalP2.Text = counter2.ToString();
                    stopP2++;
                }
                else if (counter2 >= 63 && stopP2 >= 1)
                {
                    P2bonus.Background = Brushes.Green;
                    counter2 = counter2 + bonusP2;
                    grandtotalP2.Text = counter2.ToString();
                }
                else
                {
                    grandtotalP2.Text = totalP2.Text;
                }

                totalP2part2.Text = grandtotalP2.Text;

                grandtotalP2Part1 = Int32.Parse(totalP2part1.Text);
                grandtotalP2Part2 = Int32.Parse(totalP2part2.Text);
                totalgrandP2 = grandtotalP2Part1 + grandtotalP2Part2;

                allP2.Text = totalgrandP2.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 2's turn");
            }
        }

        private void P2fours_Click(object sender, RoutedEventArgs e)
        {
            int p2fours = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler24 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP24 = Int32.Parse(tbP2fours.Text);

            if (playernumbercount.Text == "2")
            {
                if (MyInt1 == 4)
                {
                    p2fours = p2fours + 4;
                    counterP24 = counterP24 + 4;
                }

                if (MyInt2 == 4)
                {
                    p2fours = p2fours + 4;
                    counterP24 = counterP24 + 4;
                }

                if (MyInt3 == 4)
                {
                    p2fours = p2fours + 4;
                    counterP24 = counterP24 + 4;
                }

                if (MyInt4 == 4)
                {
                    p2fours = p2fours + 4;
                    counterP24 = counterP24 + 4;
                }

                if (MyInt5 == 4)
                {
                    p2fours = p2fours + 4;
                    counterP24 = counterP24 + 4;
                }
                P2fours.Content = p2fours.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler24 = P2fours.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter2 = counterP21 + counterP22 + counterP23 + counterP24 + counterP25 + counterP26;

                totalP2.Text = counter2.ToString();

                if (counter2 >= 63 && stopP2 < 1)
                {
                    bonusP2 = 35;
                    P2bonus.Text = "35";
                    P2bonus.Background = Brushes.Green;

                    counter2 = counter2 + bonusP2;
                    grandtotalP2.Text = counter2.ToString();
                    stopP2++;
                }
                else if (counter2 >= 63 && stopP2 >= 1)
                {
                    P2bonus.Background = Brushes.Green;
                    counter2 = counter2 + bonusP2;
                    grandtotalP2.Text = counter2.ToString();
                }
                else
                {
                    grandtotalP2.Text = totalP2.Text;
                }

                totalP2part2.Text = grandtotalP2.Text;

                grandtotalP2Part1 = Int32.Parse(totalP2part1.Text);
                grandtotalP2Part2 = Int32.Parse(totalP2part2.Text);
                totalgrandP2 = grandtotalP2Part1 + grandtotalP2Part2;

                allP2.Text = totalgrandP2.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 2's turn");
            }
        }

        private void P2fives_Click(object sender, RoutedEventArgs e)
        {
            int p2fives = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler25 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP25 = Int32.Parse(tbP2fives.Text);

            if (playernumbercount.Text == "2")
            {
                if (MyInt1 == 5)
                {
                    p2fives = p2fives + 5;
                    counterP25 = counterP25 + 5;
                }

                if (MyInt2 == 5)
                {
                    p2fives = p2fives + 5;
                    counterP25 = counterP25 + 5;
                }

                if (MyInt3 == 5)
                {
                    p2fives = p2fives + 5;
                    counterP25 = counterP25 + 5;
                }

                if (MyInt4 == 5)
                {
                    p2fives = p2fives + 5;
                    counterP25 = counterP25 + 5;
                }

                if (MyInt5 == 5)
                {
                    p2fives = p2fives + 5;
                    counterP25 = counterP25 + 5;
                }
                P2fives.Content = p2fives.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler25 = P2fives.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter2 = counterP21 + counterP22 + counterP23 + counterP24 + counterP25 + counterP26;

                totalP2.Text = counter2.ToString();

                if (counter2 >= 63 && stopP2 < 1)
                {
                    bonusP2 = 35;
                    P2bonus.Text = "35";
                    P2bonus.Background = Brushes.Green;

                    counter2 = counter2 + bonusP2;
                    grandtotalP2.Text = counter2.ToString();
                    stopP2++;
                }
                else if (counter2 >= 63 && stopP2 >= 1)
                {
                    P2bonus.Background = Brushes.Green;
                    counter2 = counter2 + bonusP2;
                    grandtotalP2.Text = counter2.ToString();
                }
                else
                {
                    grandtotalP2.Text = totalP2.Text;
                }

                totalP2part2.Text = grandtotalP2.Text;

                grandtotalP2Part1 = Int32.Parse(totalP2part1.Text);
                grandtotalP2Part2 = Int32.Parse(totalP2part2.Text);
                totalgrandP2 = grandtotalP2Part1 + grandtotalP2Part2;

                allP2.Text = totalgrandP2.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 2's turn");
            }
        }

        private void P2sixes_Click(object sender, RoutedEventArgs e)
        {
            int p2sixes = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler26 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP26 = Int32.Parse(tbP2sixes.Text);

            if (playernumbercount.Text == "2")
            {
                if (MyInt1 == 6)
                {
                    p2sixes = p2sixes + 6;
                    counterP26 = counterP26 + 6;
                }

                if (MyInt2 == 6)
                {
                    p2sixes = p2sixes + 6;
                    counterP26 = counterP26 + 6;
                }

                if (MyInt3 == 6)
                {
                    p2sixes = p2sixes + 6;
                    counterP26 = counterP26 + 6;
                }

                if (MyInt4 == 6)
                {
                    p2sixes = p2sixes + 6;
                    counterP26 = counterP26 + 6;
                }

                if (MyInt5 == 6)
                {
                    p2sixes = p2sixes + 6;
                    counterP26 = counterP26 + 6;
                }
                P2sixes.Content = p2sixes.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler26 = P2sixes.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter2 = counterP21 + counterP22 + counterP23 + counterP24 + counterP25 + counterP26;

                totalP2.Text = counter2.ToString();

                if (counter2 >= 63 && stopP2 < 1)
                {
                    bonusP2 = 35;
                    P2bonus.Text = "35";
                    P2bonus.Background = Brushes.Green;

                    counter2 = counter2 + bonusP2;
                    grandtotalP2.Text = counter2.ToString();
                    stopP2++;
                }
                else if (counter2 >= 63 && stopP2 >= 1)
                {
                    P2bonus.Background = Brushes.Green;
                    counter2 = counter2 + bonusP2;
                    grandtotalP2.Text = counter2.ToString();
                }
                else
                {
                    grandtotalP2.Text = totalP2.Text;
                }

                totalP2part2.Text = grandtotalP2.Text;

                grandtotalP2Part1 = Int32.Parse(totalP2part1.Text);
                grandtotalP2Part2 = Int32.Parse(totalP2part2.Text);
                totalgrandP2 = grandtotalP2Part1 + grandtotalP2Part2;

                allP2.Text = totalgrandP2.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 2's turn");
            }
        }

        private void P3ones_Click(object sender, RoutedEventArgs e)
        {
            int p3ones = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler31 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP31 = Int32.Parse(tbP3ones.Text);

            if (playernumbercount.Text == "3")
            {
                if (MyInt1 == 1)
                {
                    p3ones = p3ones + 1;
                    counterP31++;
                }

                if (MyInt2 == 1)
                {
                    p3ones = p3ones + 1;
                    counterP31++;
                }

                if (MyInt3 == 1)
                {
                    p3ones = p3ones + 1;
                    counterP31++;
                }

                if (MyInt4 == 1)
                {
                    p3ones = p3ones + 1;
                    counterP31++;
                }

                if (MyInt5 == 1)
                {
                    p3ones = p3ones + 1;
                    counterP31++;
                }
                P3ones.Content = p3ones.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler31 = P3ones.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter3 = counterP31 + counterP32 + counterP33 + counterP34 + counterP35 + counterP36;

                totalP3.Text = counter3.ToString();

                if (counter3 >= 63 && stopP3 < 1)
                {
                    bonusP3 = 35;
                    P3bonus.Text = "35";
                    P3bonus.Background = Brushes.Green;

                    counter3 = counter3 + bonusP3;
                    grandtotalP3.Text = counter3.ToString();
                    stopP3++;
                }
                else if (counter3 >= 63 && stopP3 >= 1)
                {
                    P3bonus.Background = Brushes.Green;
                    counter3 = counter3 + bonusP3;
                    grandtotalP3.Text = counter3.ToString();
                }
                else
                {
                    grandtotalP3.Text = totalP3.Text;
                }

                totalP3part2.Text = grandtotalP3.Text;

                grandtotalP3Part1 = Int32.Parse(totalP3part1.Text);
                grandtotalP3Part2 = Int32.Parse(totalP3part2.Text);
                totalgrandP3 = grandtotalP3Part1 + grandtotalP3Part2;

                allP3.Text = totalgrandP3.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 3's turn");
            }
        }

        private void P3twos_Click(object sender, RoutedEventArgs e)
        {
            int p3twos = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler32 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP32 = Int32.Parse(tbP3twos.Text);

            if (playernumbercount.Text == "3")
            {
                if (MyInt1 == 2)
                {
                    p3twos = p3twos + 2;
                    counterP32 = counterP32 + 2;
                }

                if (MyInt2 == 2)
                {
                    p3twos = p3twos + 2;
                    counterP32 = counterP32 + 2;
                }

                if (MyInt3 == 2)
                {
                    p3twos = p3twos + 2; 
                    counterP32 = counterP32 + 2;
                }

                if (MyInt4 == 2)
                {
                    p3twos = p3twos + 2;
                    counterP32 = counterP32 + 2;
                }

                if (MyInt5 == 2)
                {
                    p3twos = p3twos + 2;
                    counterP32 = counterP32 + 2;
                }
                P3twos.Content = p3twos.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler32 = P3twos.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter3 = counterP31 + counterP32 + counterP33 + counterP34 + counterP35 + counterP36;

                totalP3.Text = counter3.ToString();

                if (counter3 >= 63 && stopP3 < 1)
                {
                    bonusP3 = 35;
                    P3bonus.Text = "35";
                    P3bonus.Background = Brushes.Green;

                    counter3 = counter3 + bonusP3;
                    grandtotalP3.Text = counter3.ToString();
                    stopP3++;
                }
                else if (counter3 >= 63 && stopP3 >= 1)
                {
                    P3bonus.Background = Brushes.Green;
                    counter3 = counter3 + bonusP3;
                    grandtotalP3.Text = counter3.ToString();
                }
                else
                {
                    grandtotalP3.Text = totalP3.Text;
                }

                totalP3part2.Text = grandtotalP3.Text;

                grandtotalP3Part1 = Int32.Parse(totalP3part1.Text);
                grandtotalP3Part2 = Int32.Parse(totalP3part2.Text);
                totalgrandP3 = grandtotalP3Part1 + grandtotalP3Part2;

                allP3.Text = totalgrandP3.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 3's turn");
            }
        }

        private void P3threes_Click(object sender, RoutedEventArgs e)
        {
            int p3threes = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler33 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP33 = Int32.Parse(tbP3threes.Text);

            if (playernumbercount.Text == "3")
            {
                if (MyInt1 == 3)
                {
                    p3threes = p3threes + 3;
                    counterP33 = counterP33 + 3;
                }

                if (MyInt2 == 3)
                {
                    p3threes = p3threes + 3;
                    counterP33 = counterP33 + 3;
                }

                if (MyInt3 == 3)
                {
                    p3threes = p3threes + 3;
                    counterP33 = counterP33 + 3;
                }

                if (MyInt4 == 3)
                {
                    p3threes = p3threes + 3;
                    counterP33 = counterP33 + 3;
                }

                if (MyInt5 == 3)
                {
                    p3threes = p3threes + 3;
                    counterP33 = counterP33 + 3;
                }
                P3threes.Content = p3threes.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler33 = P3threes.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter3 = counterP31 + counterP32 + counterP33 + counterP34 + counterP35 + counterP36;

                totalP3.Text = counter3.ToString();

                if (counter3 >= 63 && stopP3 < 1)
                {
                    bonusP3 = 35;
                    P3bonus.Text = "35";
                    P3bonus.Background = Brushes.Green;

                    counter3 = counter3 + bonusP3;
                    grandtotalP3.Text = counter3.ToString();
                    stopP3++;
                }
                else if (counter3 >= 63 && stopP3 >= 1)
                {
                    P3bonus.Background = Brushes.Green;
                    counter3 = counter3 + bonusP3;
                    grandtotalP3.Text = counter3.ToString();
                }
                else
                {
                    grandtotalP3.Text = totalP3.Text;
                }

                totalP3part2.Text = grandtotalP3.Text;

                grandtotalP3Part1 = Int32.Parse(totalP3part1.Text);
                grandtotalP3Part2 = Int32.Parse(totalP3part2.Text);
                totalgrandP3 = grandtotalP3Part1 + grandtotalP3Part2;

                allP3.Text = totalgrandP3.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 3's turn");
            }
        }

        private void P3fours_Click(object sender, RoutedEventArgs e)
        {
            int p3fours = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler34 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP34 = Int32.Parse(tbP3fours.Text);

            if (playernumbercount.Text == "3")
            {
                if (MyInt1 == 4)
                {
                    p3fours = p3fours + 4;
                    counterP34 = counterP34 + 4;
                }

                if (MyInt2 == 4)
                {
                    p3fours = p3fours + 4;
                    counterP34 = counterP34 + 4;
                }

                if (MyInt3 == 4)
                {
                    p3fours = p3fours + 4;
                    counterP34 = counterP34 + 4;
                }

                if (MyInt4 == 4)
                {
                    p3fours = p3fours + 4;
                    counterP34 = counterP34 + 4;
                }

                if (MyInt5 == 4)
                {
                    p3fours = p3fours + 4;
                    counterP34 = counterP34 + 4;
                }
                P3fours.Content = p3fours.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler34 = P3fours.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter3 = counterP31 + counterP32 + counterP33 + counterP34 + counterP35 + counterP36;

                totalP3.Text = counter3.ToString();

                if (counter3 >= 63 && stopP3 < 1)
                {
                    bonusP3 = 35;
                    P3bonus.Text = "35";
                    P3bonus.Background = Brushes.Green;

                    counter3 = counter3 + bonusP3;
                    grandtotalP3.Text = counter3.ToString();
                    stopP3++;
                }
                else if (counter3 >= 63 && stopP3 >= 1)
                {
                    P3bonus.Background = Brushes.Green;
                    counter3 = counter3 + bonusP3;
                    grandtotalP3.Text = counter3.ToString();
                }
                else
                {
                    grandtotalP3.Text = totalP3.Text;
                }

                totalP3part2.Text = grandtotalP3.Text;

                grandtotalP3Part1 = Int32.Parse(totalP3part1.Text);
                grandtotalP3Part2 = Int32.Parse(totalP3part2.Text);
                totalgrandP3 = grandtotalP3Part1 + grandtotalP3Part2;

                allP3.Text = totalgrandP3.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 3's turn");
            }
        }

        private void P3fives_Click(object sender, RoutedEventArgs e)
        {
            int p3fives = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler35 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP35 = Int32.Parse(tbP3fives.Text);

            if (playernumbercount.Text == "3")
            {
                if (MyInt1 == 5)
                {
                    p3fives = p3fives + 5;
                    counterP35 = counterP35 + 5;
                } 

                if (MyInt2 == 5)
                {
                    p3fives = p3fives + 5;
                    counterP35 = counterP35 + 5;
                }

                if (MyInt3 == 5)
                {
                    p3fives = p3fives + 5;
                    counterP35 = counterP35 + 5;
                }

                if (MyInt4 == 5)
                {
                    p3fives = p3fives + 5;
                    counterP35 = counterP35 + 5;
                }

                if (MyInt5 == 5)
                {
                    p3fives = p3fives + 5;
                    counterP35 = counterP35 + 5;
                }
                P3fives.Content = p3fives.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler35 = P3fives.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter3 = counterP31 + counterP32 + counterP33 + counterP34 + counterP35 + counterP36;

                totalP3.Text = counter3.ToString();

                if (counter3 >= 63 && stopP3 < 1)
                {
                    bonusP3 = 35;
                    P3bonus.Text = "35";
                    P3bonus.Background = Brushes.Green;

                    counter3 = counter3 + bonusP3;
                    grandtotalP3.Text = counter3.ToString();
                    stopP3++;
                }
                else if (counter3 >= 63 && stopP3 >= 1)
                {
                    P3bonus.Background = Brushes.Green;
                    counter3 = counter3 + bonusP3;
                    grandtotalP3.Text = counter3.ToString();
                }
                else
                {
                    grandtotalP3.Text = totalP3.Text;
                }

                totalP3part2.Text = grandtotalP3.Text;

                grandtotalP3Part1 = Int32.Parse(totalP3part1.Text);
                grandtotalP3Part2 = Int32.Parse(totalP3part2.Text);
                totalgrandP3 = grandtotalP3Part1 + grandtotalP3Part2;

                allP3.Text = totalgrandP3.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 3's turn");
            }
        }

        private void P3sixes_Click(object sender, RoutedEventArgs e)
        {
            int p3sixes = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler36 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP36 = Int32.Parse(tbP3sixes.Text);

            if (playernumbercount.Text == "3")
            {
                if (MyInt1 == 6)
                {
                    p3sixes = p3sixes + 6;
                    counterP36 = counterP36 + 6;
                }

                if (MyInt2 == 6)
                {
                    p3sixes = p3sixes + 6;
                    counterP36 = counterP36 + 6;
                }

                if (MyInt3 == 6)
                {
                    p3sixes = p3sixes + 6;
                    counterP36 = counterP36 + 6;
                }

                if (MyInt4 == 6)
                {
                    p3sixes = p3sixes + 6;
                    counterP36 = counterP36 + 6;
                }

                if (MyInt5 == 6)
                {
                    p3sixes = p3sixes + 6;
                    counterP36 = counterP36 + 6;
                }
                P3sixes.Content = p3sixes.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler36 = P3sixes.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter3 = counterP31 + counterP32 + counterP33 + counterP34 + counterP35 + counterP36;

                totalP3.Text = counter3.ToString();

                if (counter3 >= 63 && stopP3 < 1)
                {
                    bonusP3 = 35;
                    P3bonus.Text = "35";
                    P3bonus.Background = Brushes.Green;

                    counter3 = counter3 + bonusP3;
                    grandtotalP3.Text = counter3.ToString();
                    stopP3++;
                }
                else if (counter3 >= 63 && stopP3 >= 1)
                {
                    P3bonus.Background = Brushes.Green;
                    counter3 = counter3 + bonusP3;
                    grandtotalP3.Text = counter3.ToString();
                }
                else
                {
                    grandtotalP3.Text = totalP3.Text;
                }

                totalP3part2.Text = grandtotalP3.Text;

                grandtotalP3Part1 = Int32.Parse(totalP3part1.Text);
                grandtotalP3Part2 = Int32.Parse(totalP3part2.Text);
                totalgrandP3 = grandtotalP3Part1 + grandtotalP3Part2;

                allP3.Text = totalgrandP3.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 3's turn");
            }
        }

        private void P4ones_Click(object sender, RoutedEventArgs e)
        {
            int p4ones = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler41 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP41 = Int32.Parse(tbP4ones.Text);

            if (playernumbercount.Text == "4")
            {
                if (MyInt1 == 1)
                {
                    p4ones = p4ones + 1;
                    counterP41++;
                }

                if (MyInt2 == 1)
                {
                    p4ones = p4ones + 1;
                    counterP41++;
                }

                if (MyInt3 == 1)
                {
                    p4ones = p4ones + 1;
                    counterP41++;
                }

                if (MyInt4 == 1)
                {
                    p4ones = p4ones + 1;
                    counterP41++;
                }

                if (MyInt5 == 1)
                {
                    p4ones = p4ones + 1;
                    counterP41++;
                }
                P4ones.Content = p4ones.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler41 = P4ones.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter4 = counterP41 + counterP42 + counterP43 + counterP44 + counterP45 + counterP46;

                totalP4.Text = counter4.ToString();

                if (counter4 >= 63 && stopP4 < 1)
                {
                    bonusP4 = 35;
                    P4bonus.Text = "35";
                    P4bonus.Background = Brushes.Green;

                    counter4 = counter4 + bonusP4;
                    grandtotalP4.Text = counter4.ToString();
                    stopP4++;
                }
                else if (counter4 >= 63 && stopP4 >= 1)
                {
                    P4bonus.Background = Brushes.Green;
                    counter4 = counter4 + bonusP4;
                    grandtotalP4.Text = counter4.ToString();
                }
                else
                {
                    grandtotalP4.Text = totalP4.Text;
                }

                totalP4part2.Text = grandtotalP4.Text;

                grandtotalP4Part1 = Int32.Parse(totalP4part1.Text);
                grandtotalP4Part2 = Int32.Parse(totalP4part2.Text);
                totalgrandP4 = grandtotalP4Part1 + grandtotalP4Part2;

                allP4.Text = totalgrandP4.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 4's turn");
            }
        }

        private void P4twos_Click(object sender, RoutedEventArgs e)
        {
            int p4twos = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler42 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP42 = Int32.Parse(tbP4twos.Text);

            if (playernumbercount.Text == "4")
            {
                if (MyInt1 == 2)
                {
                    p4twos = p4twos + 2;
                    counterP42 = counterP42 + 2;
                }

                if (MyInt2 == 2)
                {
                    p4twos = p4twos + 2;
                    counterP42 = counterP42 + 2;
                }

                if (MyInt3 == 2)
                {
                    p4twos = p4twos + 2;
                    counterP42 = counterP42 + 2;
                }

                if (MyInt4 == 2)
                {
                    p4twos = p4twos + 2;
                    counterP42 = counterP42 + 2;
                }

                if (MyInt5 == 2)
                {
                    p4twos = p4twos + 2;
                    counterP42 = counterP42 + 2;
                }
                P4twos.Content = p4twos.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler42 = P4twos.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter4 = counterP41 + counterP42 + counterP43 + counterP44 + counterP45 + counterP46;

                totalP4.Text = counter4.ToString();

                if (counter4 >= 63 && stopP4 < 1)
                {
                    bonusP4 = 35;
                    P4bonus.Text = "35";
                    P4bonus.Background = Brushes.Green;

                    counter4 = counter4 + bonusP4;
                    grandtotalP4.Text = counter4.ToString();
                    stopP4++;
                }
                else if (counter4 >= 63 && stopP4 >= 1)
                {
                    P4bonus.Background = Brushes.Green;
                    counter4 = counter4 + bonusP4;
                    grandtotalP4.Text = counter4.ToString();
                }
                else
                {
                    grandtotalP4.Text = totalP4.Text;
                }

                totalP4part2.Text = grandtotalP4.Text;

                grandtotalP4Part1 = Int32.Parse(totalP4part1.Text);
                grandtotalP4Part2 = Int32.Parse(totalP4part2.Text);
                totalgrandP4 = grandtotalP4Part1 + grandtotalP4Part2;

                allP4.Text = totalgrandP4.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 4's turn");
            }
        }

        private void P4threes_Click(object sender, RoutedEventArgs e)
        {
            int p4threes = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler43 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP43 = Int32.Parse(tbP4threes.Text);

            if (playernumbercount.Text == "4")
            {
                if (MyInt1 == 3)
                {
                    p4threes = p4threes + 3;
                    counterP43 = counterP43 + 3;
                }

                if (MyInt2 == 3)
                {
                    p4threes = p4threes + 3;
                    counterP43 = counterP43 + 3;
                }

                if (MyInt3 == 3)
                {
                    p4threes = p4threes + 3;
                    counterP43 = counterP43 + 3;
                }

                if (MyInt4 == 3)
                {
                    p4threes = p4threes + 3;
                    counterP43 = counterP43 + 3;
                }

                if (MyInt5 == 3)
                {
                    p4threes = p4threes + 3;
                    counterP43 = counterP43 + 3;
                }
                P4threes.Content = p4threes.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler43 = P4threes.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter4 = counterP41 + counterP42 + counterP43 + counterP44 + counterP45 + counterP46;

                totalP4.Text = counter4.ToString();

                if (counter4 >= 63 && stopP4 < 1)
                {
                    bonusP4 = 35;
                    P4bonus.Text = "35";
                    P4bonus.Background = Brushes.Green;

                    counter4 = counter4 + bonusP4;
                    grandtotalP4.Text = counter4.ToString();
                    stopP4++;
                }
                else if (counter4 >= 63 && stopP4 >= 1)
                {
                    P4bonus.Background = Brushes.Green;
                    counter4 = counter4 + bonusP4;
                    grandtotalP4.Text = counter4.ToString();
                }
                else
                {
                    grandtotalP4.Text = totalP4.Text;
                }

                totalP4part2.Text = grandtotalP4.Text;

                grandtotalP4Part1 = Int32.Parse(totalP4part1.Text);
                grandtotalP4Part2 = Int32.Parse(totalP4part2.Text);
                totalgrandP4 = grandtotalP4Part1 + grandtotalP4Part2;

                allP4.Text = totalgrandP4.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 4's turn");
            }
        }

        private void P4fours_Click(object sender, RoutedEventArgs e)
        {
            int p4fours = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler44 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP44 = Int32.Parse(tbP4fours.Text);

            if (playernumbercount.Text == "4")
            {
                if (MyInt1 == 4)
                {
                    p4fours = p4fours + 4;
                    counterP44 = counterP44 + 4;
                }

                if (MyInt2 == 4)
                {
                    p4fours = p4fours + 4;
                    counterP44 = counterP44 + 4;
                }

                if (MyInt3 == 4)
                {
                    p4fours = p4fours + 4;
                    counterP44 = counterP44 + 4;
                }

                if (MyInt4 == 4)
                {
                    p4fours = p4fours + 4;
                    counterP44 = counterP44 + 4;
                }

                if (MyInt5 == 4)
                {
                    p4fours = p4fours + 4;
                    counterP44 = counterP44 + 4;
                }
                P4fours.Content = p4fours.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler44 = P4fours.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter4 = counterP41 + counterP42 + counterP43 + counterP44 + counterP45 + counterP46;

                totalP4.Text = counter4.ToString();

                if (counter4 >= 63 && stopP4 < 1)
                {
                    bonusP4 = 35;
                    P4bonus.Text = "35";
                    P4bonus.Background = Brushes.Green;

                    counter4 = counter4 + bonusP4;
                    grandtotalP4.Text = counter4.ToString();
                    stopP4++;
                }
                else if (counter4 >= 63 && stopP4 >= 1)
                {
                    P4bonus.Background = Brushes.Green;
                    counter4 = counter4 + bonusP4;
                    grandtotalP4.Text = counter4.ToString();
                }
                else
                {
                    grandtotalP4.Text = totalP4.Text;
                }

                totalP4part2.Text = grandtotalP4.Text;

                grandtotalP4Part1 = Int32.Parse(totalP4part1.Text);
                grandtotalP4Part2 = Int32.Parse(totalP4part2.Text);
                totalgrandP4 = grandtotalP4Part1 + grandtotalP4Part2;

                allP4.Text = totalgrandP4.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 4's turn");
            }
        }

        private void P4fives_Click(object sender, RoutedEventArgs e)
        {
            int p4fives = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler45 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP45 = Int32.Parse(tbP4fives.Text);

            if (playernumbercount.Text == "4")
            {
                if (MyInt1 == 5)
                {
                    p4fives = p4fives + 5;
                    counterP45 = counterP45 + 5;
                }

                if (MyInt2 == 5)
                {
                    p4fives = p4fives + 5;
                    counterP45 = counterP45 + 5;
                }

                if (MyInt3 == 5)
                {
                    p4fives = p4fives + 5;
                    counterP45 = counterP45 + 5;
                }

                if (MyInt4 == 5)
                {
                    p4fives = p4fives + 5;
                    counterP45 = counterP45 + 5;
                }

                if (MyInt5 == 5)
                {
                    p4fives = p4fives + 5;
                    counterP45 = counterP45 + 5;
                }
                P4fives.Content = p4fives.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler45 = P4fives.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter4 = counterP41 + counterP42 + counterP43 + counterP44 + counterP45 + counterP46;

                totalP4.Text = counter4.ToString();

                if (counter4 >= 63 && stopP4 < 1)
                {
                    bonusP4 = 35;
                    P4bonus.Text = "35";
                    P4bonus.Background = Brushes.Green;

                    counter4 = counter4 + bonusP4;
                    grandtotalP4.Text = counter4.ToString();
                    stopP4++;
                }
                else if (counter4 >= 63 && stopP4 >= 1)
                {
                    P4bonus.Background = Brushes.Green;
                    counter4 = counter4 + bonusP4;
                    grandtotalP4.Text = counter4.ToString();
                }
                else
                {
                    grandtotalP4.Text = totalP4.Text;
                }

                totalP4part2.Text = grandtotalP4.Text;

                grandtotalP4Part1 = Int32.Parse(totalP4part1.Text);
                grandtotalP4Part2 = Int32.Parse(totalP4part2.Text);
                totalgrandP4 = grandtotalP4Part1 + grandtotalP4Part2;

                allP4.Text = totalgrandP4.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 4's turn");
            }
        }

        private void P4sixes_Click(object sender, RoutedEventArgs e)
        {
            int p4sixes = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler46 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP46 = Int32.Parse(tbP4sixes.Text);

            if (playernumbercount.Text == "4")
            {
                if (MyInt1 == 6)
                {
                    p4sixes = p4sixes + 6;
                    counterP46 = counterP46 + 6;
                }

                if (MyInt2 == 6)
                {
                    p4sixes = p4sixes + 6;
                    counterP46 = counterP46 + 6;
                }

                if (MyInt3 == 6)
                {
                    p4sixes = p4sixes + 6;
                    counterP46 = counterP46 + 6;
                }

                if (MyInt4 == 6)
                {
                    p4sixes = p4sixes + 6;
                    counterP46 = counterP46 + 6;
                }

                if (MyInt5 == 6)
                {
                    p4sixes = p4sixes + 6;
                    counterP46 = counterP46 + 6;
                }
                P4sixes.Content = p4sixes.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler46 = P4sixes.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter4 = counterP41 + counterP42 + counterP43 + counterP44 + counterP45 + counterP46;

                totalP4.Text = counter4.ToString();

                if (counter4 >= 63 && stopP4 < 1)
                {
                    bonusP4 = 35;
                    P4bonus.Text = "35";
                    P4bonus.Background = Brushes.Green;

                    counter4 = counter4 + bonusP4;
                    grandtotalP4.Text = counter4.ToString();
                    stopP4++;
                }
                else if (counter4 >= 63 && stopP4 >= 1)
                {
                    P4bonus.Background = Brushes.Green;
                    counter4 = counter4 + bonusP4;
                    grandtotalP4.Text = counter4.ToString();
                }
                else
                {
                    grandtotalP4.Text = totalP4.Text;
                }

                totalP4part2.Text = grandtotalP4.Text;

                grandtotalP4Part1 = Int32.Parse(totalP4part1.Text);
                grandtotalP4Part2 = Int32.Parse(totalP4part2.Text);
                totalgrandP4 = grandtotalP4Part1 + grandtotalP4Part2;

                allP4.Text = totalgrandP4.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 4's turn");
            }
        }

        private void P5ones_Click(object sender, RoutedEventArgs e)
        {
            int p5ones = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler51 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP51 = Int32.Parse(tbP5ones.Text);

            if (playernumbercount.Text == "5")
            {
                if (MyInt1 == 1)
                {
                    p5ones = p5ones + 1;
                    counterP51++;
                }

                if (MyInt2 == 1)
                {
                    p5ones = p5ones + 1;
                    counterP51++;
                }

                if (MyInt3 == 1)
                {
                    p5ones = p5ones + 1;
                    counterP51++;
                }

                if (MyInt4 == 1)
                {
                    p5ones = p5ones + 1;
                    counterP51++;
                }

                if (MyInt5 == 1)
                {
                    p5ones = p5ones + 1;
                    counterP51++;
                }
                P5ones.Content = p5ones.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler51 = P5ones.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter5 = counterP51 + counterP52 + counterP53 + counterP54 + counterP55 + counterP56;

                totalP5.Text = counter5.ToString();

                if (counter5 >= 63 && stopP5 < 1)
                {
                    bonusP5 = 35;
                    P5bonus.Text = "35";
                    P5bonus.Background = Brushes.Green;

                    counter5 = counter5 + bonusP5;
                    grandtotalP5.Text = counter5.ToString();
                    stopP5++;
                }
                else if (counter5 >= 63 && stopP5 >= 1)
                {
                    P5bonus.Background = Brushes.Green;
                    counter5 = counter5 + bonusP5;
                    grandtotalP5.Text = counter5.ToString();
                }
                else
                {
                    grandtotalP5.Text = totalP5.Text;
                }

                totalP5part2.Text = grandtotalP5.Text;

                grandtotalP5Part1 = Int32.Parse(totalP5part1.Text);
                grandtotalP5Part2 = Int32.Parse(totalP5part2.Text);
                totalgrandP5 = grandtotalP5Part1 + grandtotalP5Part2;

                allP5.Text = totalgrandP5.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 5's turn");
            }
        }

        private void P5twos_Click(object sender, RoutedEventArgs e)
        {
            int p5twos = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler52 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP52 = Int32.Parse(tbP5twos.Text);

            if (playernumbercount.Text == "5")
            {
                if (MyInt1 == 2)
                {
                    p5twos = p5twos + 2;
                    counterP52 = counterP52 + 2;
                }

                if (MyInt2 == 2)
                {
                    p5twos = p5twos + 2;
                    counterP52 = counterP52 + 2;
                }

                if (MyInt3 == 2)
                {
                    p5twos = p5twos + 2;
                    counterP52 = counterP52 + 2;
                }

                if (MyInt4 == 2)
                {
                    p5twos = p5twos + 2;
                    counterP52 = counterP52 + 2;
                }

                if (MyInt5 == 2)
                {
                    p5twos = p5twos + 2;
                    counterP52 = counterP52 + 2;
                }
                P5twos.Content = p5twos.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler52 = P5twos.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter5 = counterP51 + counterP52 + counterP53 + counterP54 + counterP55 + counterP56;

                totalP5.Text = counter5.ToString();

                if (counter5 >= 63 && stopP5 < 1)
                {
                    bonusP5 = 35;
                    P5bonus.Text = "35";
                    P5bonus.Background = Brushes.Green;

                    counter5 = counter5 + bonusP5;
                    grandtotalP5.Text = counter5.ToString();
                    stopP5++;
                }
                else if (counter5 >= 63 && stopP5 >= 1)
                {
                    P5bonus.Background = Brushes.Green;
                    counter5 = counter5 + bonusP5;
                    grandtotalP5.Text = counter5.ToString();
                }
                else
                {
                    grandtotalP5.Text = totalP5.Text;
                }

                totalP5part2.Text = grandtotalP5.Text;

                grandtotalP5Part1 = Int32.Parse(totalP5part1.Text);
                grandtotalP5Part2 = Int32.Parse(totalP5part2.Text);
                totalgrandP5 = grandtotalP5Part1 + grandtotalP5Part2;

                allP5.Text = totalgrandP5.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 5's turn");
            }
        }

        private void P5threes_Click(object sender, RoutedEventArgs e)
        {
            int p5threes = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler53 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP53 = Int32.Parse(tbP5threes.Text);

            if (playernumbercount.Text == "5")
            {
                if (MyInt1 == 3)
                {
                    p5threes = p5threes + 3;
                    counterP53 = counterP53 + 3;
                }

                if (MyInt2 == 3)
                {
                    p5threes = p5threes + 3;
                    counterP53 = counterP53 + 3;
                }

                if (MyInt3 == 3)
                {
                    p5threes = p5threes + 3;
                    counterP53 = counterP53 + 3;
                }

                if (MyInt4 == 3)
                {
                    p5threes = p5threes + 3;
                    counterP53 = counterP53 + 3;
                }

                if (MyInt5 == 3)
                {
                    p5threes = p5threes + 3;
                    counterP53 = counterP53 + 3;
                }
                P5threes.Content = p5threes.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler53 = P5threes.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter5 = counterP51 + counterP52 + counterP53 + counterP54 + counterP55 + counterP56;

                totalP5.Text = counter5.ToString();

                if (counter5 >= 63 && stopP5 < 1)
                {
                    bonusP5 = 35;
                    P5bonus.Text = "35";
                    P5bonus.Background = Brushes.Green;

                    counter5 = counter5 + bonusP5;
                    grandtotalP5.Text = counter5.ToString();
                    stopP5++;
                }
                else if (counter5 >= 63 && stopP5 >= 1)
                {
                    P5bonus.Background = Brushes.Green;
                    counter5 = counter5 + bonusP5;
                    grandtotalP5.Text = counter5.ToString();
                }
                else
                {
                    grandtotalP5.Text = totalP5.Text;
                }

                totalP5part2.Text = grandtotalP5.Text;

                grandtotalP5Part1 = Int32.Parse(totalP5part1.Text);
                grandtotalP5Part2 = Int32.Parse(totalP5part2.Text);
                totalgrandP5 = grandtotalP5Part1 + grandtotalP5Part2;

                allP5.Text = totalgrandP5.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 5's turn");
            }
        }

        private void P5fours_Click(object sender, RoutedEventArgs e)
        {
            int p5fours = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler54 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP54 = Int32.Parse(tbP5fours.Text);

            if (playernumbercount.Text == "5")
            {
                if (MyInt1 == 4)
                {
                    p5fours = p5fours + 4;
                    counterP54 = counterP54 + 4;
                }

                if (MyInt2 == 4)
                {
                    p5fours = p5fours + 4;
                    counterP54 = counterP54 + 4;
                }

                if (MyInt3 == 4)
                {
                    p5fours = p5fours + 4;
                    counterP54 = counterP54 + 4;
                }

                if (MyInt4 == 4)
                {
                    p5fours = p5fours + 4;
                    counterP54 = counterP54 + 4;
                }

                if (MyInt5 == 4)
                {
                    p5fours = p5fours + 4;
                    counterP54 = counterP54 + 4;
                }
                P5fours.Content = p5fours.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler54 = P5fours.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter5 = counterP51 + counterP52 + counterP53 + counterP54 + counterP55 + counterP56;

                totalP5.Text = counter5.ToString();

                if (counter5 >= 63 && stopP5 < 1)
                {
                    bonusP5 = 35;
                    P5bonus.Text = "35";
                    P5bonus.Background = Brushes.Green;

                    counter5 = counter5 + bonusP5;
                    grandtotalP5.Text = counter5.ToString();
                    stopP5++;
                }
                else if (counter5 >= 63 && stopP5 >= 1)
                {
                    P5bonus.Background = Brushes.Green;
                    counter5 = counter5 + bonusP5;
                    grandtotalP5.Text = counter5.ToString();
                }
                else
                {
                    grandtotalP5.Text = totalP5.Text;
                }

                totalP5part2.Text = grandtotalP5.Text;

                grandtotalP5Part1 = Int32.Parse(totalP5part1.Text);
                grandtotalP5Part2 = Int32.Parse(totalP5part2.Text);
                totalgrandP5 = grandtotalP5Part1 + grandtotalP5Part2;

                allP5.Text = totalgrandP5.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 5's turn");
            }
        }

        private void P5fives_Click(object sender, RoutedEventArgs e)
        {
            int p5fives = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler55 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP55 = Int32.Parse(tbP5fives.Text);

            if (playernumbercount.Text == "5")
            {
                if (MyInt1 == 5)
                {
                    p5fives = p5fives + 5;
                    counterP55 = counterP55 + 5;
                }

                if (MyInt2 == 5)
                {
                    p5fives = p5fives + 5;
                    counterP55 = counterP55 + 5;
                }

                if (MyInt3 == 5)
                {
                    p5fives = p5fives + 5;
                    counterP55 = counterP55 + 5;
                }

                if (MyInt4 == 5)
                {
                    p5fives = p5fives + 5;
                    counterP55 = counterP55 + 5;
                }

                if (MyInt5 == 5)
                {
                    p5fives = p5fives + 5;
                    counterP55 = counterP55 + 5;
                }
                P5fives.Content = p5fives.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler55 = P5fives.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter5 = counterP51 + counterP52 + counterP53 + counterP54 + counterP55 + counterP56;

                totalP5.Text = counter5.ToString();

                if (counter5 >= 63 && stopP5 < 1)
                {
                    bonusP5 = 35;
                    P5bonus.Text = "35";
                    P5bonus.Background = Brushes.Green;

                    counter5 = counter5 + bonusP5;
                    grandtotalP5.Text = counter5.ToString();
                    stopP5++;
                }
                else if (counter5 >= 63 && stopP5 >= 1)
                {
                    P5bonus.Background = Brushes.Green;
                    counter5 = counter5 + bonusP5;
                    grandtotalP5.Text = counter5.ToString();
                }
                else
                {
                    grandtotalP5.Text = totalP5.Text;
                }

                totalP5part2.Text = grandtotalP5.Text;

                grandtotalP5Part1 = Int32.Parse(totalP5part1.Text);
                grandtotalP5Part2 = Int32.Parse(totalP5part2.Text);
                totalgrandP5 = grandtotalP5Part1 + grandtotalP5Part2;

                allP5.Text = totalgrandP5.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 5's turn");
            }
        }

        private void P5sixes_Click(object sender, RoutedEventArgs e)
        {
            int p5sixes = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler56 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP56 = Int32.Parse(tbP5sixes.Text);

            if (playernumbercount.Text == "5")
            {
                if (MyInt1 == 6)
                {
                    p5sixes = p5sixes + 6;
                    counterP56 = counterP56 + 6;
                }

                if (MyInt2 == 6)
                {
                    p5sixes = p5sixes + 6;
                    counterP56 = counterP56 + 6;
                }

                if (MyInt3 == 6)
                {
                    p5sixes = p5sixes + 6;
                    counterP56 = counterP56 + 6;
                }

                if (MyInt4 == 6)
                {
                    p5sixes = p5sixes + 6;
                    counterP56 = counterP56 + 6;
                }

                if (MyInt5 == 6)
                {
                    p5sixes = p5sixes + 6;
                    counterP56 = counterP56 + 6;
                }
                P5sixes.Content = p5sixes.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler56 = P5sixes.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter5 = counterP51 + counterP52 + counterP53 + counterP54 + counterP55 + counterP56;

                totalP5.Text = counter5.ToString();

                if (counter5 >= 63 && stopP5 < 1)
                {
                    bonusP5 = 35;
                    P5bonus.Text = "35";
                    P5bonus.Background = Brushes.Green;

                    counter5 = counter5 + bonusP5;
                    grandtotalP5.Text = counter5.ToString();
                    stopP5++;
                }
                else if (counter5 >= 63 && stopP5 >= 1)
                {
                    P5bonus.Background = Brushes.Green;
                    counter5 = counter5 + bonusP5;
                    grandtotalP5.Text = counter5.ToString();
                }
                else
                {
                    grandtotalP5.Text = totalP5.Text;
                }

                totalP5part2.Text = grandtotalP5.Text;

                grandtotalP5Part1 = Int32.Parse(totalP5part1.Text);
                grandtotalP5Part2 = Int32.Parse(totalP5part2.Text);
                totalgrandP5 = grandtotalP5Part1 + grandtotalP5Part2;

                allP5.Text = totalgrandP5.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 5's turn");
            }
        }

        private void P6ones_Click(object sender, RoutedEventArgs e)
        {
            int p6ones = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler61 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP61 = Int32.Parse(tbP6ones.Text);

            if (playernumbercount.Text == "6")
            {
                if (MyInt1 == 1)
                {
                    p6ones = p6ones + 1;
                    counterP61++;
                }

                if (MyInt2 == 1)
                {
                    p6ones = p6ones + 1;
                    counterP61++;
                }

                if (MyInt3 == 1)
                {
                    p6ones = p6ones + 1;
                    counterP61++;
                }

                if (MyInt4 == 1)
                {
                    p6ones = p6ones + 1;
                    counterP61++;
                }

                if (MyInt5 == 1)
                {
                    p6ones = p6ones + 1;
                    counterP61++;
                }
                P6ones.Content = p6ones.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler61 = P6ones.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter6 = counterP61 + counterP62 + counterP63 + counterP64 + counterP65 + counterP66;

                totalP6.Text = counter6.ToString();

                if (counter6 >= 63 && stopP6 < 1)
                {
                    bonusP6 = 35;
                    P6bonus.Text = "35";
                    P6bonus.Background = Brushes.Green;

                    counter6 = counter6 + bonusP6;
                    grandtotalP6.Text = counter6.ToString();
                    stopP6++;
                }
                else if (counter6 >= 63 && stopP6 >= 1)
                {
                    P6bonus.Background = Brushes.Green;
                    counter6 = counter6 + bonusP6;
                    grandtotalP6.Text = counter6.ToString();
                }
                else
                {
                    grandtotalP6.Text = totalP6.Text;
                }

                totalP6part2.Text = grandtotalP6.Text;

                grandtotalP6Part1 = Int32.Parse(totalP6part1.Text);
                grandtotalP6Part2 = Int32.Parse(totalP6part2.Text);
                totalgrandP6 = grandtotalP6Part1 + grandtotalP6Part2;

                allP6.Text = totalgrandP6.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 6's turn");
            }
        }

        private void P6twos_Click(object sender, RoutedEventArgs e)
        {
            int p6twos = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler62 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP62 = Int32.Parse(tbP6twos.Text);

            if (playernumbercount.Text == "6")
            {
                if (MyInt1 == 2)
                {
                    p6twos = p6twos + 2;
                    counterP62 = counterP62 + 2;
                }

                if (MyInt2 == 2)
                {
                    p6twos = p6twos + 2;
                    counterP62 = counterP62 + 2;
                }

                if (MyInt3 == 2)
                {
                    p6twos = p6twos + 2;
                    counterP62 = counterP62 + 2;
                }

                if (MyInt4 == 2)
                {
                    p6twos = p6twos + 2;
                    counterP62 = counterP62 + 2;
                }

                if (MyInt5 == 2)
                {
                    p6twos = p6twos + 2;
                    counterP62 = counterP62 + 2;
                }
                P6twos.Content = p6twos.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler62 = P6twos.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter6 = counterP61 + counterP62 + counterP63 + counterP64 + counterP65 + counterP66;

                totalP6.Text = counter6.ToString();

                if (counter6 >= 63 && stopP6 < 1)
                {
                    bonusP6 = 35;
                    P6bonus.Text = "35";
                    P6bonus.Background = Brushes.Green;

                    counter6 = counter6 + bonusP6;
                    grandtotalP6.Text = counter6.ToString();
                    stopP6++;
                }
                else if (counter6 >= 63 && stopP6 >= 1)
                {
                    P6bonus.Background = Brushes.Green;
                    counter6 = counter6 + bonusP6;
                    grandtotalP6.Text = counter6.ToString();
                }
                else
                {
                    grandtotalP6.Text = totalP6.Text;
                }

                totalP6part2.Text = grandtotalP6.Text;

                grandtotalP6Part1 = Int32.Parse(totalP6part1.Text);
                grandtotalP6Part2 = Int32.Parse(totalP6part2.Text);
                totalgrandP6 = grandtotalP6Part1 + grandtotalP6Part2;

                allP6.Text = totalgrandP6.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 6's turn");
            }
        }

        private void P6threes_Click(object sender, RoutedEventArgs e)
        {
            int p6threes = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler63 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP63 = Int32.Parse(tbP6threes.Text);

            if (playernumbercount.Text == "6")
            {
                if (MyInt1 == 3)
                {
                    p6threes = p6threes + 3;
                    counterP63 = counterP63 + 3;
                }

                if (MyInt2 == 3)
                {
                    p6threes = p6threes + 3;
                    counterP63 = counterP63 + 3;
                }

                if (MyInt3 == 3)
                {
                    p6threes = p6threes + 3;
                    counterP63 = counterP63 + 3;
                }

                if (MyInt4 == 3)
                {
                    p6threes = p6threes + 3;
                    counterP63 = counterP63 + 3;
                }

                if (MyInt5 == 3)
                {
                    p6threes = p6threes + 3;
                    counterP63 = counterP63 + 3;
                }
                P6threes.Content = p6threes.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler63 = P6threes.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter6 = counterP61 + counterP62 + counterP63 + counterP64 + counterP65 + counterP66;

                totalP6.Text = counter6.ToString();

                if (counter6 >= 63 && stopP6 < 1)
                {
                    bonusP6 = 35;
                    P6bonus.Text = "35";
                    P6bonus.Background = Brushes.Green;

                    counter6 = counter6 + bonusP6;
                    grandtotalP6.Text = counter6.ToString();
                    stopP6++;
                }
                else if (counter6 >= 63 && stopP6 >= 1)
                {
                    P6bonus.Background = Brushes.Green;
                    counter6 = counter6 + bonusP6;
                    grandtotalP6.Text = counter6.ToString();
                }
                else
                {
                    grandtotalP6.Text = totalP6.Text;
                }

                totalP6part2.Text = grandtotalP6.Text;

                grandtotalP6Part1 = Int32.Parse(totalP6part1.Text);
                grandtotalP6Part2 = Int32.Parse(totalP6part2.Text);
                totalgrandP6 = grandtotalP6Part1 + grandtotalP6Part2;

                allP6.Text = totalgrandP6.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 6's turn");
            }
        }

        private void P6fours_Click(object sender, RoutedEventArgs e)
        {
            int p6fours = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler64 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP64 = Int32.Parse(tbP6fours.Text);

            if (playernumbercount.Text == "6")
            {
                if (MyInt1 == 4)
                {
                    p6fours = p6fours + 4;
                    counterP64 = counterP64 + 4;
                }

                if (MyInt2 == 4)
                {
                    p6fours = p6fours + 4;
                    counterP64 = counterP64 + 4;
                }

                if (MyInt3 == 4)
                {
                    p6fours = p6fours + 4;
                    counterP64 = counterP64 + 4;
                }

                if (MyInt4 == 4)
                {
                    p6fours = p6fours + 4;
                    counterP64 = counterP64 + 4;
                }

                if (MyInt5 == 4)
                {
                    p6fours = p6fours + 4;
                    counterP64 = counterP64 + 4;
                }
                P6fours.Content = p6fours.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler64 = P6fours.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter6 = counterP61 + counterP62 + counterP63 + counterP64 + counterP65 + counterP66;

                totalP6.Text = counter6.ToString();

                if (counter6 >= 63 && stopP6 < 1)
                {
                    bonusP6 = 35;
                    P6bonus.Text = "35";
                    P6bonus.Background = Brushes.Green;

                    counter6 = counter6 + bonusP6;
                    grandtotalP6.Text = counter6.ToString();
                    stopP6++;
                }
                else if (counter6 >= 63 && stopP6 >= 1)
                {
                    P6bonus.Background = Brushes.Green;
                    counter6 = counter6 + bonusP6;
                    grandtotalP6.Text = counter6.ToString();
                }
                else
                {
                    grandtotalP6.Text = totalP6.Text;
                }

                totalP6part2.Text = grandtotalP6.Text;

                grandtotalP6Part1 = Int32.Parse(totalP6part1.Text);
                grandtotalP6Part2 = Int32.Parse(totalP6part2.Text);
                totalgrandP6 = grandtotalP6Part1 + grandtotalP6Part2;

                allP6.Text = totalgrandP6.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 6's turn");
            }
        }

        private void P6fives_Click(object sender, RoutedEventArgs e)
        {
            int p6fives = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler65 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP65 = Int32.Parse(tbP6fives.Text);

            if (playernumbercount.Text == "6")
            {
                if (MyInt1 == 5)
                {
                    p6fives = p6fives + 5;
                    counterP65 = counterP65 + 5;
                }

                if (MyInt2 == 5)
                {
                    p6fives = p6fives + 5;
                    counterP65 = counterP65 + 5;
                }

                if (MyInt3 == 5)
                {
                    p6fives = p6fives + 5;
                    counterP65 = counterP65 + 5;
                }

                if (MyInt4 == 5)
                {
                    p6fives = p6fives + 5;
                    counterP65 = counterP65 + 5;
                }

                if (MyInt5 == 5)
                {
                    p6fives = p6fives + 5;
                    counterP65 = counterP65 + 5;
                }
                P6fives.Content = p6fives.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler65 = P6fives.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter6 = counterP61 + counterP62 + counterP63 + counterP64 + counterP65 + counterP66;

                totalP6.Text = counter6.ToString();

                if (counter6 >= 63 && stopP6 < 1)
                {
                    bonusP6 = 35;
                    P6bonus.Text = "35";
                    P6bonus.Background = Brushes.Green;

                    counter6 = counter6 + bonusP6;
                    grandtotalP6.Text = counter6.ToString();
                    stopP6++;
                }
                else if (counter6 >= 63 && stopP6 >= 1)
                {
                    P6bonus.Background = Brushes.Green;
                    counter6 = counter6 + bonusP6;
                    grandtotalP6.Text = counter6.ToString();
                }
                else
                {
                    grandtotalP6.Text = totalP6.Text;
                }

                totalP6part2.Text = grandtotalP6.Text;

                grandtotalP6Part1 = Int32.Parse(totalP6part1.Text);
                grandtotalP6Part2 = Int32.Parse(totalP6part2.Text);
                totalgrandP6 = grandtotalP6Part1 + grandtotalP6Part2;

                allP6.Text = totalgrandP6.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 6's turn");
            }
        }

        private void P6sixes_Click(object sender, RoutedEventArgs e)
        {
            int p6sixes = 0;

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (speler66 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterP66 = Int32.Parse(tbP6sixes.Text);

            if (playernumbercount.Text == "6")
            {
                if (MyInt1 == 6)
                {
                    p6sixes = p6sixes + 6;
                    counterP66 = counterP66 + 6;
                }

                if (MyInt2 == 6)
                {
                    p6sixes = p6sixes + 6;
                    counterP66 = counterP66 + 6;
                }

                if (MyInt3 == 6)
                {
                    p6sixes = p6sixes + 6;
                    counterP66 = counterP66 + 6;
                }

                if (MyInt4 == 6)
                {
                    p6sixes = p6sixes + 6;
                    counterP66 = counterP66 + 6;
                }

                if (MyInt5 == 6)
                {
                    p6sixes = p6sixes + 6;
                    counterP66 = counterP66 + 6;
                }
                P6sixes.Content = p6sixes.ToString();
                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                speler66 = P6sixes.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                counter6 = counterP61 + counterP62 + counterP63 + counterP64 + counterP65 + counterP66;

                totalP6.Text = counter6.ToString();

                if (counter6 >= 63 && stopP6 < 1)
                {
                    bonusP6 = 35;
                    P6bonus.Text = "35";
                    P6bonus.Background = Brushes.Green;

                    counter6 = counter6 + bonusP6;
                    grandtotalP6.Text = counter6.ToString();
                    stopP6++;
                }
                else if (counter6 >= 63 && stopP6 >= 1)
                {
                    P6bonus.Background = Brushes.Green;
                    counter6 = counter6 + bonusP6;
                    grandtotalP6.Text = counter6.ToString();
                }
                else
                {
                    grandtotalP6.Text = totalP6.Text;
                }

                totalP6part2.Text = grandtotalP6.Text;

                grandtotalP6Part1 = Int32.Parse(totalP6part1.Text);
                grandtotalP6Part2 = Int32.Parse(totalP6part2.Text);
                totalgrandP6 = grandtotalP6Part1 + grandtotalP6Part2;

                allP6.Text = totalgrandP6.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 6's turn");
            }
        }

        private void ChanceP1_Click(object sender, RoutedEventArgs e)
        {
            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (spelerchange1 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterchangeP1 = Int32.Parse(tbChanceP1.Text);

            if (playernumbercount.Text == "1")
            {
                counterchangeP1 = MyInt1 + MyInt2 + MyInt3 + MyInt4 + MyInt5;
                ChanceP1.Content = counterchangeP1.ToString();

                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                tbChanceP1.Text = counterchangeP1.ToString();
                spelerchange1 = ChanceP1.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                helft2P1 = helft2P1 + counterchangeP1; // En hier tel je dan ook nog de andere waardes uit part 2 op
                totalP1part1.Text = helft2P1.ToString();

                int i;

                i = Int32.Parse(totalP1part2.Text);

                totalgrandP1 = i + helft2P1;
                allP1.Text = totalgrandP1.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 1's turn");
            }
        }

        private void ChanceP2_Click(object sender, RoutedEventArgs e)
        {
            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (spelerchange2 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterchangeP2 = Int32.Parse(tbChanceP2.Text);

            if (playernumbercount.Text == "2")
            {
                counterchangeP2 = MyInt1 + MyInt2 + MyInt3 + MyInt4 + MyInt5;
                ChanceP2.Content = counterchangeP2.ToString();

                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                tbChanceP2.Text = counterchangeP2.ToString();
                spelerchange2 = ChanceP2.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                helft2P2 = helft2P2 + counterchangeP2; // En hier tel je dan ook nog de andere waardes uit part 2 op
                totalP2part1.Text = helft2P2.ToString();

                int i;

                i = Int32.Parse(totalP2part2.Text);

                totalgrandP2 = i + helft2P2;
                allP2.Text = totalgrandP2.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 2's turn");
            }
        }

        private void ChanceP3_Click(object sender, RoutedEventArgs e)
        {
            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (spelerchange3 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterchangeP3 = Int32.Parse(tbChanceP3.Text);

            if (playernumbercount.Text == "3")
            {
                counterchangeP3 = MyInt1 + MyInt2 + MyInt3 + MyInt4 + MyInt5;
                ChanceP3.Content = counterchangeP3.ToString();

                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                tbChanceP3.Text = counterchangeP3.ToString();
                spelerchange3 = ChanceP3.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                helft2P3 = helft2P3 + counterchangeP3; // En hier tel je dan ook nog de andere waardes uit part 2 op
                totalP3part1.Text = helft2P3.ToString();

                int i;

                i = Int32.Parse(totalP3part2.Text);

                totalgrandP3 = i + helft2P3;
                allP3.Text = totalgrandP3.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 3's turn");
            }
        }

        private void ChanceP4_Click(object sender, RoutedEventArgs e)
        {
            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (spelerchange4 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterchangeP4 = Int32.Parse(tbChanceP4.Text);

            if (playernumbercount.Text == "4")
            {
                counterchangeP4 = MyInt1 + MyInt2 + MyInt3 + MyInt4 + MyInt5;
                ChanceP4.Content = counterchangeP4.ToString();

                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                tbChanceP4.Text = counterchangeP4.ToString();
                spelerchange4 = ChanceP4.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                helft2P4 = helft2P4 + counterchangeP4; // En hier tel je dan ook nog de andere waardes uit part 2 op
                totalP4part1.Text = helft2P4.ToString();

                int i;

                i = Int32.Parse(totalP4part2.Text);

                totalgrandP4 = i + helft2P4;
                allP4.Text = totalgrandP4.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 4's turn");
            }
        }

        private void ChanceP5_Click(object sender, RoutedEventArgs e)
        {
            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (spelerchange5 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterchangeP5 = Int32.Parse(tbChanceP5.Text);

            if (playernumbercount.Text == "5")
            {
                counterchangeP5 = MyInt1 + MyInt2 + MyInt3 + MyInt4 + MyInt5;
                ChanceP5.Content = counterchangeP5.ToString();

                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                tbChanceP5.Text = counterchangeP5.ToString();
                spelerchange5 = ChanceP5.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                helft2P5 = helft2P5 + counterchangeP5; // En hier tel je dan ook nog de andere waardes uit part 2 op
                totalP5part1.Text = helft2P5.ToString();

                int i;

                i = Int32.Parse(totalP5part2.Text);

                totalgrandP5 = i + helft2P5;
                allP5.Text = totalgrandP5.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 5's turn");
            }
        }

        private void ChanceP6_Click(object sender, RoutedEventArgs e)
        {
            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (spelerchange6 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            counterchangeP6 = Int32.Parse(tbChanceP6.Text);

            if (playernumbercount.Text == "6")
            {
                counterchangeP6 = MyInt1 + MyInt2 + MyInt3 + MyInt4 + MyInt5;
                ChanceP6.Content = counterchangeP6.ToString();

                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                tbChanceP6.Text = counterchangeP6.ToString();
                spelerchange6 = ChanceP6.Content.ToString();

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                helft2P6 = helft2P6 + counterchangeP6; // En hier tel je dan ook nog de andere waardes uit part 2 op
                totalP6part1.Text = helft2P6.ToString();

                int i;

                i = Int32.Parse(totalP6part2.Text);

                totalgrandP6 = i + helft2P6;
                allP6.Text = totalgrandP6.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 6's turn");
            }
        }

        private void TopscoreP1_Click(object sender, RoutedEventArgs e)
        {

            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (spelertop1 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            if (playernumbercount.Text == "1")
            {
                if(MyInt1 == MyInt2 && MyInt2 == MyInt3 && MyInt3 == MyInt4 && MyInt4 == MyInt5)
                {
                    TopscoreP1.Content = "50";
                    tbTopscoreP1.Text = "50";
                }
                else
                {
                    TopscoreP1.Content = "0";
                    tbTopscoreP1.Text = "0";
                }

                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                spelertop1 = "Hoi";
                topscoreP1 = Int32.Parse(tbTopscoreP1.Text);

                helft2P1 = helft2P1 + topscoreP1; // En hier tel je dan ook nog de andere waardes uit part 2 op
                totalP1part1.Text = helft2P1.ToString();

                int i;

                i = Int32.Parse(totalP1part2.Text);

                totalgrandP1 = i + helft2P1;
                allP1.Text = totalgrandP1.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 1's turn");
            }
        }

        private void TopscoreP2_Click(object sender, RoutedEventArgs e)
        {
            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (spelertop2 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            if (playernumbercount.Text == "2")
            {
                if (MyInt1 == MyInt2 && MyInt2 == MyInt3 && MyInt3 == MyInt4 && MyInt4 == MyInt5)
                {
                    TopscoreP2.Content = "50";
                    tbTopscoreP2.Text = "50";
                }
                else
                {
                    TopscoreP2.Content = "0";
                    tbTopscoreP2.Text = "0";
                }

                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                spelertop2 = "Hoi";
                topscoreP2 = Int32.Parse(tbTopscoreP2.Text);

                helft2P2 = helft2P2 + topscoreP2; // En hier tel je dan ook nog de andere waardes uit part 2 op
                totalP2part1.Text = helft2P2.ToString();

                int i;

                i = Int32.Parse(totalP2part2.Text);

                totalgrandP2 = i + helft2P2;
                allP2.Text = totalgrandP2.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 2's turn");
            }
        }

        private void TopscoreP3_Click(object sender, RoutedEventArgs e)
        {
            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (spelertop3 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            if (playernumbercount.Text == "3")
            {
                if (MyInt1 == MyInt2 && MyInt2 == MyInt3 && MyInt3 == MyInt4 && MyInt4 == MyInt5)
                {
                    TopscoreP3.Content = "50";
                    tbTopscoreP3.Text = "50";
                }
                else
                {
                    TopscoreP3.Content = "0";
                    tbTopscoreP3.Text = "0";
                }

                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                spelertop3 = "Hoi";
                topscoreP3 = Int32.Parse(tbTopscoreP3.Text);

                helft2P3 = helft2P3 + topscoreP3; // En hier tel je dan ook nog de andere waardes uit part 2 op
                totalP3part1.Text = helft2P3.ToString();

                int i;

                i = Int32.Parse(totalP3part2.Text);

                totalgrandP3 = i + helft2P3;
                allP3.Text = totalgrandP3.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 3's turn");
            }
        }

        private void TopscoreP4_Click(object sender, RoutedEventArgs e)
        {
            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (spelertop4 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            if (playernumbercount.Text == "4")
            {
                if (MyInt1 == MyInt2 && MyInt2 == MyInt3 && MyInt3 == MyInt4 && MyInt4 == MyInt5)
                {
                    TopscoreP4.Content = "50";
                    tbTopscoreP4.Text = "50";
                }
                else
                {
                    TopscoreP4.Content = "0";
                    tbTopscoreP4.Text = "0";
                }

                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                spelertop4 = "Hoi";
                topscoreP4 = Int32.Parse(tbTopscoreP4.Text);

                helft2P4 = helft2P4 + topscoreP4; // En hier tel je dan ook nog de andere waardes uit part 2 op
                totalP4part1.Text = helft2P4.ToString();

                int i;

                i = Int32.Parse(totalP4part2.Text);

                totalgrandP4 = i + helft2P4;
                allP4.Text = totalgrandP4.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 4's turn");
            }
        }

        private void TopscoreP5_Click(object sender, RoutedEventArgs e)
        {
            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (spelertop5 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            if (playernumbercount.Text == "5")
            {
                if (MyInt1 == MyInt2 && MyInt2 == MyInt3 && MyInt3 == MyInt4 && MyInt4 == MyInt5)
                {
                    TopscoreP5.Content = "50";
                    tbTopscoreP5.Text = "50";
                }
                else
                {
                    TopscoreP5.Content = "0";
                    tbTopscoreP5.Text = "0";
                }

                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                spelertop5 = "Hoi";
                topscoreP5 = Int32.Parse(tbTopscoreP5.Text);

                helft2P5 = helft2P5 + topscoreP5; // En hier tel je dan ook nog de andere waardes uit part 2 op
                totalP5part1.Text = helft2P5.ToString();

                int i;

                i = Int32.Parse(totalP5part2.Text);

                totalgrandP5 = i + helft2P5;
                allP5.Text = totalgrandP5.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 5's turn");
            }
        }

        private void TopscoreP6_Click(object sender, RoutedEventArgs e)
        {
            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (spelertop6 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            if (playernumbercount.Text == "6")
            {
                if (MyInt1 == MyInt2 && MyInt2 == MyInt3 && MyInt3 == MyInt4 && MyInt4 == MyInt5)
                {
                    TopscoreP6.Content = "50";
                    tbTopscoreP6.Text = "50";
                }
                else
                {
                    TopscoreP6.Content = "0";
                    tbTopscoreP6.Text = "0";
                }

                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                spelertop6 = "Hoi";
                topscoreP6 = Int32.Parse(tbTopscoreP6.Text);

                helft2P6 = helft2P6 + topscoreP6; // En hier tel je dan ook nog de andere waardes uit part 2 op
                totalP6part1.Text = helft2P6.ToString();

                int i;

                i = Int32.Parse(totalP6part2.Text);

                totalgrandP6 = i + helft2P6;
                allP6.Text = totalgrandP6.ToString();

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 6's turn");
            }
        }

        private void ThreeofakindP1_Click(object sender, RoutedEventArgs e)
        {
            if (playernumbercount.Text == "1")
            {
                if (aantalwerpen.Text == "Roll")
                {
                    MessageBox.Show("Please roll dice at least once");
                    return;
                }

                if (threeofakindP1 != "")
                {
                    MessageBox.Show("You already filled in this field");
                    return;
                }

                int calculate3ofakind = 0;

                if (MyInt1 == 1)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 1)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 1)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 1)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 1)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP1();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 2)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 2)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 2)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 2)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 2)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP1();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 3)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 3)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 3)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 3)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 3)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP1();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 4)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 4)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 4)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 4)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 4)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP1();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 5)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 5)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 5)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 5)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 5)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP1();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 6)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 6)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 6)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 6)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 6)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP1();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                threeofakindP1 = "0";
                ThreeofakindP1.Content = "0";

                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                helft2P1 = helft2P1 + calculate3ofakind;
                totalP1part1.Text = helft2P1.ToString();

                int i;

                i = Int32.Parse(totalP1part2.Text);

                totalgrandP1 = i + helft2P1;
                allP1.Text = totalgrandP1.ToString();

                threeofakindP1 = "hoi";

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 1's turn");
            }
            
        }

        private void calculatepoints3ofakindP1()
        {
            int totaal = MyInt1 + MyInt2 + MyInt3 + MyInt4 + MyInt5;

            helft2P1 = helft2P1 + totaal;
            totalP1part1.Text = helft2P1.ToString();

            int i;

            i = Int32.Parse(totalP1part2.Text);

            totalgrandP1 = i + helft2P1;
            allP1.Text = totalgrandP1.ToString();

            ThreeofakindP1.Content = totaal.ToString();

            aantalwerpen.Text = "Roll";
            SetAllElementsInvisible1();
            SetAllElementsInvisible2();
            SetAllElementsInvisible3();
            SetAllElementsInvisible4();
            SetAllElementsInvisible5();
            counttheplayers();

            checkbox1.Background = Brushes.Red;
            checkbox2.Background = Brushes.Red;
            checkbox3.Background = Brushes.Red;
            checkbox4.Background = Brushes.Red;
            checkbox5.Background = Brushes.Red;

            MyInt1 = 0;
            MyInt2 = 0;
            MyInt3 = 0;
            MyInt4 = 0;
            MyInt5 = 0;

            threeofakindP1 = "hoi";

            endcounter--;

            if (endcounter < 1)
            {
                endGame();
            }
        }

        private void ThreeofakindP2_Click(object sender, RoutedEventArgs e)
        {
            if (playernumbercount.Text == "2")
            {
                if (aantalwerpen.Text == "Roll")
                {
                    MessageBox.Show("Please roll dice at least once");
                    return;
                }

                if (threeofakindP2 != "")
                {
                    MessageBox.Show("You already filled in this field");
                    return;
                }

                int calculate3ofakind = 0;

                if (MyInt1 == 1)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 1)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 1)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 1)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 1)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP2();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 2)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 2)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 2)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 2)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 2)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP2();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 3)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 3)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 3)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 3)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 3)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP2();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 4)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 4)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 4)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 4)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 4)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP2();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 5)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 5)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 5)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 5)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 5)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP2();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 6)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 6)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 6)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 6)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 6)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP2();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                threeofakindP2 = "0";
                ThreeofakindP2.Content = "0";

                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                helft2P2 = helft2P2 + calculate3ofakind;
                totalP2part1.Text = helft2P2.ToString();

                int i;

                i = Int32.Parse(totalP2part2.Text);

                totalgrandP2 = i + helft2P2;
                allP2.Text = totalgrandP2.ToString();

                threeofakindP2 = "hoi";

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 2's turn");
            }
        }

        private void calculatepoints3ofakindP2()
        {
            int totaal = MyInt1 + MyInt2 + MyInt3 + MyInt4 + MyInt5;

            helft2P2 = helft2P2 + totaal;
            totalP2part1.Text = helft2P2.ToString();

            int i;

            i = Int32.Parse(totalP2part2.Text);

            totalgrandP2 = i + helft2P2;
            allP2.Text = totalgrandP2.ToString();

            ThreeofakindP2.Content = totaal.ToString();

            aantalwerpen.Text = "Roll";
            SetAllElementsInvisible1();
            SetAllElementsInvisible2();
            SetAllElementsInvisible3();
            SetAllElementsInvisible4();
            SetAllElementsInvisible5();
            counttheplayers();

            checkbox1.Background = Brushes.Red;
            checkbox2.Background = Brushes.Red;
            checkbox3.Background = Brushes.Red;
            checkbox4.Background = Brushes.Red;
            checkbox5.Background = Brushes.Red;

            MyInt1 = 0;
            MyInt2 = 0;
            MyInt3 = 0;
            MyInt4 = 0;
            MyInt5 = 0;

            endcounter--;

            if (endcounter < 1)
            {
                endGame();
            }
        }

        private void ThreeofakindP3_Click(object sender, RoutedEventArgs e)
        {
            if (playernumbercount.Text == "3")
            {
                if (aantalwerpen.Text == "Roll")
                {
                    MessageBox.Show("Please roll dice at least once");
                    return;
                }

                if (threeofakindP3 != "")
                {
                    MessageBox.Show("You already filled in this field");
                    return;
                }

                int calculate3ofakind = 0;

                if (MyInt1 == 1)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 1)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 1)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 1)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 1)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP3();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 2)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 2)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 2)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 2)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 2)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP3();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 3)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 3)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 3)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 3)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 3)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP3();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 4)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 4)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 4)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 4)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 4)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP3();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 5)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 5)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 5)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 5)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 5)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP3();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 6)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 6)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 6)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 6)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 6)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP3();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                threeofakindP3 = "0";
                ThreeofakindP3.Content = "0";

                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                helft2P3 = helft2P3 + calculate3ofakind;
                totalP3part1.Text = helft2P3.ToString();

                int i;

                i = Int32.Parse(totalP3part2.Text);

                totalgrandP3 = i + helft2P3;
                allP3.Text = totalgrandP3.ToString();

                threeofakindP3 = "hoi";

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 3's turn");
            }
        }

        private void calculatepoints3ofakindP3()
        {
            int totaal = MyInt1 + MyInt2 + MyInt3 + MyInt4 + MyInt5;

            helft2P3 = helft2P3 + totaal;
            totalP3part1.Text = helft2P3.ToString();

            int i;

            i = Int32.Parse(totalP3part2.Text);

            totalgrandP3 = i + helft2P3;
            allP3.Text = totalgrandP3.ToString();

            ThreeofakindP3.Content = totaal.ToString();

            aantalwerpen.Text = "Roll";
            SetAllElementsInvisible1();
            SetAllElementsInvisible2();
            SetAllElementsInvisible3();
            SetAllElementsInvisible4();
            SetAllElementsInvisible5();
            counttheplayers();

            checkbox1.Background = Brushes.Red;
            checkbox2.Background = Brushes.Red;
            checkbox3.Background = Brushes.Red;
            checkbox4.Background = Brushes.Red;
            checkbox5.Background = Brushes.Red;

            MyInt1 = 0;
            MyInt2 = 0;
            MyInt3 = 0;
            MyInt4 = 0;
            MyInt5 = 0;

            endcounter--;

            if (endcounter < 1)
            {
                endGame();
            }
        }

        private void ThreeofakindP4_Click(object sender, RoutedEventArgs e)
        {
            if (playernumbercount.Text == "4")
            {
                if (aantalwerpen.Text == "Roll")
                {
                    MessageBox.Show("Please roll dice at least once");
                    return;
                }

                if (threeofakindP4 != "")
                {
                    MessageBox.Show("You already filled in this field");
                    return;
                }

                int calculate3ofakind = 0;

                if (MyInt1 == 1)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 1)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 1)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 1)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 1)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP4();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 2)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 2)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 2)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 2)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 2)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP4();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 3)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 3)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 3)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 3)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 3)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP4();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 4)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 4)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 4)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 4)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 4)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP4();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 5)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 5)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 5)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 5)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 5)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP4();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 6)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 6)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 6)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 6)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 6)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP4();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                threeofakindP4 = "0";
                ThreeofakindP4.Content = "0";

                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                helft2P4 = helft2P4 + calculate3ofakind;
                totalP4part1.Text = helft2P4.ToString();

                int i;

                i = Int32.Parse(totalP4part2.Text);

                totalgrandP4 = i + helft2P4;
                allP4.Text = totalgrandP4.ToString();

                threeofakindP4 = "hoi";

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 4's turn");
            }
        }

        private void calculatepoints3ofakindP4()
        {
            int totaal = MyInt1 + MyInt2 + MyInt3 + MyInt4 + MyInt5;

            helft2P4 = helft2P4 + totaal;
            totalP4part1.Text = helft2P4.ToString();

            int i;

            i = Int32.Parse(totalP4part2.Text);

            totalgrandP4 = i + helft2P4;
            allP4.Text = totalgrandP4.ToString();

            ThreeofakindP4.Content = totaal.ToString();

            aantalwerpen.Text = "Roll";
            SetAllElementsInvisible1();
            SetAllElementsInvisible2();
            SetAllElementsInvisible3();
            SetAllElementsInvisible4();
            SetAllElementsInvisible5();
            counttheplayers();

            checkbox1.Background = Brushes.Red;
            checkbox2.Background = Brushes.Red;
            checkbox3.Background = Brushes.Red;
            checkbox4.Background = Brushes.Red;
            checkbox5.Background = Brushes.Red;

            MyInt1 = 0;
            MyInt2 = 0;
            MyInt3 = 0;
            MyInt4 = 0;
            MyInt5 = 0;

            endcounter--;

            if (endcounter < 1)
            {
                endGame();
            }
        }

        private void ThreeofakindP5_Click(object sender, RoutedEventArgs e)
        {
            if (playernumbercount.Text == "5")
            {
                if (aantalwerpen.Text == "Roll")
                {
                    MessageBox.Show("Please roll dice at least once");
                    return;
                }

                if (threeofakindP5 != "")
                {
                    MessageBox.Show("You already filled in this field");
                    return;
                }

                int calculate3ofakind = 0;

                if (MyInt1 == 1)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 1)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 1)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 1)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 1)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP5();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 2)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 2)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 2)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 2)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 2)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP5();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 3)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 3)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 3)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 3)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 3)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP5();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 4)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 4)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 4)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 4)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 4)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP5();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 5)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 5)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 5)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 5)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 5)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP5();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 6)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 6)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 6)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 6)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 6)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP5();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                threeofakindP5 = "0";
                ThreeofakindP5.Content = "0";

                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                helft2P5 = helft2P5 + calculate3ofakind;
                totalP5part1.Text = helft2P5.ToString();

                int i;

                i = Int32.Parse(totalP5part2.Text);

                totalgrandP5 = i + helft2P5;
                allP5.Text = totalgrandP5.ToString();

                threeofakindP5 = "hoi";

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 5's turn");
            }
        }

        private void calculatepoints3ofakindP5()
        {
            int totaal = MyInt1 + MyInt2 + MyInt3 + MyInt4 + MyInt5;

            helft2P5 = helft2P5 + totaal;
            totalP5part1.Text = helft2P5.ToString();

            int i;

            i = Int32.Parse(totalP5part2.Text);

            totalgrandP5 = i + helft2P5;
            allP5.Text = totalgrandP5.ToString();

            ThreeofakindP5.Content = totaal.ToString();

            aantalwerpen.Text = "Roll";
            SetAllElementsInvisible1();
            SetAllElementsInvisible2();
            SetAllElementsInvisible3();
            SetAllElementsInvisible4();
            SetAllElementsInvisible5();
            counttheplayers();

            checkbox1.Background = Brushes.Red;
            checkbox2.Background = Brushes.Red;
            checkbox3.Background = Brushes.Red;
            checkbox4.Background = Brushes.Red;
            checkbox5.Background = Brushes.Red;

            MyInt1 = 0;
            MyInt2 = 0;
            MyInt3 = 0;
            MyInt4 = 0;
            MyInt5 = 0;

            endcounter--;

            if (endcounter < 1)
            {
                endGame();
            }
        }

        private void ThreeofakindP6_Click(object sender, RoutedEventArgs e)
        {
            if (playernumbercount.Text == "6")
            {
                if (aantalwerpen.Text == "Roll")
                {
                    MessageBox.Show("Please roll dice at least once");
                    return;
                }

                if (threeofakindP6 != "")
                {
                    MessageBox.Show("You already filled in this field");
                    return;
                }

                int calculate3ofakind = 0;

                if (MyInt1 == 1)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 1)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 1)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 1)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 1)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP6();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 2)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 2)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 2)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 2)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 2)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP6();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 3)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 3)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 3)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 3)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 3)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP6();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 4)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 4)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 4)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 4)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 4)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP6();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 5)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 5)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 5)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 5)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 5)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP6();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 6)
                {
                    calculate3ofakind++;
                }
                if (MyInt2 == 6)
                {
                    calculate3ofakind++;
                }
                if (MyInt3 == 6)
                {
                    calculate3ofakind++;
                }
                if (MyInt4 == 6)
                {
                    calculate3ofakind++;
                }
                if (MyInt5 == 6)
                {
                    calculate3ofakind++;
                }

                if (calculate3ofakind >= 3)
                {
                    calculatepoints3ofakindP6();
                    return;
                }
                else
                {
                    calculate3ofakind = 0;
                }

                threeofakindP6 = "0";
                ThreeofakindP6.Content = "0";

                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                helft2P6 = helft2P6 + calculate3ofakind;
                totalP6part1.Text = helft2P6.ToString();

                int i;

                i = Int32.Parse(totalP6part2.Text);

                totalgrandP6 = i + helft2P6;
                allP6.Text = totalgrandP6.ToString();

                threeofakindP6 = "hoi";

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 6's turn");
            }
        }

        private void calculatepoints3ofakindP6()
        {
            int totaal = MyInt1 + MyInt2 + MyInt3 + MyInt4 + MyInt5;

            helft2P6 = helft2P6 + totaal;
            totalP2part1.Text = helft2P6.ToString();

            int i;

            i = Int32.Parse(totalP6part2.Text);

            totalgrandP6 = i + helft2P6;
            allP6.Text = totalgrandP6.ToString();

            ThreeofakindP6.Content = totaal.ToString();

            aantalwerpen.Text = "Roll";
            SetAllElementsInvisible1();
            SetAllElementsInvisible2();
            SetAllElementsInvisible3();
            SetAllElementsInvisible4();
            SetAllElementsInvisible5();
            counttheplayers();

            checkbox1.Background = Brushes.Red;
            checkbox2.Background = Brushes.Red;
            checkbox3.Background = Brushes.Red;
            checkbox4.Background = Brushes.Red;
            checkbox5.Background = Brushes.Red;

            MyInt1 = 0;
            MyInt2 = 0;
            MyInt3 = 0;
            MyInt4 = 0;
            MyInt5 = 0;

            endcounter--;

            if (endcounter < 1)
            {
                endGame();
            }
        }

        private void FourofakindP1_Click(object sender, RoutedEventArgs e)
        {
            if (playernumbercount.Text == "1")
            {
                if (aantalwerpen.Text == "Roll")
                {
                    MessageBox.Show("Please roll dice at least once");
                    return;
                }

                if (fourofakindP1 != "")
                {
                    MessageBox.Show("You already filled in this field");
                    return;
                }

                int calculate4ofakind = 0;

                if (MyInt1 == 1)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 1)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 1)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 1)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 1)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP1();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 2)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 2)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 2)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 2)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 2)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP1();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 3)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 3)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 3)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 3)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 3)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP1();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 4)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 4)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 4)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 4)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 4)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP1();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 5)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 5)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 5)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 5)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 5)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP1();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 6)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 6)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 6)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 6)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 6)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP1();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                fourofakindP1 = "0";
                FourofakindP1.Content = "0";

                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                helft2P1 = helft2P1 + calculate4ofakind;
                totalP1part1.Text = helft2P1.ToString();

                int i;

                i = Int32.Parse(totalP1part2.Text);

                totalgrandP1 = i + helft2P1;
                allP1.Text = totalgrandP1.ToString();

                fourofakindP1 = "hoi";

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 1's turn");
            }
        }

        private void calculatepoints4ofakindP1()
        {
            int totaal = MyInt1 + MyInt2 + MyInt3 + MyInt4 + MyInt5;

            helft2P1 = helft2P1 + totaal;
            totalP1part1.Text = helft2P1.ToString();

            int i;

            i = Int32.Parse(totalP1part2.Text);

            totalgrandP1 = i + helft2P1;
            allP1.Text = totalgrandP1.ToString();

            FourofakindP1.Content = totaal.ToString();

            aantalwerpen.Text = "Roll";
            SetAllElementsInvisible1();
            SetAllElementsInvisible2();
            SetAllElementsInvisible3();
            SetAllElementsInvisible4();
            SetAllElementsInvisible5();
            counttheplayers();

            checkbox1.Background = Brushes.Red;
            checkbox2.Background = Brushes.Red;
            checkbox3.Background = Brushes.Red;
            checkbox4.Background = Brushes.Red;
            checkbox5.Background = Brushes.Red;

            MyInt1 = 0;
            MyInt2 = 0;
            MyInt3 = 0;
            MyInt4 = 0;
            MyInt5 = 0;

            fourofakindP1 = "hoi";

            endcounter--;

            if (endcounter < 1)
            {
                endGame();
            }
        }

        private void FourofakindP2_Click(object sender, RoutedEventArgs e)
        {
            if (playernumbercount.Text == "2")
            {
                if (aantalwerpen.Text == "Roll")
                {
                    MessageBox.Show("Please roll dice at least once");
                    return;
                }

                if (fourofakindP2 != "")
                {
                    MessageBox.Show("You already filled in this field");
                    return;
                }

                int calculate4ofakind = 0;

                if (MyInt1 == 1)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 1)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 1)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 1)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 1)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP2();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 2)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 2)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 2)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 2)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 2)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP2();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 3)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 3)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 3)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 3)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 3)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP2();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 4)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 4)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 4)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 4)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 4)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP2();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 5)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 5)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 5)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 5)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 5)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP2();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 6)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 6)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 6)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 6)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 6)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP2();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                fourofakindP2 = "0";
                FourofakindP2.Content = "0";

                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                helft2P2 = helft2P2 + calculate4ofakind;
                totalP2part1.Text = helft2P2.ToString();

                int i;

                i = Int32.Parse(totalP2part2.Text);

                totalgrandP2 = i + helft2P2;
                allP2.Text = totalgrandP2.ToString();

                fourofakindP2 = "hoi";

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 2's turn");
            }
        }

        private void calculatepoints4ofakindP2()
        {
            int totaal = MyInt1 + MyInt2 + MyInt3 + MyInt4 + MyInt5;

            helft2P2 = helft2P2 + totaal;
            totalP2part1.Text = helft2P2.ToString();

            int i;

            i = Int32.Parse(totalP2part2.Text);

            totalgrandP2 = i + helft2P2;
            allP2.Text = totalgrandP2.ToString();

            FourofakindP2.Content = totaal.ToString();

            aantalwerpen.Text = "Roll";
            SetAllElementsInvisible1();
            SetAllElementsInvisible2();
            SetAllElementsInvisible3();
            SetAllElementsInvisible4();
            SetAllElementsInvisible5();
            counttheplayers();

            checkbox1.Background = Brushes.Red;
            checkbox2.Background = Brushes.Red;
            checkbox3.Background = Brushes.Red;
            checkbox4.Background = Brushes.Red;
            checkbox5.Background = Brushes.Red;

            MyInt1 = 0;
            MyInt2 = 0;
            MyInt3 = 0;
            MyInt4 = 0;
            MyInt5 = 0;

            fourofakindP2 = "hoi";

            endcounter--;

            if (endcounter < 1)
            {
                endGame();
            }
        }

        private void FourofakindP3_Click(object sender, RoutedEventArgs e)
        {
            if (playernumbercount.Text == "3")
            {
                if (aantalwerpen.Text == "Roll")
                {
                    MessageBox.Show("Please roll dice at least once");
                    return;
                }

                if (fourofakindP3 != "")
                {
                    MessageBox.Show("You already filled in this field");
                    return;
                }

                int calculate4ofakind = 0;

                if (MyInt1 == 1)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 1)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 1)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 1)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 1)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP3();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 2)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 2)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 2)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 2)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 2)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP3();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 3)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 3)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 3)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 3)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 3)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP3();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 4)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 4)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 4)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 4)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 4)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP3();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 5)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 5)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 5)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 5)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 5)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP3();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 6)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 6)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 6)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 6)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 6)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP3();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                fourofakindP3 = "0";
                FourofakindP3.Content = "0";

                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                helft2P3 = helft2P3 + calculate4ofakind;
                totalP3part1.Text = helft2P3.ToString();

                int i;

                i = Int32.Parse(totalP3part2.Text);

                totalgrandP3 = i + helft2P3;
                allP3.Text = totalgrandP3.ToString();

                fourofakindP3 = "hoi";

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 3's turn");
            }
        }

        private void calculatepoints4ofakindP3()
        {
            int totaal = MyInt1 + MyInt2 + MyInt3 + MyInt4 + MyInt5;

            helft2P3 = helft2P3 + totaal;
            totalP3part1.Text = helft2P3.ToString();

            int i;

            i = Int32.Parse(totalP3part2.Text);

            totalgrandP3 = i + helft2P3;
            allP3.Text = totalgrandP3.ToString();

            FourofakindP3.Content = totaal.ToString();

            aantalwerpen.Text = "Roll";
            SetAllElementsInvisible1();
            SetAllElementsInvisible2();
            SetAllElementsInvisible3();
            SetAllElementsInvisible4();
            SetAllElementsInvisible5();
            counttheplayers();

            checkbox1.Background = Brushes.Red;
            checkbox2.Background = Brushes.Red;
            checkbox3.Background = Brushes.Red;
            checkbox4.Background = Brushes.Red;
            checkbox5.Background = Brushes.Red;

            MyInt1 = 0;
            MyInt2 = 0;
            MyInt3 = 0;
            MyInt4 = 0;
            MyInt5 = 0;

            fourofakindP3 = "hoi";

            endcounter--;

            if (endcounter < 1)
            {
                endGame();
            }
        }

        private void FourofakindP4_Click(object sender, RoutedEventArgs e)
        {
            if (playernumbercount.Text == "4")
            {
                if (aantalwerpen.Text == "Roll")
                {
                    MessageBox.Show("Please roll dice at least once");
                    return;
                }

                if (fourofakindP4 != "")
                {
                    MessageBox.Show("You already filled in this field");
                    return;
                }

                int calculate4ofakind = 0;

                if (MyInt1 == 1)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 1)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 1)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 1)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 1)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP4();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 2)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 2)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 2)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 2)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 2)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP4();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 3)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 3)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 3)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 3)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 3)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP4();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 4)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 4)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 4)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 4)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 4)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP4();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 5)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 5)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 5)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 5)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 5)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP4();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 6)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 6)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 6)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 6)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 6)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP4();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                fourofakindP4 = "0";
                FourofakindP4.Content = "0";

                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                helft2P4 = helft2P4 + calculate4ofakind;
                totalP4part1.Text = helft2P4.ToString();

                int i;

                i = Int32.Parse(totalP4part2.Text);

                totalgrandP4 = i + helft2P4;
                allP4.Text = totalgrandP4.ToString();

                fourofakindP4 = "hoi";

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 4's turn");
            }
        }

        private void calculatepoints4ofakindP4()
        {
            int totaal = MyInt1 + MyInt2 + MyInt3 + MyInt4 + MyInt5;

            helft2P4 = helft2P4 + totaal;
            totalP4part1.Text = helft2P4.ToString();

            int i;

            i = Int32.Parse(totalP4part2.Text);

            totalgrandP4 = i + helft2P4;
            allP4.Text = totalgrandP4.ToString();

            FourofakindP4.Content = totaal.ToString();

            aantalwerpen.Text = "Roll";
            SetAllElementsInvisible1();
            SetAllElementsInvisible2();
            SetAllElementsInvisible3();
            SetAllElementsInvisible4();
            SetAllElementsInvisible5();
            counttheplayers();

            checkbox1.Background = Brushes.Red;
            checkbox2.Background = Brushes.Red;
            checkbox3.Background = Brushes.Red;
            checkbox4.Background = Brushes.Red;
            checkbox5.Background = Brushes.Red;

            MyInt1 = 0;
            MyInt2 = 0;
            MyInt3 = 0;
            MyInt4 = 0;
            MyInt5 = 0;

            fourofakindP4 = "hoi";

            endcounter--;

            if (endcounter < 1)
            {
                endGame();
            }
        }

        private void FourofakindP5_Click(object sender, RoutedEventArgs e)
        {
            if (playernumbercount.Text == "5")
            {
                if (aantalwerpen.Text == "Roll")
                {
                    MessageBox.Show("Please roll dice at least once");
                    return;
                }

                if (fourofakindP5 != "")
                {
                    MessageBox.Show("You already filled in this field");
                    return;
                }

                int calculate4ofakind = 0;

                if (MyInt1 == 1)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 1)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 1)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 1)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 1)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP5();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 2)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 2)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 2)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 2)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 2)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP5();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 3)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 3)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 3)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 3)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 3)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP5();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 4)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 4)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 4)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 4)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 4)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP5();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 5)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 5)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 5)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 5)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 5)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP5();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 6)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 6)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 6)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 6)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 6)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP5();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                fourofakindP5 = "0";
                FourofakindP5.Content = "0";

                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                helft2P5 = helft2P5 + calculate4ofakind;
                totalP5part1.Text = helft2P5.ToString();

                int i;

                i = Int32.Parse(totalP5part2.Text);

                totalgrandP5 = i + helft2P5;
                allP5.Text = totalgrandP5.ToString();

                fourofakindP5 = "hoi";

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 5's turn");
            }
        }

        private void calculatepoints4ofakindP5()
        {
            int totaal = MyInt1 + MyInt2 + MyInt3 + MyInt4 + MyInt5;

            helft2P5 = helft2P5 + totaal;
            totalP5part1.Text = helft2P5.ToString();

            int i;

            i = Int32.Parse(totalP5part2.Text);

            totalgrandP5 = i + helft2P5;
            allP5.Text = totalgrandP5.ToString();

            FourofakindP5.Content = totaal.ToString();

            aantalwerpen.Text = "Roll";
            SetAllElementsInvisible1();
            SetAllElementsInvisible2();
            SetAllElementsInvisible3();
            SetAllElementsInvisible4();
            SetAllElementsInvisible5();
            counttheplayers();

            checkbox1.Background = Brushes.Red;
            checkbox2.Background = Brushes.Red;
            checkbox3.Background = Brushes.Red;
            checkbox4.Background = Brushes.Red;
            checkbox5.Background = Brushes.Red;

            MyInt1 = 0;
            MyInt2 = 0;
            MyInt3 = 0;
            MyInt4 = 0;
            MyInt5 = 0;

            fourofakindP5 = "hoi";

            endcounter--;

            if (endcounter < 1)
            {
                endGame();
            }
        }

        private void FourofakindP6_Click(object sender, RoutedEventArgs e)
        {
            if (playernumbercount.Text == "6")
            {
                if (aantalwerpen.Text == "Roll")
                {
                    MessageBox.Show("Please roll dice at least once");
                    return;
                }

                if (fourofakindP6 != "")
                {
                    MessageBox.Show("You already filled in this field");
                    return;
                }

                int calculate4ofakind = 0;

                if (MyInt1 == 1)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 1)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 1)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 1)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 1)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP6();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 2)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 2)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 2)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 2)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 2)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP6();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 3)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 3)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 3)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 3)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 3)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP6();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 4)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 4)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 4)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 4)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 4)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP6();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 5)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 5)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 5)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 5)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 5)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP6();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                //NEXT

                if (MyInt1 == 6)
                {
                    calculate4ofakind++;
                }
                if (MyInt2 == 6)
                {
                    calculate4ofakind++;
                }
                if (MyInt3 == 6)
                {
                    calculate4ofakind++;
                }
                if (MyInt4 == 6)
                {
                    calculate4ofakind++;
                }
                if (MyInt5 == 6)
                {
                    calculate4ofakind++;
                }

                if (calculate4ofakind >= 4)
                {
                    calculatepoints4ofakindP6();
                    return;
                }
                else
                {
                    calculate4ofakind = 0;
                }

                fourofakindP6 = "0";
                FourofakindP6.Content = "0";

                aantalwerpen.Text = "Roll";
                SetAllElementsInvisible1();
                SetAllElementsInvisible2();
                SetAllElementsInvisible3();
                SetAllElementsInvisible4();
                SetAllElementsInvisible5();
                counttheplayers();

                checkbox1.Background = Brushes.Red;
                checkbox2.Background = Brushes.Red;
                checkbox3.Background = Brushes.Red;
                checkbox4.Background = Brushes.Red;
                checkbox5.Background = Brushes.Red;

                MyInt1 = 0;
                MyInt2 = 0;
                MyInt3 = 0;
                MyInt4 = 0;
                MyInt5 = 0;

                helft2P6 = helft2P6 + calculate4ofakind;
                totalP6part1.Text = helft2P6.ToString();

                int i;

                i = Int32.Parse(totalP6part2.Text);

                totalgrandP6 = i + helft2P6;
                allP6.Text = totalgrandP6.ToString();

                fourofakindP6 = "hoi";

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 6's turn");
            }
        }

        private void calculatepoints4ofakindP6()
        {
            int totaal = MyInt1 + MyInt2 + MyInt3 + MyInt4 + MyInt5;

            helft2P6 = helft2P6 + totaal;
            totalP6part1.Text = helft2P6.ToString();

            int i;

            i = Int32.Parse(totalP6part2.Text);

            totalgrandP6 = i + helft2P6;
            allP6.Text = totalgrandP6.ToString();

            FourofakindP6.Content = totaal.ToString();

            aantalwerpen.Text = "Roll";
            SetAllElementsInvisible1();
            SetAllElementsInvisible2();
            SetAllElementsInvisible3();
            SetAllElementsInvisible4();
            SetAllElementsInvisible5();
            counttheplayers();

            checkbox1.Background = Brushes.Red;
            checkbox2.Background = Brushes.Red;
            checkbox3.Background = Brushes.Red;
            checkbox4.Background = Brushes.Red;
            checkbox5.Background = Brushes.Red;

            MyInt1 = 0;
            MyInt2 = 0;
            MyInt3 = 0;
            MyInt4 = 0;
            MyInt5 = 0;

            fourofakindP6 = "hoi";

            endcounter--;

            if (endcounter < 1)
            {
                endGame();
            }
        }

        private void LargestraightP1_Click(object sender, RoutedEventArgs e)
        {
            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (largestraatP1 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            if (playernumbercount.Text == "1")
            {
                int counterls = 0;

                if (MyInt1 == 2 || MyInt2 == 2 || MyInt3 == 2 || MyInt4 == 2 || MyInt5 == 2)
                {
                    counterls++;
                }
                else
                {
                    LargestraightP1.Content = "0";
                    tbLargestraightP1.Text = "0";
                    calculatelsP1();
                    return;
                }

                if (MyInt1 == 3 || MyInt2 == 3 || MyInt3 == 3 || MyInt4 == 3 || MyInt5 == 3)
                {
                    counterls++;
                }
                else
                {
                    LargestraightP1.Content = "0";
                    tbLargestraightP1.Text = "0";
                    calculatelsP1();
                    return;
                }

                if (MyInt1 == 4 || MyInt2 == 4 || MyInt3 == 4 || MyInt4 == 4 || MyInt5 == 4)
                {
                    counterls++;
                }
                else
                {
                    LargestraightP1.Content = "0";
                    tbLargestraightP1.Text = "0";
                    calculatelsP1();
                    return;
                }

                if (MyInt1 == 5 || MyInt2 == 5 || MyInt3 == 5 || MyInt4 == 5 || MyInt5 == 5)
                {
                    counterls++;
                }
                else
                {
                    LargestraightP1.Content = "0";
                    tbLargestraightP1.Text = "0";
                    calculatelsP1();
                    return;
                }

                if(counterls == 4)
                {
                    if(MyInt1 == 1 || MyInt2 == 1 || MyInt3 == 1 || MyInt4 == 1 || MyInt5 == 1 || MyInt1 == 6 || MyInt2 == 6 || MyInt3 == 6 || MyInt4 == 6 || MyInt5 == 6)
                    {
                        LargestraightP1.Content = "40";
                        tbLargestraightP1.Text = "40";
                        calculatelsP1();
                        return;
                    }
                }
                else
                {
                    LargestraightP1.Content = "0";
                    tbLargestraightP1.Text = "0";
                    calculatelsP1();
                    return;
                }

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }

            }
            else
            {
                MessageBox.Show("It's not player 1's turn");
            }
        }

        private void calculatelsP1()
        {
            aantalwerpen.Text = "Roll";
            SetAllElementsInvisible1();
            SetAllElementsInvisible2();
            SetAllElementsInvisible3();
            SetAllElementsInvisible4();
            SetAllElementsInvisible5();
            counttheplayers();

            checkbox1.Background = Brushes.Red;
            checkbox2.Background = Brushes.Red;
            checkbox3.Background = Brushes.Red;
            checkbox4.Background = Brushes.Red;
            checkbox5.Background = Brushes.Red;

            MyInt1 = 0;
            MyInt2 = 0;
            MyInt3 = 0;
            MyInt4 = 0;
            MyInt5 = 0;

            grotestraatP1 = Int32.Parse(tbLargestraightP1.Text);

            helft2P1 = helft2P1 + grotestraatP1; // En hier tel je dan ook nog de andere waardes uit part 2 op
            totalP1part1.Text = helft2P1.ToString();

            largestraatP1 = "Hoi";

            int i;

            i = Int32.Parse(totalP1part2.Text);

            totalgrandP1 = i + helft2P1;
            allP1.Text = totalgrandP1.ToString();

            endcounter--;

            if (endcounter < 1)
            {
                endGame();
            }
        }

        private void LargestraightP2_Click(object sender, RoutedEventArgs e)
        {
            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (largestraatP2 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            if (playernumbercount.Text == "2")
            {
                int counterls = 0;

                if (MyInt1 == 2 || MyInt2 == 2 || MyInt3 == 2 || MyInt4 == 2 || MyInt5 == 2)
                {
                    counterls++;
                }
                else
                {
                    LargestraightP2.Content = "0";
                    tbLargestraightP2.Text = "0";
                    calculatelsP2();
                    return;
                }

                if (MyInt1 == 3 || MyInt2 == 3 || MyInt3 == 3 || MyInt4 == 3 || MyInt5 == 3)
                {
                    counterls++;
                }
                else
                {
                    LargestraightP2.Content = "0";
                    tbLargestraightP2.Text = "0";
                    calculatelsP2();
                    return;
                }

                if (MyInt1 == 4 || MyInt2 == 4 || MyInt3 == 4 || MyInt4 == 4 || MyInt5 == 4)
                {
                    counterls++;
                }
                else
                {
                    LargestraightP2.Content = "0";
                    tbLargestraightP2.Text = "0";
                    calculatelsP2();
                    return;
                }

                if (MyInt1 == 5 || MyInt2 == 5 || MyInt3 == 5 || MyInt4 == 5 || MyInt5 == 5)
                {
                    counterls++;
                }
                else
                {
                    LargestraightP2.Content = "0";
                    tbLargestraightP2.Text = "0";
                    calculatelsP2();
                    return;
                }

                if (counterls == 4)
                {
                    if (MyInt1 == 1 || MyInt2 == 1 || MyInt3 == 1 || MyInt4 == 1 || MyInt5 == 1 || MyInt1 == 6 || MyInt2 == 6 || MyInt3 == 6 || MyInt4 == 6 || MyInt5 == 6)
                    {
                        LargestraightP2.Content = "40";
                        tbLargestraightP2.Text = "40";
                        calculatelsP2();
                        return;
                    }
                }
                else
                {
                    LargestraightP2.Content = "0";
                    tbLargestraightP2.Text = "0";
                    calculatelsP2();
                    return;
                }

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }

            }
            else
            {
                MessageBox.Show("It's not player 2's turn");
            }
        }

        private void calculatelsP2()
        {
            aantalwerpen.Text = "Roll";
            SetAllElementsInvisible1();
            SetAllElementsInvisible2();
            SetAllElementsInvisible3();
            SetAllElementsInvisible4();
            SetAllElementsInvisible5();
            counttheplayers();

            checkbox1.Background = Brushes.Red;
            checkbox2.Background = Brushes.Red;
            checkbox3.Background = Brushes.Red;
            checkbox4.Background = Brushes.Red;
            checkbox5.Background = Brushes.Red;

            MyInt1 = 0;
            MyInt2 = 0;
            MyInt3 = 0;
            MyInt4 = 0;
            MyInt5 = 0;

            grotestraatP2 = Int32.Parse(tbLargestraightP2.Text);

            helft2P2 = helft2P2 + grotestraatP2; // En hier tel je dan ook nog de andere waardes uit part 2 op
            totalP2part1.Text = helft2P2.ToString();

            largestraatP2 = "Hoi";

            int i;

            i = Int32.Parse(totalP2part2.Text);

            totalgrandP2 = i + helft2P2;
            allP2.Text = totalgrandP2.ToString();

            endcounter--;

            if (endcounter < 1)
            {
                endGame();
            }
        }

        private void LargestraightP3_Click(object sender, RoutedEventArgs e)
        {
            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (largestraatP3 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            if (playernumbercount.Text == "3")
            {
                int counterls = 0;

                if (MyInt1 == 2 || MyInt2 == 2 || MyInt3 == 2 || MyInt4 == 2 || MyInt5 == 2)
                {
                    counterls++;
                }
                else
                {
                    LargestraightP3.Content = "0";
                    tbLargestraightP3.Text = "0";
                    calculatelsP3();
                    return;
                }

                if (MyInt1 == 3 || MyInt2 == 3 || MyInt3 == 3 || MyInt4 == 3 || MyInt5 == 3)
                {
                    counterls++;
                }
                else
                {
                    LargestraightP3.Content = "0";
                    tbLargestraightP3.Text = "0";
                    calculatelsP3();
                    return;
                }

                if (MyInt1 == 4 || MyInt2 == 4 || MyInt3 == 4 || MyInt4 == 4 || MyInt5 == 4)
                {
                    counterls++;
                }
                else
                {
                    LargestraightP3.Content = "0";
                    tbLargestraightP3.Text = "0";
                    calculatelsP3();
                    return;
                }

                if (MyInt1 == 5 || MyInt2 == 5 || MyInt3 == 5 || MyInt4 == 5 || MyInt5 == 5)
                {
                    counterls++;
                }
                else
                {
                    LargestraightP3.Content = "0";
                    tbLargestraightP3.Text = "0";
                    calculatelsP3();
                    return;
                }

                if (counterls == 4)
                {
                    if (MyInt1 == 1 || MyInt2 == 1 || MyInt3 == 1 || MyInt4 == 1 || MyInt5 == 1 || MyInt1 == 6 || MyInt2 == 6 || MyInt3 == 6 || MyInt4 == 6 || MyInt5 == 6)
                    {
                        LargestraightP3.Content = "40";
                        tbLargestraightP3.Text = "40";
                        calculatelsP3();
                        return;
                    }
                }
                else
                {
                    LargestraightP3.Content = "0";
                    tbLargestraightP3.Text = "0";
                    calculatelsP3();
                    return;
                }

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }

            }
            else
            {
                MessageBox.Show("It's not player 3's turn");
            }
        }

        private void calculatelsP3()
        {
            aantalwerpen.Text = "Roll";
            SetAllElementsInvisible1();
            SetAllElementsInvisible2();
            SetAllElementsInvisible3();
            SetAllElementsInvisible4();
            SetAllElementsInvisible5();
            counttheplayers();

            checkbox1.Background = Brushes.Red;
            checkbox2.Background = Brushes.Red;
            checkbox3.Background = Brushes.Red;
            checkbox4.Background = Brushes.Red;
            checkbox5.Background = Brushes.Red;

            MyInt1 = 0;
            MyInt2 = 0;
            MyInt3 = 0;
            MyInt4 = 0;
            MyInt5 = 0;

            grotestraatP3 = Int32.Parse(tbLargestraightP3.Text);

            helft2P3 = helft2P3 + grotestraatP3; // En hier tel je dan ook nog de andere waardes uit part 2 op
            totalP3part1.Text = helft2P3.ToString();

            largestraatP3 = "Hoi";

            int i;

            i = Int32.Parse(totalP3part2.Text);

            totalgrandP3 = i + helft2P3;
            allP3.Text = totalgrandP3.ToString();

            endcounter--;

            if (endcounter < 1)
            {
                endGame();
            }
        }

        private void LargestraightP4_Click(object sender, RoutedEventArgs e)
        {
            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (largestraatP4 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            if (playernumbercount.Text == "4")
            {
                int counterls = 0;

                if (MyInt1 == 2 || MyInt2 == 2 || MyInt3 == 2 || MyInt4 == 2 || MyInt5 == 2)
                {
                    counterls++;
                }
                else
                {
                    LargestraightP4.Content = "0";
                    tbLargestraightP4.Text = "0";
                    calculatelsP4();
                    return;
                }

                if (MyInt1 == 3 || MyInt2 == 3 || MyInt3 == 3 || MyInt4 == 3 || MyInt5 == 3)
                {
                    counterls++;
                }
                else
                {
                    LargestraightP4.Content = "0";
                    tbLargestraightP4.Text = "0";
                    calculatelsP4();
                    return;
                }

                if (MyInt1 == 4 || MyInt2 == 4 || MyInt3 == 4 || MyInt4 == 4 || MyInt5 == 4)
                {
                    counterls++;
                }
                else
                {
                    LargestraightP4.Content = "0";
                    tbLargestraightP4.Text = "0";
                    calculatelsP4();
                    return;
                }

                if (MyInt1 == 5 || MyInt2 == 5 || MyInt3 == 5 || MyInt4 == 5 || MyInt5 == 5)
                {
                    counterls++;
                }
                else
                {
                    LargestraightP4.Content = "0";
                    tbLargestraightP4.Text = "0";
                    calculatelsP4();
                    return;
                }

                if (counterls == 4)
                {
                    if (MyInt1 == 1 || MyInt2 == 1 || MyInt3 == 1 || MyInt4 == 1 || MyInt5 == 1 || MyInt1 == 6 || MyInt2 == 6 || MyInt3 == 6 || MyInt4 == 6 || MyInt5 == 6)
                    {
                        LargestraightP4.Content = "40";
                        tbLargestraightP4.Text = "40";
                        calculatelsP4();
                        return;
                    }
                }
                else
                {
                    LargestraightP4.Content = "0";
                    tbLargestraightP4.Text = "0";
                    calculatelsP4();
                    return;
                }

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }

            }
            else
            {
                MessageBox.Show("It's not player 4's turn");
            }
        }

        private void calculatelsP4()
        {
            aantalwerpen.Text = "Roll";
            SetAllElementsInvisible1();
            SetAllElementsInvisible2();
            SetAllElementsInvisible3();
            SetAllElementsInvisible4();
            SetAllElementsInvisible5();
            counttheplayers();

            checkbox1.Background = Brushes.Red;
            checkbox2.Background = Brushes.Red;
            checkbox3.Background = Brushes.Red;
            checkbox4.Background = Brushes.Red;
            checkbox5.Background = Brushes.Red;

            MyInt1 = 0;
            MyInt2 = 0;
            MyInt3 = 0;
            MyInt4 = 0;
            MyInt5 = 0;

            grotestraatP4 = Int32.Parse(tbLargestraightP4.Text);

            helft2P4 = helft2P4 + grotestraatP4; // En hier tel je dan ook nog de andere waardes uit part 2 op
            totalP4part1.Text = helft2P4.ToString();

            largestraatP4 = "Hoi";

            int i;

            i = Int32.Parse(totalP4part2.Text);

            totalgrandP4 = i + helft2P4;
            allP4.Text = totalgrandP4.ToString();

            endcounter--;

            if (endcounter < 1)
            {
                endGame();
            }
        }

        private void LargestraightP5_Click(object sender, RoutedEventArgs e)
        {
            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (largestraatP5 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            if (playernumbercount.Text == "5")
            {
                int counterls = 0;

                if (MyInt1 == 2 || MyInt2 == 2 || MyInt3 == 2 || MyInt4 == 2 || MyInt5 == 2)
                {
                    counterls++;
                }
                else
                {
                    LargestraightP5.Content = "0";
                    tbLargestraightP5.Text = "0";
                    calculatelsP5();
                    return;
                }

                if (MyInt1 == 3 || MyInt2 == 3 || MyInt3 == 3 || MyInt4 == 3 || MyInt5 == 3)
                {
                    counterls++;
                }
                else
                {
                    LargestraightP5.Content = "0";
                    tbLargestraightP5.Text = "0";
                    calculatelsP5();
                    return;
                }

                if (MyInt1 == 4 || MyInt2 == 4 || MyInt3 == 4 || MyInt4 == 4 || MyInt5 == 4)
                {
                    counterls++;
                }
                else
                {
                    LargestraightP5.Content = "0";
                    tbLargestraightP5.Text = "0";
                    calculatelsP5();
                    return;
                }

                if (MyInt1 == 5 || MyInt2 == 5 || MyInt3 == 5 || MyInt4 == 5 || MyInt5 == 5)
                {
                    counterls++;
                }
                else
                {
                    LargestraightP5.Content = "0";
                    tbLargestraightP5.Text = "0";
                    calculatelsP5();
                    return;
                }

                if (counterls == 4)
                {
                    if (MyInt1 == 1 || MyInt2 == 1 || MyInt3 == 1 || MyInt4 == 1 || MyInt5 == 1 || MyInt1 == 6 || MyInt2 == 6 || MyInt3 == 6 || MyInt4 == 6 || MyInt5 == 6)
                    {
                        LargestraightP5.Content = "40";
                        tbLargestraightP5.Text = "40";
                        calculatelsP5();
                        return;
                    }
                }
                else
                {
                    LargestraightP5.Content = "0";
                    tbLargestraightP5.Text = "0";
                    calculatelsP5();
                    return;
                }

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }

            }
            else
            {
                MessageBox.Show("It's not player 5's turn");
            }
        }

        private void calculatelsP5()
        {
            aantalwerpen.Text = "Roll";
            SetAllElementsInvisible1();
            SetAllElementsInvisible2();
            SetAllElementsInvisible3();
            SetAllElementsInvisible4();
            SetAllElementsInvisible5();
            counttheplayers();

            checkbox1.Background = Brushes.Red;
            checkbox2.Background = Brushes.Red;
            checkbox3.Background = Brushes.Red;
            checkbox4.Background = Brushes.Red;
            checkbox5.Background = Brushes.Red;

            MyInt1 = 0;
            MyInt2 = 0;
            MyInt3 = 0;
            MyInt4 = 0;
            MyInt5 = 0;

            grotestraatP5 = Int32.Parse(tbLargestraightP5.Text);

            helft2P5 = helft2P5 + grotestraatP5; // En hier tel je dan ook nog de andere waardes uit part 2 op
            totalP5part1.Text = helft2P5.ToString();

            largestraatP5 = "Hoi";

            int i;

            i = Int32.Parse(totalP5part2.Text);

            totalgrandP5 = i + helft2P5;
            allP5.Text = totalgrandP5.ToString();

            endcounter--;

            if (endcounter < 1)
            {
                endGame();
            }
        }

        private void LargestraightP6_Click(object sender, RoutedEventArgs e)
        {
            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (largestraatP6 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            if (playernumbercount.Text == "6")
            {
                int counterls = 0;

                if (MyInt1 == 2 || MyInt2 == 2 || MyInt3 == 2 || MyInt4 == 2 || MyInt5 == 2)
                {
                    counterls++;
                }
                else
                {
                    LargestraightP6.Content = "0";
                    tbLargestraightP6.Text = "0";
                    calculatelsP6();
                    return;
                }

                if (MyInt1 == 3 || MyInt2 == 3 || MyInt3 == 3 || MyInt4 == 3 || MyInt5 == 3)
                {
                    counterls++;
                }
                else
                {
                    LargestraightP6.Content = "0";
                    tbLargestraightP6.Text = "0";
                    calculatelsP6();
                    return;
                }

                if (MyInt1 == 4 || MyInt2 == 4 || MyInt3 == 4 || MyInt4 == 4 || MyInt5 == 4)
                {
                    counterls++;
                }
                else
                {
                    LargestraightP6.Content = "0";
                    tbLargestraightP6.Text = "0";
                    calculatelsP6();
                    return;
                }

                if (MyInt1 == 5 || MyInt2 == 5 || MyInt3 == 5 || MyInt4 == 5 || MyInt5 == 5)
                {
                    counterls++;
                }
                else
                {
                    LargestraightP6.Content = "0";
                    tbLargestraightP6.Text = "0";
                    calculatelsP6();
                    return;
                }

                if (counterls == 4)
                {
                    if (MyInt1 == 1 || MyInt2 == 1 || MyInt3 == 1 || MyInt4 == 1 || MyInt5 == 1 || MyInt1 == 6 || MyInt2 == 6 || MyInt3 == 6 || MyInt4 == 6 || MyInt5 == 6)
                    {
                        LargestraightP6.Content = "40";
                        tbLargestraightP6.Text = "40";
                        calculatelsP6();
                        return;
                    }
                }
                else
                {
                    LargestraightP6.Content = "0";
                    tbLargestraightP6.Text = "0";
                    calculatelsP6();
                    return;
                }

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }

            }
            else
            {
                MessageBox.Show("It's not player 6's turn");
            }
        }

        private void calculatelsP6()
        {
            aantalwerpen.Text = "Roll";
            SetAllElementsInvisible1();
            SetAllElementsInvisible2();
            SetAllElementsInvisible3();
            SetAllElementsInvisible4();
            SetAllElementsInvisible5();
            counttheplayers();

            checkbox1.Background = Brushes.Red;
            checkbox2.Background = Brushes.Red;
            checkbox3.Background = Brushes.Red;
            checkbox4.Background = Brushes.Red;
            checkbox5.Background = Brushes.Red;

            MyInt1 = 0;
            MyInt2 = 0;
            MyInt3 = 0;
            MyInt4 = 0;
            MyInt5 = 0;

            grotestraatP6 = Int32.Parse(tbLargestraightP6.Text);

            helft2P6 = helft2P6 + grotestraatP6; // En hier tel je dan ook nog de andere waardes uit part 2 op
            totalP6part1.Text = helft2P6.ToString();

            largestraatP6 = "Hoi";

            int i;

            i = Int32.Parse(totalP6part2.Text);

            totalgrandP6 = i + helft2P6;
            allP6.Text = totalgrandP6.ToString();

            endcounter--;

            if (endcounter < 1)
            {
                endGame();
            }
        }

        private void SmallstraightP1_Click(object sender, RoutedEventArgs e)
        {
            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (smallstraatP1 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            if (playernumbercount.Text == "1")
            {
                int counterss = 0;

                if (MyInt1 == 3 || MyInt2 == 3 || MyInt3 == 3 || MyInt4 == 3 || MyInt5 == 3)
                {
                    counterss++;
                }
                else
                {
                    SmallstraightP1.Content = "0";
                    tbSmallstraightP1.Text = "0";
                    calculatessP1();
                    return;
                }

                if (MyInt1 == 4 || MyInt2 == 4 || MyInt3 == 4 || MyInt4 == 4 || MyInt5 == 4)
                {
                    counterss++;
                }
                else
                {
                    SmallstraightP1.Content = "0";
                    tbSmallstraightP1.Text = "0";
                    calculatessP1();
                    return;
                }

                if(MyInt1 == 1 || MyInt2 == 1 || MyInt3 == 1 || MyInt4 == 1 || MyInt5 == 1)
                {
                    if (MyInt1 == 2 || MyInt2 == 2 || MyInt3 == 2 || MyInt4 == 2 || MyInt5 == 2)
                    {
                        SmallstraightP1.Content = "30";
                        tbSmallstraightP1.Text = "30";
                        calculatessP1();
                        return;
                    }
                    else
                    {
                        //niks
                    }
                }

                if (MyInt1 == 2 || MyInt2 == 2 || MyInt3 == 2 || MyInt4 == 2 || MyInt5 == 2)
                {
                    if (MyInt1 == 5 || MyInt2 == 5 || MyInt3 == 5 || MyInt4 == 5 || MyInt5 == 5)
                    {
                        SmallstraightP1.Content = "30";
                        tbSmallstraightP1.Text = "30";
                        calculatessP1();
                        return;
                    }
                    else
                    {
                        //niks
                    }
                }

                if (MyInt1 == 6 || MyInt2 == 6 || MyInt3 == 6 || MyInt4 == 6 || MyInt5 == 6)
                {
                    if (MyInt1 == 5 || MyInt2 == 5 || MyInt3 == 5 || MyInt4 == 5 || MyInt5 == 5)
                    {
                        SmallstraightP1.Content = "30";
                        tbSmallstraightP1.Text = "30";
                        calculatessP1();
                        return;
                    }
                    else
                    {
                        //niks
                    }
                }
                else
                {
                    SmallstraightP1.Content = "0";
                    tbSmallstraightP1.Text = "0";
                    calculatessP1();
                    return;
                }

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 1's turn");
            }
        }

        private void calculatessP1()
        {
            aantalwerpen.Text = "Roll";
            SetAllElementsInvisible1();
            SetAllElementsInvisible2();
            SetAllElementsInvisible3();
            SetAllElementsInvisible4();
            SetAllElementsInvisible5();
            counttheplayers();

            checkbox1.Background = Brushes.Red;
            checkbox2.Background = Brushes.Red;
            checkbox3.Background = Brushes.Red;
            checkbox4.Background = Brushes.Red;
            checkbox5.Background = Brushes.Red;

            MyInt1 = 0;
            MyInt2 = 0;
            MyInt3 = 0;
            MyInt4 = 0;
            MyInt5 = 0;

            kleinestraatP1 = Int32.Parse(tbSmallstraightP1.Text);

            helft2P1 = helft2P1 + kleinestraatP1; // En hier tel je dan ook nog de andere waardes uit part 2 op
            totalP1part1.Text = helft2P1.ToString();

            smallstraatP1 = "Hoi";

            int i;

            i = Int32.Parse(totalP1part2.Text);

            totalgrandP1 = i + helft2P1;
            allP1.Text = totalgrandP1.ToString();

            endcounter--;

            if (endcounter < 1)
            {
                endGame();
            }
        }

        private void SmallstraightP2_Click(object sender, RoutedEventArgs e)
        {
            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (smallstraatP2 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            if (playernumbercount.Text == "2")
            {
                int counterss = 0;

                if (MyInt1 == 3 || MyInt2 == 3 || MyInt3 == 3 || MyInt4 == 3 || MyInt5 == 3)
                {
                    counterss++;
                }
                else
                {
                    SmallstraightP2.Content = "0";
                    tbSmallstraightP2.Text = "0";
                    calculatessP2();
                    return;
                }

                if (MyInt1 == 4 || MyInt2 == 4 || MyInt3 == 4 || MyInt4 == 4 || MyInt5 == 4)
                {
                    counterss++;
                }
                else
                {
                    SmallstraightP2.Content = "0";
                    tbSmallstraightP2.Text = "0";
                    calculatessP2();
                    return;
                }

                if (MyInt1 == 1 || MyInt2 == 1 || MyInt3 == 1 || MyInt4 == 1 || MyInt5 == 1)
                {
                    if (MyInt1 == 2 || MyInt2 == 2 || MyInt3 == 2 || MyInt4 == 2 || MyInt5 == 2)
                    {
                        SmallstraightP2.Content = "30";
                        tbSmallstraightP2.Text = "30";
                        calculatessP2();
                        return;
                    }
                    else
                    {
                        //niks
                    }
                }

                if (MyInt1 == 2 || MyInt2 == 2 || MyInt3 == 2 || MyInt4 == 2 || MyInt5 == 2)
                {
                    if (MyInt1 == 5 || MyInt2 == 5 || MyInt3 == 5 || MyInt4 == 5 || MyInt5 == 5)
                    {
                        SmallstraightP2.Content = "30";
                        tbSmallstraightP2.Text = "30";
                        calculatessP2();
                        return;
                    }
                    else
                    {
                        //niks
                    }
                }

                if (MyInt1 == 6 || MyInt2 == 6 || MyInt3 == 6 || MyInt4 == 6 || MyInt5 == 6)
                {
                    if (MyInt1 == 5 || MyInt2 == 5 || MyInt3 == 5 || MyInt4 == 5 || MyInt5 == 5)
                    {
                        SmallstraightP2.Content = "30";
                        tbSmallstraightP2.Text = "30";
                        calculatessP2();
                        return;
                    }
                    else
                    {
                        //niks
                    }
                }
                else
                {
                    SmallstraightP2.Content = "0";
                    tbSmallstraightP2.Text = "0";
                    calculatessP2();
                    return;
                }

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }

            }
            else
            {
                MessageBox.Show("It's not player 2's turn");
            }
        }

        private void calculatessP2()
        {
            aantalwerpen.Text = "Roll";
            SetAllElementsInvisible1();
            SetAllElementsInvisible2();
            SetAllElementsInvisible3();
            SetAllElementsInvisible4();
            SetAllElementsInvisible5();
            counttheplayers();

            checkbox1.Background = Brushes.Red;
            checkbox2.Background = Brushes.Red;
            checkbox3.Background = Brushes.Red;
            checkbox4.Background = Brushes.Red;
            checkbox5.Background = Brushes.Red;

            MyInt1 = 0;
            MyInt2 = 0;
            MyInt3 = 0;
            MyInt4 = 0;
            MyInt5 = 0;

            kleinestraatP2 = Int32.Parse(tbSmallstraightP2.Text);

            helft2P2 = helft2P2 + kleinestraatP2; // En hier tel je dan ook nog de andere waardes uit part 2 op
            totalP2part1.Text = helft2P2.ToString();

            smallstraatP2 = "Hoi";

            int i;

            i = Int32.Parse(totalP2part2.Text);

            totalgrandP2 = i + helft2P2;
            allP2.Text = totalgrandP2.ToString();

            endcounter--;

            if (endcounter < 1)
            {
                endGame();
            }
        }

        private void SmallstraightP3_Click(object sender, RoutedEventArgs e)
        {
            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (smallstraatP3 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            if (playernumbercount.Text == "3")
            {
                int counterss = 0;

                if (MyInt1 == 3 || MyInt2 == 3 || MyInt3 == 3 || MyInt4 == 3 || MyInt5 == 3)
                {
                    counterss++;
                }
                else
                {
                    SmallstraightP3.Content = "0";
                    tbSmallstraightP3.Text = "0";
                    calculatessP3();
                    return;
                }

                if (MyInt1 == 4 || MyInt2 == 4 || MyInt3 == 4 || MyInt4 == 4 || MyInt5 == 4)
                {
                    counterss++;
                }
                else
                {
                    SmallstraightP3.Content = "0";
                    tbSmallstraightP3.Text = "0";
                    calculatessP3();
                    return;
                }

                if (MyInt1 == 1 || MyInt2 == 1 || MyInt3 == 1 || MyInt4 == 1 || MyInt5 == 1)
                {
                    if (MyInt1 == 2 || MyInt2 == 2 || MyInt3 == 2 || MyInt4 == 2 || MyInt5 == 2)
                    {
                        SmallstraightP3.Content = "30";
                        tbSmallstraightP3.Text = "30";
                        calculatessP3();
                        return;
                    }
                    else
                    {
                        //niks
                    }
                }

                if (MyInt1 == 2 || MyInt2 == 2 || MyInt3 == 2 || MyInt4 == 2 || MyInt5 == 2)
                {
                    if (MyInt1 == 5 || MyInt2 == 5 || MyInt3 == 5 || MyInt4 == 5 || MyInt5 == 5)
                    {
                        SmallstraightP3.Content = "30";
                        tbSmallstraightP3.Text = "30";
                        calculatessP3();
                        return;
                    }
                    else
                    {
                        //niks
                    }
                }

                if (MyInt1 == 6 || MyInt2 == 6 || MyInt3 == 6 || MyInt4 == 6 || MyInt5 == 6)
                {
                    if (MyInt1 == 5 || MyInt2 == 5 || MyInt3 == 5 || MyInt4 == 5 || MyInt5 == 5)
                    {
                        SmallstraightP3.Content = "30";
                        tbSmallstraightP3.Text = "30";
                        calculatessP3();
                        return;
                    }
                    else
                    {
                        //niks
                    }
                }
                else
                {
                    SmallstraightP3.Content = "0";
                    tbSmallstraightP3.Text = "0";
                    calculatessP3();
                    return;
                }

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 3's turn");
            }
        }

        private void calculatessP3()
        {
            aantalwerpen.Text = "Roll";
            SetAllElementsInvisible1();
            SetAllElementsInvisible2();
            SetAllElementsInvisible3();
            SetAllElementsInvisible4();
            SetAllElementsInvisible5();
            counttheplayers();

            checkbox1.Background = Brushes.Red;
            checkbox2.Background = Brushes.Red;
            checkbox3.Background = Brushes.Red;
            checkbox4.Background = Brushes.Red;
            checkbox5.Background = Brushes.Red;

            MyInt1 = 0;
            MyInt2 = 0;
            MyInt3 = 0;
            MyInt4 = 0;
            MyInt5 = 0;

            kleinestraatP3 = Int32.Parse(tbSmallstraightP3.Text);

            helft2P3 = helft2P3 + kleinestraatP3; // En hier tel je dan ook nog de andere waardes uit part 2 op
            totalP3part1.Text = helft2P3.ToString();

            smallstraatP3 = "Hoi";

            int i;

            i = Int32.Parse(totalP3part2.Text);

            totalgrandP3 = i + helft2P3;
            allP3.Text = totalgrandP3.ToString();

            endcounter--;

            if (endcounter < 1)
            {
                endGame();
            }
        }

        private void SmallstraightP4_Click(object sender, RoutedEventArgs e)
        {
            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (smallstraatP4 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            if (playernumbercount.Text == "4")
            {
                int counterss = 0;

                if (MyInt1 == 3 || MyInt2 == 3 || MyInt3 == 3 || MyInt4 == 3 || MyInt5 == 3)
                {
                    counterss++;
                }
                else
                {
                    SmallstraightP4.Content = "0";
                    tbSmallstraightP4.Text = "0";
                    calculatessP4();
                    return;
                }

                if (MyInt1 == 4 || MyInt2 == 4 || MyInt3 == 4 || MyInt4 == 4 || MyInt5 == 4)
                {
                    counterss++;
                }
                else
                {
                    SmallstraightP4.Content = "0";
                    tbSmallstraightP4.Text = "0";
                    calculatessP4();
                    return;
                }

                if (MyInt1 == 1 || MyInt2 == 1 || MyInt3 == 1 || MyInt4 == 1 || MyInt5 == 1)
                {
                    if (MyInt1 == 2 || MyInt2 == 2 || MyInt3 == 2 || MyInt4 == 2 || MyInt5 == 2)
                    {
                        SmallstraightP4.Content = "30";
                        tbSmallstraightP4.Text = "30";
                        calculatessP4();
                        return;
                    }
                    else
                    {
                        //niks
                    }
                }

                if (MyInt1 == 2 || MyInt2 == 2 || MyInt3 == 2 || MyInt4 == 2 || MyInt5 == 2)
                {
                    if (MyInt1 == 5 || MyInt2 == 5 || MyInt3 == 5 || MyInt4 == 5 || MyInt5 == 5)
                    {
                        SmallstraightP4.Content = "30";
                        tbSmallstraightP4.Text = "30";
                        calculatessP4();
                        return;
                    }
                    else
                    {
                        //niks
                    }
                }

                if (MyInt1 == 6 || MyInt2 == 6 || MyInt3 == 6 || MyInt4 == 6 || MyInt5 == 6)
                {
                    if (MyInt1 == 5 || MyInt2 == 5 || MyInt3 == 5 || MyInt4 == 5 || MyInt5 == 5)
                    {
                        SmallstraightP4.Content = "30";
                        tbSmallstraightP4.Text = "30";
                        calculatessP4();
                        return;
                    }
                    else
                    {
                        //niks
                    }
                }
                else
                {
                    SmallstraightP4.Content = "0";
                    tbSmallstraightP4.Text = "0";
                    calculatessP4();
                    return;
                }

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 4's turn");
            }
        }

        private void calculatessP4()
        {
            aantalwerpen.Text = "Roll";
            SetAllElementsInvisible1();
            SetAllElementsInvisible2();
            SetAllElementsInvisible3();
            SetAllElementsInvisible4();
            SetAllElementsInvisible5();
            counttheplayers();

            checkbox1.Background = Brushes.Red;
            checkbox2.Background = Brushes.Red;
            checkbox3.Background = Brushes.Red;
            checkbox4.Background = Brushes.Red;
            checkbox5.Background = Brushes.Red;

            MyInt1 = 0;
            MyInt2 = 0;
            MyInt3 = 0;
            MyInt4 = 0;
            MyInt5 = 0;

            kleinestraatP4 = Int32.Parse(tbSmallstraightP4.Text);

            helft2P4 = helft2P4 + kleinestraatP4; // En hier tel je dan ook nog de andere waardes uit part 2 op
            totalP4part1.Text = helft2P4.ToString();

            smallstraatP4 = "Hoi";

            int i;

            i = Int32.Parse(totalP4part2.Text);

            totalgrandP4 = i + helft2P4;
            allP4.Text = totalgrandP4.ToString();

            endcounter--;

            if (endcounter < 1)
            {
                endGame();
            }
        }

        private void SmallstraightP5_Click(object sender, RoutedEventArgs e)
        {
            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (smallstraatP5 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            if (playernumbercount.Text == "5")
            {
                int counterss = 0;

                if (MyInt1 == 3 || MyInt2 == 3 || MyInt3 == 3 || MyInt4 == 3 || MyInt5 == 3)
                {
                    counterss++;
                }
                else
                {
                    SmallstraightP5.Content = "0";
                    tbSmallstraightP5.Text = "0";
                    calculatessP5();
                    return;
                }

                if (MyInt1 == 4 || MyInt2 == 4 || MyInt3 == 4 || MyInt4 == 4 || MyInt5 == 4)
                {
                    counterss++;
                }
                else
                {
                    SmallstraightP5.Content = "0";
                    tbSmallstraightP5.Text = "0";
                    calculatessP5();
                    return;
                }

                if (MyInt1 == 1 || MyInt2 == 1 || MyInt3 == 1 || MyInt4 == 1 || MyInt5 == 1)
                {
                    if (MyInt1 == 2 || MyInt2 == 2 || MyInt3 == 2 || MyInt4 == 2 || MyInt5 == 2)
                    {
                        SmallstraightP5.Content = "30";
                        tbSmallstraightP5.Text = "30";
                        calculatessP5();
                        return;
                    }
                    else
                    {
                        //niks
                    }
                }

                if (MyInt1 == 2 || MyInt2 == 2 || MyInt3 == 2 || MyInt4 == 2 || MyInt5 == 2)
                {
                    if (MyInt1 == 5 || MyInt2 == 5 || MyInt3 == 5 || MyInt4 == 5 || MyInt5 == 5)
                    {
                        SmallstraightP5.Content = "30";
                        tbSmallstraightP5.Text = "30";
                        calculatessP5();
                        return;
                    }
                    else
                    {
                        //niks
                    }
                }

                if (MyInt1 == 6 || MyInt2 == 6 || MyInt3 == 6 || MyInt4 == 6 || MyInt5 == 6)
                {
                    if (MyInt1 == 5 || MyInt2 == 5 || MyInt3 == 5 || MyInt4 == 5 || MyInt5 == 5)
                    {
                        SmallstraightP5.Content = "30";
                        tbSmallstraightP5.Text = "30";
                        calculatessP5();
                        return;
                    }
                    else
                    {
                        //niks
                    }
                }
                else
                {
                    SmallstraightP5.Content = "0";
                    tbSmallstraightP5.Text = "0";
                    calculatessP5();
                    return;
                }

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 5's turn");
            }
        }

        private void calculatessP5()
        {
            aantalwerpen.Text = "Roll";
            SetAllElementsInvisible1();
            SetAllElementsInvisible2();
            SetAllElementsInvisible3();
            SetAllElementsInvisible4();
            SetAllElementsInvisible5();
            counttheplayers();

            checkbox1.Background = Brushes.Red;
            checkbox2.Background = Brushes.Red;
            checkbox3.Background = Brushes.Red;
            checkbox4.Background = Brushes.Red;
            checkbox5.Background = Brushes.Red;

            MyInt1 = 0;
            MyInt2 = 0;
            MyInt3 = 0;
            MyInt4 = 0;
            MyInt5 = 0;

            kleinestraatP5 = Int32.Parse(tbSmallstraightP5.Text);

            helft2P5 = helft2P5 + kleinestraatP5; // En hier tel je dan ook nog de andere waardes uit part 2 op
            totalP5part1.Text = helft2P5.ToString();

            smallstraatP5 = "Hoi";

            int i;

            i = Int32.Parse(totalP5part2.Text);

            totalgrandP5 = i + helft2P5;
            allP5.Text = totalgrandP5.ToString();

            endcounter--;

            if (endcounter < 1)
            {
                endGame();
            }
        }

        private void SmallstraightP6_Click(object sender, RoutedEventArgs e)
        {
            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (smallstraatP6 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            if (playernumbercount.Text == "6")
            {
                int counterss = 0;

                if (MyInt1 == 3 || MyInt2 == 3 || MyInt3 == 3 || MyInt4 == 3 || MyInt5 == 3)
                {
                    counterss++;
                }
                else
                {
                    SmallstraightP6.Content = "0";
                    tbSmallstraightP6.Text = "0";
                    calculatessP6();
                    return;
                }

                if (MyInt1 == 4 || MyInt2 == 4 || MyInt3 == 4 || MyInt4 == 4 || MyInt5 == 4)
                {
                    counterss++;
                }
                else
                {
                    SmallstraightP6.Content = "0";
                    tbSmallstraightP6.Text = "0";
                    calculatessP6();
                    return;
                }

                if (MyInt1 == 1 || MyInt2 == 1 || MyInt3 == 1 || MyInt4 == 1 || MyInt5 == 1)
                {
                    if (MyInt1 == 2 || MyInt2 == 2 || MyInt3 == 2 || MyInt4 == 2 || MyInt5 == 2)
                    {
                        SmallstraightP6.Content = "30";
                        tbSmallstraightP6.Text = "30";
                        calculatessP6();
                        return;
                    }
                    else
                    {
                        //niks
                    }
                }

                if (MyInt1 == 2 || MyInt2 == 2 || MyInt3 == 2 || MyInt4 == 2 || MyInt5 == 2)
                {
                    if (MyInt1 == 5 || MyInt2 == 5 || MyInt3 == 5 || MyInt4 == 5 || MyInt5 == 5)
                    {
                        SmallstraightP6.Content = "30";
                        tbSmallstraightP6.Text = "30";
                        calculatessP6();
                        return;
                    }
                    else
                    {
                        //niks
                    }
                }

                if (MyInt1 == 6 || MyInt2 == 6 || MyInt3 == 6 || MyInt4 == 6 || MyInt5 == 6)
                {
                    if (MyInt1 == 5 || MyInt2 == 5 || MyInt3 == 5 || MyInt4 == 5 || MyInt5 == 5)
                    {
                        SmallstraightP6.Content = "30";
                        tbSmallstraightP6.Text = "30";
                        calculatessP6();
                        return;
                    }
                    else
                    {
                        //niks
                    }
                }
                else
                {
                    SmallstraightP6.Content = "0";
                    tbSmallstraightP6.Text = "0";
                    calculatessP6();
                    return;
                }

                endcounter--;

                if (endcounter < 1)
                {
                    endGame();
                }
            }
            else
            {
                MessageBox.Show("It's not player 6's turn");
            }
        }
        private void calculatessP6()
        {
            aantalwerpen.Text = "Roll";
            SetAllElementsInvisible1();
            SetAllElementsInvisible2();
            SetAllElementsInvisible3();
            SetAllElementsInvisible4();
            SetAllElementsInvisible5();
            counttheplayers();

            checkbox1.Background = Brushes.Red;
            checkbox2.Background = Brushes.Red;
            checkbox3.Background = Brushes.Red;
            checkbox4.Background = Brushes.Red;
            checkbox5.Background = Brushes.Red;

            MyInt1 = 0;
            MyInt2 = 0;
            MyInt3 = 0;
            MyInt4 = 0;
            MyInt5 = 0;

            kleinestraatP6 = Int32.Parse(tbSmallstraightP6.Text);

            helft2P6 = helft2P6 + kleinestraatP6; // En hier tel je dan ook nog de andere waardes uit part 2 op
            totalP6part1.Text = helft2P6.ToString();

            smallstraatP6 = "Hoi";

            int i;

            i = Int32.Parse(totalP6part2.Text);

            totalgrandP6 = i + helft2P6;
            allP6.Text = totalgrandP6.ToString();

            endcounter--;

            if (endcounter < 1)
            {
                endGame();
            }
        }

        private void FullhouseP1_Click(object sender, RoutedEventArgs e)
        {
            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (fullhuisP1 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            if (playernumbercount.Text == "1")
            {
                int bereken = 0;
                int counter = 0;
                int test2 = 0;

                if (MyInt1 == 1)
                {
                    counter++;
                }
                if (MyInt2 == 1)
                {
                    counter++;
                }
                if (MyInt3 == 1)
                {
                    counter++;
                }
                if (MyInt4 == 1)
                {
                    counter++;
                }
                if (MyInt5 == 1)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 1;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (MyInt1 == 2)
                {
                    counter++;
                }
                if (MyInt2 == 2)
                {
                    counter++;
                }
                if (MyInt3 == 2)
                {
                    counter++;
                }
                if (MyInt4 == 2)
                {
                    counter++;
                }
                if (MyInt5 == 2)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 2;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (MyInt1 == 3)
                {
                    counter++;
                }
                if (MyInt2 == 3)
                {
                    counter++;
                }
                if (MyInt3 == 3)
                {
                    counter++;
                }
                if (MyInt4 == 3)
                {
                    counter++;
                }
                if (MyInt5 == 3)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 3;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (MyInt1 == 4)
                {
                    counter++;
                }
                if (MyInt2 == 4)
                {
                    counter++;
                }
                if (MyInt3 == 4)
                {
                    counter++;
                }
                if (MyInt4 == 4)
                {
                    counter++;
                }
                if (MyInt5 == 4)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 4;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (MyInt1 == 5)
                {
                    counter++;
                }
                if (MyInt2 == 5)
                {
                    counter++;
                }
                if (MyInt3 == 5)
                {
                    counter++;
                }
                if (MyInt4 == 5)
                {
                    counter++;
                }
                if (MyInt5 == 5)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 5;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (MyInt1 == 6)
                {
                    counter++;
                }
                if (MyInt2 == 6)
                {
                    counter++;
                }
                if (MyInt3 == 6)
                {
                    counter++;
                }
                if (MyInt4 == 6)
                {
                    counter++;
                }
                if (MyInt5 == 6)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 6;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (bereken > 74)
                {
                    bereken = 0;
                    counter = 0;

                    if (MyInt1 == 1 && test2 != 1)
                    {
                        counter++;
                    }
                    if (MyInt2 == 1 && test2 != 1)
                    {
                        counter++;
                    }
                    if (MyInt3 == 1 && test2 != 1)
                    {
                        counter++;
                    }
                    if (MyInt4 == 1 && test2 != 1)
                    {
                        counter++;
                    }
                    if (MyInt5 == 1 && test2 != 1)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (MyInt1 == 2 && test2 != 2)
                    {
                        counter++;
                    }
                    if (MyInt2 == 2 && test2 != 2)
                    {
                        counter++;
                    }
                    if (MyInt3 == 2 && test2 != 2)
                    {
                        counter++;
                    }
                    if (MyInt4 == 2 && test2 != 2)
                    {
                        counter++;
                    }
                    if (MyInt5 == 2 && test2 != 2)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (MyInt1 == 3 && test2 != 3)
                    {
                        counter++;
                    }
                    if (MyInt2 == 3 && test2 != 3)
                    {
                        counter++;
                    }
                    if (MyInt3 == 3 && test2 != 3)
                    {
                        counter++;
                    }
                    if (MyInt4 == 3 && test2 != 3)
                    {
                        counter++;
                    }
                    if (MyInt5 == 3 && test2 != 3)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (MyInt1 == 4 && test2 != 4)
                    {
                        counter++;
                    }
                    if (MyInt2 == 4 && test2 != 4)
                    {
                        counter++;
                    }
                    if (MyInt3 == 4 && test2 != 4)
                    {
                        counter++;
                    }
                    if (MyInt4 == 4 && test2 != 4)
                    {
                        counter++;
                    }
                    if (MyInt5 == 4 && test2 != 4)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (MyInt1 == 5 && test2 != 5)
                    {
                        counter++;
                    }
                    if (MyInt2 == 5 && test2 != 5)
                    {
                        counter++;
                    }
                    if (MyInt3 == 5 && test2 != 5)
                    {
                        counter++;
                    }
                    if (MyInt4 == 5 && test2 != 5)
                    {
                        counter++;
                    }
                    if (MyInt5 == 5 && test2 != 5)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (MyInt1 == 6 && test2 != 6)
                    {
                        counter++;
                    }
                    if (MyInt2 == 6 && test2 != 6)
                    {
                        counter++;
                    }
                    if (MyInt3 == 6 && test2 != 6)
                    {
                        counter++;
                    }
                    if (MyInt4 == 6 && test2 != 6)
                    {
                        counter++;
                    }
                    if (MyInt5 == 6 && test2 != 6)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (bereken > 74)
                    {
                        fullhuisP1 = "25";
                        FullhouseP1.Content = "25";
                        tbFullhouseP1.Text = "25";

                        aantalwerpen.Text = "Roll";
                        SetAllElementsInvisible1();
                        SetAllElementsInvisible2();
                        SetAllElementsInvisible3();
                        SetAllElementsInvisible4();
                        SetAllElementsInvisible5();
                        counttheplayers();

                        checkbox1.Background = Brushes.Red;
                        checkbox2.Background = Brushes.Red;
                        checkbox3.Background = Brushes.Red;
                        checkbox4.Background = Brushes.Red;
                        checkbox5.Background = Brushes.Red;

                        MyInt1 = 0;
                        MyInt2 = 0;
                        MyInt3 = 0;
                        MyInt4 = 0;
                        MyInt5 = 0;

                        fullhouseP1 = Int32.Parse(tbFullhouseP1.Text);

                        helft2P1 = helft2P1 + fullhouseP1; // En hier tel je dan ook nog de andere waardes uit part 2 op
                        totalP1part1.Text = helft2P1.ToString();

                        fullhuisP1 = "Hoi";

                        int i;

                        i = Int32.Parse(totalP1part2.Text);

                        totalgrandP1 = i + helft2P1;
                        allP1.Text = totalgrandP1.ToString();

                        endcounter--;

                        if (endcounter < 1)
                        {
                            endGame();
                        }
                    }
                    else
                    {
                        fullhuisP1 = "0";
                        FullhouseP1.Content = "0";

                        aantalwerpen.Text = "Roll";
                        SetAllElementsInvisible1();
                        SetAllElementsInvisible2();
                        SetAllElementsInvisible3();
                        SetAllElementsInvisible4();
                        SetAllElementsInvisible5();
                        counttheplayers();

                        checkbox1.Background = Brushes.Red;
                        checkbox2.Background = Brushes.Red;
                        checkbox3.Background = Brushes.Red;
                        checkbox4.Background = Brushes.Red;
                        checkbox5.Background = Brushes.Red;

                        MyInt1 = 0;
                        MyInt2 = 0;
                        MyInt3 = 0;
                        MyInt4 = 0;
                        MyInt5 = 0;

                        totalP1part1.Text = helft2P1.ToString();

                        int i;

                        i = Int32.Parse(totalP1part2.Text);

                        totalgrandP1 = i + helft2P1;
                        allP1.Text = totalgrandP1.ToString();

                        endcounter--;

                        if (endcounter < 1)
                        {
                            endGame();
                        }
                    }
                }
                else
                {
                    fullhuisP1 = "0";
                    FullhouseP1.Content = "0";

                    aantalwerpen.Text = "Roll";
                    SetAllElementsInvisible1();
                    SetAllElementsInvisible2();
                    SetAllElementsInvisible3();
                    SetAllElementsInvisible4();
                    SetAllElementsInvisible5();
                    counttheplayers();

                    checkbox1.Background = Brushes.Red;
                    checkbox2.Background = Brushes.Red;
                    checkbox3.Background = Brushes.Red;
                    checkbox4.Background = Brushes.Red;
                    checkbox5.Background = Brushes.Red;

                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;

                    totalP1part1.Text = helft2P1.ToString();

                    int i;

                    i = Int32.Parse(totalP1part2.Text);

                    totalgrandP1 = i + helft2P1;
                    allP1.Text = totalgrandP1.ToString();

                    endcounter--;

                    if (endcounter < 1)
                    {
                        endGame();
                    }
                }
            }
            else
            {
                MessageBox.Show("It's not player 1's turn");
            }
        }

        private void FullhouseP2_Click(object sender, RoutedEventArgs e)
        {
            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (fullhuisP2 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            if (playernumbercount.Text == "2")
            {
                int bereken = 0;
                int counter = 0;
                int test2 = 0;

                if (MyInt1 == 1)
                {
                    counter++;
                }
                if (MyInt2 == 1)
                {
                    counter++;
                }
                if (MyInt3 == 1)
                {
                    counter++;
                }
                if (MyInt4 == 1)
                {
                    counter++;
                }
                if (MyInt5 == 1)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 1;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (MyInt1 == 2)
                {
                    counter++;
                }
                if (MyInt2 == 2)
                {
                    counter++;
                }
                if (MyInt3 == 2)
                {
                    counter++;
                }
                if (MyInt4 == 2)
                {
                    counter++;
                }
                if (MyInt5 == 2)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 2;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (MyInt1 == 3)
                {
                    counter++;
                }
                if (MyInt2 == 3)
                {
                    counter++;
                }
                if (MyInt3 == 3)
                {
                    counter++;
                }
                if (MyInt4 == 3)
                {
                    counter++;
                }
                if (MyInt5 == 3)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 3;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (MyInt1 == 4)
                {
                    counter++;
                }
                if (MyInt2 == 4)
                {
                    counter++;
                }
                if (MyInt3 == 4)
                {
                    counter++;
                }
                if (MyInt4 == 4)
                {
                    counter++;
                }
                if (MyInt5 == 4)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 4;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (MyInt1 == 5)
                {
                    counter++;
                }
                if (MyInt2 == 5)
                {
                    counter++;
                }
                if (MyInt3 == 5)
                {
                    counter++;
                }
                if (MyInt4 == 5)
                {
                    counter++;
                }
                if (MyInt5 == 5)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 5;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (MyInt1 == 6)
                {
                    counter++;
                }
                if (MyInt2 == 6)
                {
                    counter++;
                }
                if (MyInt3 == 6)
                {
                    counter++;
                }
                if (MyInt4 == 6)
                {
                    counter++;
                }
                if (MyInt5 == 6)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 6;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (bereken > 74)
                {
                    bereken = 0;
                    counter = 0;

                    if (MyInt1 == 1 && test2 != 1)
                    {
                        counter++;
                    }
                    if (MyInt2 == 1 && test2 != 1)
                    {
                        counter++;
                    }
                    if (MyInt3 == 1 && test2 != 1)
                    {
                        counter++;
                    }
                    if (MyInt4 == 1 && test2 != 1)
                    {
                        counter++;
                    }
                    if (MyInt5 == 1 && test2 != 1)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (MyInt1 == 2 && test2 != 2)
                    {
                        counter++;
                    }
                    if (MyInt2 == 2 && test2 != 2)
                    {
                        counter++;
                    }
                    if (MyInt3 == 2 && test2 != 2)
                    {
                        counter++;
                    }
                    if (MyInt4 == 2 && test2 != 2)
                    {
                        counter++;
                    }
                    if (MyInt5 == 2 && test2 != 2)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (MyInt1 == 3 && test2 != 3)
                    {
                        counter++;
                    }
                    if (MyInt2 == 3 && test2 != 3)
                    {
                        counter++;
                    }
                    if (MyInt3 == 3 && test2 != 3)
                    {
                        counter++;
                    }
                    if (MyInt4 == 3 && test2 != 3)
                    {
                        counter++;
                    }
                    if (MyInt5 == 3 && test2 != 3)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (MyInt1 == 4 && test2 != 4)
                    {
                        counter++;
                    }
                    if (MyInt2 == 4 && test2 != 4)
                    {
                        counter++;
                    }
                    if (MyInt3 == 4 && test2 != 4)
                    {
                        counter++;
                    }
                    if (MyInt4 == 4 && test2 != 4)
                    {
                        counter++;
                    }
                    if (MyInt5 == 4 && test2 != 4)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (MyInt1 == 5 && test2 != 5)
                    {
                        counter++;
                    }
                    if (MyInt2 == 5 && test2 != 5)
                    {
                        counter++;
                    }
                    if (MyInt3 == 5 && test2 != 5)
                    {
                        counter++;
                    }
                    if (MyInt4 == 5 && test2 != 5)
                    {
                        counter++;
                    }
                    if (MyInt5 == 5 && test2 != 5)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (MyInt1 == 6 && test2 != 6)
                    {
                        counter++;
                    }
                    if (MyInt2 == 6 && test2 != 6)
                    {
                        counter++;
                    }
                    if (MyInt3 == 6 && test2 != 6)
                    {
                        counter++;
                    }
                    if (MyInt4 == 6 && test2 != 6)
                    {
                        counter++;
                    }
                    if (MyInt5 == 6 && test2 != 6)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (bereken > 74)
                    {
                        fullhuisP2 = "25";
                        FullhouseP2.Content = "25";
                        tbFullhouseP2.Text = "25";

                        aantalwerpen.Text = "Roll";
                        SetAllElementsInvisible1();
                        SetAllElementsInvisible2();
                        SetAllElementsInvisible3();
                        SetAllElementsInvisible4();
                        SetAllElementsInvisible5();
                        counttheplayers();

                        checkbox1.Background = Brushes.Red;
                        checkbox2.Background = Brushes.Red;
                        checkbox3.Background = Brushes.Red;
                        checkbox4.Background = Brushes.Red;
                        checkbox5.Background = Brushes.Red;

                        MyInt1 = 0;
                        MyInt2 = 0;
                        MyInt3 = 0;
                        MyInt4 = 0;
                        MyInt5 = 0;

                        fullhouseP2 = Int32.Parse(tbFullhouseP2.Text);

                        helft2P2 = helft2P2 + fullhouseP2; // En hier tel je dan ook nog de andere waardes uit part 2 op
                        totalP2part1.Text = helft2P2.ToString();

                        fullhuisP2 = "Hoi";

                        int i;

                        i = Int32.Parse(totalP2part2.Text);

                        totalgrandP2 = i + helft2P2;
                        allP2.Text = totalgrandP2.ToString();

                        endcounter--;

                        if (endcounter < 1)
                        {
                            endGame();
                        }
                    }
                    else
                    {
                        fullhuisP2 = "0";
                        FullhouseP2.Content = "0";

                        aantalwerpen.Text = "Roll";
                        SetAllElementsInvisible1();
                        SetAllElementsInvisible2();
                        SetAllElementsInvisible3();
                        SetAllElementsInvisible4();
                        SetAllElementsInvisible5();
                        counttheplayers();

                        checkbox1.Background = Brushes.Red;
                        checkbox2.Background = Brushes.Red;
                        checkbox3.Background = Brushes.Red;
                        checkbox4.Background = Brushes.Red;
                        checkbox5.Background = Brushes.Red;

                        MyInt1 = 0;
                        MyInt2 = 0;
                        MyInt3 = 0;
                        MyInt4 = 0;
                        MyInt5 = 0;

                        totalP2part1.Text = helft2P2.ToString();

                        int i;

                        i = Int32.Parse(totalP2part2.Text);

                        totalgrandP2 = i + helft2P2;
                        allP2.Text = totalgrandP2.ToString();

                        endcounter--;

                        if (endcounter < 1)
                        {
                            endGame();
                        }
                    }
                }
                else
                {
                    fullhuisP2 = "0";
                    FullhouseP2.Content = "0";

                    aantalwerpen.Text = "Roll";
                    SetAllElementsInvisible1();
                    SetAllElementsInvisible2();
                    SetAllElementsInvisible3();
                    SetAllElementsInvisible4();
                    SetAllElementsInvisible5();
                    counttheplayers();

                    checkbox1.Background = Brushes.Red;
                    checkbox2.Background = Brushes.Red;
                    checkbox3.Background = Brushes.Red;
                    checkbox4.Background = Brushes.Red;
                    checkbox5.Background = Brushes.Red;

                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;

                    totalP2part1.Text = helft2P2.ToString();

                    int i;

                    i = Int32.Parse(totalP2part2.Text);

                    totalgrandP2 = i + helft2P2;
                    allP2.Text = totalgrandP2.ToString();

                    endcounter--;

                    if (endcounter < 1)
                    {
                        endGame();
                    }
                }
            }
            else
            {
                MessageBox.Show("It's not player 2's turn");
            }
        }

        private void FullhouseP3_Click(object sender, RoutedEventArgs e)
        {
            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (fullhuisP3 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            if (playernumbercount.Text == "3")
            {
                int bereken = 0;
                int counter = 0;
                int test2 = 0;

                if (MyInt1 == 1)
                {
                    counter++;
                }
                if (MyInt2 == 1)
                {
                    counter++;
                }
                if (MyInt3 == 1)
                {
                    counter++;
                }
                if (MyInt4 == 1)
                {
                    counter++;
                }
                if (MyInt5 == 1)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 1;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (MyInt1 == 2)
                {
                    counter++;
                }
                if (MyInt2 == 2)
                {
                    counter++;
                }
                if (MyInt3 == 2)
                {
                    counter++;
                }
                if (MyInt4 == 2)
                {
                    counter++;
                }
                if (MyInt5 == 2)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 2;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (MyInt1 == 3)
                {
                    counter++;
                }
                if (MyInt2 == 3)
                {
                    counter++;
                }
                if (MyInt3 == 3)
                {
                    counter++;
                }
                if (MyInt4 == 3)
                {
                    counter++;
                }
                if (MyInt5 == 3)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 3;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (MyInt1 == 4)
                {
                    counter++;
                }
                if (MyInt2 == 4)
                {
                    counter++;
                }
                if (MyInt3 == 4)
                {
                    counter++;
                }
                if (MyInt4 == 4)
                {
                    counter++;
                }
                if (MyInt5 == 4)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 4;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (MyInt1 == 5)
                {
                    counter++;
                }
                if (MyInt2 == 5)
                {
                    counter++;
                }
                if (MyInt3 == 5)
                {
                    counter++;
                }
                if (MyInt4 == 5)
                {
                    counter++;
                }
                if (MyInt5 == 5)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 5;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (MyInt1 == 6)
                {
                    counter++;
                }
                if (MyInt2 == 6)
                {
                    counter++;
                }
                if (MyInt3 == 6)
                {
                    counter++;
                }
                if (MyInt4 == 6)
                {
                    counter++;
                }
                if (MyInt5 == 6)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 6;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (bereken > 74)
                {
                    bereken = 0;
                    counter = 0;

                    if (MyInt1 == 1 && test2 != 1)
                    {
                        counter++;
                    }
                    if (MyInt2 == 1 && test2 != 1)
                    {
                        counter++;
                    }
                    if (MyInt3 == 1 && test2 != 1)
                    {
                        counter++;
                    }
                    if (MyInt4 == 1 && test2 != 1)
                    {
                        counter++;
                    }
                    if (MyInt5 == 1 && test2 != 1)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (MyInt1 == 2 && test2 != 2)
                    {
                        counter++;
                    }
                    if (MyInt2 == 2 && test2 != 2)
                    {
                        counter++;
                    }
                    if (MyInt3 == 2 && test2 != 2)
                    {
                        counter++;
                    }
                    if (MyInt4 == 2 && test2 != 2)
                    {
                        counter++;
                    }
                    if (MyInt5 == 2 && test2 != 2)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (MyInt1 == 3 && test2 != 3)
                    {
                        counter++;
                    }
                    if (MyInt2 == 3 && test2 != 3)
                    {
                        counter++;
                    }
                    if (MyInt3 == 3 && test2 != 3)
                    {
                        counter++;
                    }
                    if (MyInt4 == 3 && test2 != 3)
                    {
                        counter++;
                    }
                    if (MyInt5 == 3 && test2 != 3)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (MyInt1 == 4 && test2 != 4)
                    {
                        counter++;
                    }
                    if (MyInt2 == 4 && test2 != 4)
                    {
                        counter++;
                    }
                    if (MyInt3 == 4 && test2 != 4)
                    {
                        counter++;
                    }
                    if (MyInt4 == 4 && test2 != 4)
                    {
                        counter++;
                    }
                    if (MyInt5 == 4 && test2 != 4)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (MyInt1 == 5 && test2 != 5)
                    {
                        counter++;
                    }
                    if (MyInt2 == 5 && test2 != 5)
                    {
                        counter++;
                    }
                    if (MyInt3 == 5 && test2 != 5)
                    {
                        counter++;
                    }
                    if (MyInt4 == 5 && test2 != 5)
                    {
                        counter++;
                    }
                    if (MyInt5 == 5 && test2 != 5)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (MyInt1 == 6 && test2 != 6)
                    {
                        counter++;
                    }
                    if (MyInt2 == 6 && test2 != 6)
                    {
                        counter++;
                    }
                    if (MyInt3 == 6 && test2 != 6)
                    {
                        counter++;
                    }
                    if (MyInt4 == 6 && test2 != 6)
                    {
                        counter++;
                    }
                    if (MyInt5 == 6 && test2 != 6)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (bereken > 74)
                    {
                        fullhuisP3 = "25";
                        FullhouseP3.Content = "25";
                        tbFullhouseP3.Text = "25";

                        aantalwerpen.Text = "Roll";
                        SetAllElementsInvisible1();
                        SetAllElementsInvisible2();
                        SetAllElementsInvisible3();
                        SetAllElementsInvisible4();
                        SetAllElementsInvisible5();
                        counttheplayers();

                        checkbox1.Background = Brushes.Red;
                        checkbox2.Background = Brushes.Red;
                        checkbox3.Background = Brushes.Red;
                        checkbox4.Background = Brushes.Red;
                        checkbox5.Background = Brushes.Red;

                        MyInt1 = 0;
                        MyInt2 = 0;
                        MyInt3 = 0;
                        MyInt4 = 0;
                        MyInt5 = 0;

                        fullhouseP3 = Int32.Parse(tbFullhouseP3.Text);

                        helft2P3 = helft2P3 + fullhouseP3; // En hier tel je dan ook nog de andere waardes uit part 2 op
                        totalP3part1.Text = helft2P3.ToString();

                        fullhuisP3 = "Hoi";

                        int i;

                        i = Int32.Parse(totalP3part2.Text);

                        totalgrandP3 = i + helft2P3;
                        allP3.Text = totalgrandP3.ToString();

                        endcounter--;

                        if (endcounter < 1)
                        {
                            endGame();
                        }
                    }
                    else
                    {
                        fullhuisP3 = "0";
                        FullhouseP3.Content = "0";

                        aantalwerpen.Text = "Roll";
                        SetAllElementsInvisible1();
                        SetAllElementsInvisible2();
                        SetAllElementsInvisible3();
                        SetAllElementsInvisible4();
                        SetAllElementsInvisible5();
                        counttheplayers();

                        checkbox1.Background = Brushes.Red;
                        checkbox2.Background = Brushes.Red;
                        checkbox3.Background = Brushes.Red;
                        checkbox4.Background = Brushes.Red;
                        checkbox5.Background = Brushes.Red;

                        MyInt1 = 0;
                        MyInt2 = 0;
                        MyInt3 = 0;
                        MyInt4 = 0;
                        MyInt5 = 0;

                        totalP3part1.Text = helft2P3.ToString();

                        int i;

                        i = Int32.Parse(totalP3part2.Text);

                        totalgrandP3 = i + helft2P3;
                        allP3.Text = totalgrandP3.ToString();

                        endcounter--;

                        if (endcounter < 1)
                        {
                            endGame();
                        }
                    }
                }
                else
                {
                    fullhuisP3 = "0";
                    FullhouseP3.Content = "0";

                    aantalwerpen.Text = "Roll";
                    SetAllElementsInvisible1();
                    SetAllElementsInvisible2();
                    SetAllElementsInvisible3();
                    SetAllElementsInvisible4();
                    SetAllElementsInvisible5();
                    counttheplayers();

                    checkbox1.Background = Brushes.Red;
                    checkbox2.Background = Brushes.Red;
                    checkbox3.Background = Brushes.Red;
                    checkbox4.Background = Brushes.Red;
                    checkbox5.Background = Brushes.Red;

                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;

                    totalP3part1.Text = helft2P3.ToString();

                    int i;

                    i = Int32.Parse(totalP3part2.Text);

                    totalgrandP3 = i + helft2P3;
                    allP3.Text = totalgrandP3.ToString();

                    endcounter--;

                    if (endcounter < 1)
                    {
                        endGame();
                    }
                }
            }
            else
            {
                MessageBox.Show("It's not player 3's turn");
            }
        }

        private void FullhouseP4_Click(object sender, RoutedEventArgs e)
        {
            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (fullhuisP4 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            if (playernumbercount.Text == "4")
            {
                int bereken = 0;
                int counter = 0;
                int test2 = 0;

                if (MyInt1 == 1)
                {
                    counter++;
                }
                if (MyInt2 == 1)
                {
                    counter++;
                }
                if (MyInt3 == 1)
                {
                    counter++;
                }
                if (MyInt4 == 1)
                {
                    counter++;
                }
                if (MyInt5 == 1)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 1;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (MyInt1 == 2)
                {
                    counter++;
                }
                if (MyInt2 == 2)
                {
                    counter++;
                }
                if (MyInt3 == 2)
                {
                    counter++;
                }
                if (MyInt4 == 2)
                {
                    counter++;
                }
                if (MyInt5 == 2)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 2;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (MyInt1 == 3)
                {
                    counter++;
                }
                if (MyInt2 == 3)
                {
                    counter++;
                }
                if (MyInt3 == 3)
                {
                    counter++;
                }
                if (MyInt4 == 3)
                {
                    counter++;
                }
                if (MyInt5 == 3)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 3;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (MyInt1 == 4)
                {
                    counter++;
                }
                if (MyInt2 == 4)
                {
                    counter++;
                }
                if (MyInt3 == 4)
                {
                    counter++;
                }
                if (MyInt4 == 4)
                {
                    counter++;
                }
                if (MyInt5 == 4)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 4;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (MyInt1 == 5)
                {
                    counter++;
                }
                if (MyInt2 == 5)
                {
                    counter++;
                }
                if (MyInt3 == 5)
                {
                    counter++;
                }
                if (MyInt4 == 5)
                {
                    counter++;
                }
                if (MyInt5 == 5)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 5;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (MyInt1 == 6)
                {
                    counter++;
                }
                if (MyInt2 == 6)
                {
                    counter++;
                }
                if (MyInt3 == 6)
                {
                    counter++;
                }
                if (MyInt4 == 6)
                {
                    counter++;
                }
                if (MyInt5 == 6)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 6;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (bereken > 74)
                {
                    bereken = 0;
                    counter = 0;

                    if (MyInt1 == 1 && test2 != 1)
                    {
                        counter++;
                    }
                    if (MyInt2 == 1 && test2 != 1)
                    {
                        counter++;
                    }
                    if (MyInt3 == 1 && test2 != 1)
                    {
                        counter++;
                    }
                    if (MyInt4 == 1 && test2 != 1)
                    {
                        counter++;
                    }
                    if (MyInt5 == 1 && test2 != 1)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (MyInt1 == 2 && test2 != 2)
                    {
                        counter++;
                    }
                    if (MyInt2 == 2 && test2 != 2)
                    {
                        counter++;
                    }
                    if (MyInt3 == 2 && test2 != 2)
                    {
                        counter++;
                    }
                    if (MyInt4 == 2 && test2 != 2)
                    {
                        counter++;
                    }
                    if (MyInt5 == 2 && test2 != 2)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (MyInt1 == 3 && test2 != 3)
                    {
                        counter++;
                    }
                    if (MyInt2 == 3 && test2 != 3)
                    {
                        counter++;
                    }
                    if (MyInt3 == 3 && test2 != 3)
                    {
                        counter++;
                    }
                    if (MyInt4 == 3 && test2 != 3)
                    {
                        counter++;
                    }
                    if (MyInt5 == 3 && test2 != 3)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (MyInt1 == 4 && test2 != 4)
                    {
                        counter++;
                    }
                    if (MyInt2 == 4 && test2 != 4)
                    {
                        counter++;
                    }
                    if (MyInt3 == 4 && test2 != 4)
                    {
                        counter++;
                    }
                    if (MyInt4 == 4 && test2 != 4)
                    {
                        counter++;
                    }
                    if (MyInt5 == 4 && test2 != 4)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (MyInt1 == 5 && test2 != 5)
                    {
                        counter++;
                    }
                    if (MyInt2 == 5 && test2 != 5)
                    {
                        counter++;
                    }
                    if (MyInt3 == 5 && test2 != 5)
                    {
                        counter++;
                    }
                    if (MyInt4 == 5 && test2 != 5)
                    {
                        counter++;
                    }
                    if (MyInt5 == 5 && test2 != 5)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (MyInt1 == 6 && test2 != 6)
                    {
                        counter++;
                    }
                    if (MyInt2 == 6 && test2 != 6)
                    {
                        counter++;
                    }
                    if (MyInt3 == 6 && test2 != 6)
                    {
                        counter++;
                    }
                    if (MyInt4 == 6 && test2 != 6)
                    {
                        counter++;
                    }
                    if (MyInt5 == 6 && test2 != 6)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (bereken > 74)
                    {
                        fullhuisP4 = "25";
                        FullhouseP4.Content = "25";
                        tbFullhouseP4.Text = "25";

                        aantalwerpen.Text = "Roll";
                        SetAllElementsInvisible1();
                        SetAllElementsInvisible2();
                        SetAllElementsInvisible3();
                        SetAllElementsInvisible4();
                        SetAllElementsInvisible5();
                        counttheplayers();

                        checkbox1.Background = Brushes.Red;
                        checkbox2.Background = Brushes.Red;
                        checkbox3.Background = Brushes.Red;
                        checkbox4.Background = Brushes.Red;
                        checkbox5.Background = Brushes.Red;

                        MyInt1 = 0;
                        MyInt2 = 0;
                        MyInt3 = 0;
                        MyInt4 = 0;
                        MyInt5 = 0;

                        fullhouseP4 = Int32.Parse(tbFullhouseP4.Text);

                        helft2P4 = helft2P4 + fullhouseP4; // En hier tel je dan ook nog de andere waardes uit part 2 op
                        totalP4part1.Text = helft2P4.ToString();

                        fullhuisP4 = "Hoi";

                        int i;

                        i = Int32.Parse(totalP4part2.Text);

                        totalgrandP4 = i + helft2P4;
                        allP4.Text = totalgrandP4.ToString();

                        endcounter--;

                        if (endcounter < 1)
                        {
                            endGame();
                        }
                    }
                    else
                    {
                        fullhuisP4 = "0";
                        FullhouseP4.Content = "0";

                        aantalwerpen.Text = "Roll";
                        SetAllElementsInvisible1();
                        SetAllElementsInvisible2();
                        SetAllElementsInvisible3();
                        SetAllElementsInvisible4();
                        SetAllElementsInvisible5();
                        counttheplayers();

                        checkbox1.Background = Brushes.Red;
                        checkbox2.Background = Brushes.Red;
                        checkbox3.Background = Brushes.Red;
                        checkbox4.Background = Brushes.Red;
                        checkbox5.Background = Brushes.Red;

                        MyInt1 = 0;
                        MyInt2 = 0;
                        MyInt3 = 0;
                        MyInt4 = 0;
                        MyInt5 = 0;

                        totalP4part1.Text = helft2P4.ToString();

                        int i;

                        i = Int32.Parse(totalP4part2.Text);

                        totalgrandP4 = i + helft2P4;
                        allP4.Text = totalgrandP4.ToString();

                        endcounter--;

                        if (endcounter < 1)
                        {
                            endGame();
                        }
                    }
                }
                else
                {
                    fullhuisP4 = "0";
                    FullhouseP4.Content = "0";

                    aantalwerpen.Text = "Roll";
                    SetAllElementsInvisible1();
                    SetAllElementsInvisible2();
                    SetAllElementsInvisible3();
                    SetAllElementsInvisible4();
                    SetAllElementsInvisible5();
                    counttheplayers();

                    checkbox1.Background = Brushes.Red;
                    checkbox2.Background = Brushes.Red;
                    checkbox3.Background = Brushes.Red;
                    checkbox4.Background = Brushes.Red;
                    checkbox5.Background = Brushes.Red;

                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;

                    totalP4part1.Text = helft2P4.ToString();

                    int i;

                    i = Int32.Parse(totalP4part2.Text);

                    totalgrandP4 = i + helft2P4;
                    allP4.Text = totalgrandP4.ToString();

                    endcounter--;

                    if (endcounter < 1)
                    {
                        endGame();
                    }
                }
            }
            else
            {
                MessageBox.Show("It's not player 4's turn");
            }
        }

        private void FullhouseP5_Click(object sender, RoutedEventArgs e)
        {
            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (fullhuisP5 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            if (playernumbercount.Text == "5")
            {
                int bereken = 0;
                int counter = 0;
                int test2 = 0;

                if (MyInt1 == 1)
                {
                    counter++;
                }
                if (MyInt2 == 1)
                {
                    counter++;
                }
                if (MyInt3 == 1)
                {
                    counter++;
                }
                if (MyInt4 == 1)
                {
                    counter++;
                }
                if (MyInt5 == 1)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 1;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (MyInt1 == 2)
                {
                    counter++;
                }
                if (MyInt2 == 2)
                {
                    counter++;
                }
                if (MyInt3 == 2)
                {
                    counter++;
                }
                if (MyInt4 == 2)
                {
                    counter++;
                }
                if (MyInt5 == 2)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 2;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (MyInt1 == 3)
                {
                    counter++;
                }
                if (MyInt2 == 3)
                {
                    counter++;
                }
                if (MyInt3 == 3)
                {
                    counter++;
                }
                if (MyInt4 == 3)
                {
                    counter++;
                }
                if (MyInt5 == 3)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 3;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (MyInt1 == 4)
                {
                    counter++;
                }
                if (MyInt2 == 4)
                {
                    counter++;
                }
                if (MyInt3 == 4)
                {
                    counter++;
                }
                if (MyInt4 == 4)
                {
                    counter++;
                }
                if (MyInt5 == 4)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 4;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (MyInt1 == 5)
                {
                    counter++;
                }
                if (MyInt2 == 5)
                {
                    counter++;
                }
                if (MyInt3 == 5)
                {
                    counter++;
                }
                if (MyInt4 == 5)
                {
                    counter++;
                }
                if (MyInt5 == 5)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 5;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (MyInt1 == 6)
                {
                    counter++;
                }
                if (MyInt2 == 6)
                {
                    counter++;
                }
                if (MyInt3 == 6)
                {
                    counter++;
                }
                if (MyInt4 == 6)
                {
                    counter++;
                }
                if (MyInt5 == 6)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 6;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (bereken > 74)
                {
                    bereken = 0;
                    counter = 0;

                    if (MyInt1 == 1 && test2 != 1)
                    {
                        counter++;
                    }
                    if (MyInt2 == 1 && test2 != 1)
                    {
                        counter++;
                    }
                    if (MyInt3 == 1 && test2 != 1)
                    {
                        counter++;
                    }
                    if (MyInt4 == 1 && test2 != 1)
                    {
                        counter++;
                    }
                    if (MyInt5 == 1 && test2 != 1)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (MyInt1 == 2 && test2 != 2)
                    {
                        counter++;
                    }
                    if (MyInt2 == 2 && test2 != 2)
                    {
                        counter++;
                    }
                    if (MyInt3 == 2 && test2 != 2)
                    {
                        counter++;
                    }
                    if (MyInt4 == 2 && test2 != 2)
                    {
                        counter++;
                    }
                    if (MyInt5 == 2 && test2 != 2)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (MyInt1 == 3 && test2 != 3)
                    {
                        counter++;
                    }
                    if (MyInt2 == 3 && test2 != 3)
                    {
                        counter++;
                    }
                    if (MyInt3 == 3 && test2 != 3)
                    {
                        counter++;
                    }
                    if (MyInt4 == 3 && test2 != 3)
                    {
                        counter++;
                    }
                    if (MyInt5 == 3 && test2 != 3)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (MyInt1 == 4 && test2 != 4)
                    {
                        counter++;
                    }
                    if (MyInt2 == 4 && test2 != 4)
                    {
                        counter++;
                    }
                    if (MyInt3 == 4 && test2 != 4)
                    {
                        counter++;
                    }
                    if (MyInt4 == 4 && test2 != 4)
                    {
                        counter++;
                    }
                    if (MyInt5 == 4 && test2 != 4)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (MyInt1 == 5 && test2 != 5)
                    {
                        counter++;
                    }
                    if (MyInt2 == 5 && test2 != 5)
                    {
                        counter++;
                    }
                    if (MyInt3 == 5 && test2 != 5)
                    {
                        counter++;
                    }
                    if (MyInt4 == 5 && test2 != 5)
                    {
                        counter++;
                    }
                    if (MyInt5 == 5 && test2 != 5)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (MyInt1 == 6 && test2 != 6)
                    {
                        counter++;
                    }
                    if (MyInt2 == 6 && test2 != 6)
                    {
                        counter++;
                    }
                    if (MyInt3 == 6 && test2 != 6)
                    {
                        counter++;
                    }
                    if (MyInt4 == 6 && test2 != 6)
                    {
                        counter++;
                    }
                    if (MyInt5 == 6 && test2 != 6)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (bereken > 74)
                    {
                        fullhuisP5 = "25";
                        FullhouseP5.Content = "25";
                        tbFullhouseP5.Text = "25";

                        aantalwerpen.Text = "Roll";
                        SetAllElementsInvisible1();
                        SetAllElementsInvisible2();
                        SetAllElementsInvisible3();
                        SetAllElementsInvisible4();
                        SetAllElementsInvisible5();
                        counttheplayers();

                        checkbox1.Background = Brushes.Red;
                        checkbox2.Background = Brushes.Red;
                        checkbox3.Background = Brushes.Red;
                        checkbox4.Background = Brushes.Red;
                        checkbox5.Background = Brushes.Red;

                        MyInt1 = 0;
                        MyInt2 = 0;
                        MyInt3 = 0;
                        MyInt4 = 0;
                        MyInt5 = 0;

                        fullhouseP5 = Int32.Parse(tbFullhouseP5.Text);

                        helft2P5 = helft2P5 + fullhouseP5; // En hier tel je dan ook nog de andere waardes uit part 2 op
                        totalP5part1.Text = helft2P5.ToString();

                        fullhuisP5 = "Hoi";

                        int i;

                        i = Int32.Parse(totalP5part2.Text);

                        totalgrandP5 = i + helft2P5;
                        allP5.Text = totalgrandP5.ToString();

                        endcounter--;

                        if (endcounter < 1)
                        {
                            endGame();
                        }
                    }
                    else
                    {
                        fullhuisP5 = "0";
                        FullhouseP5.Content = "0";

                        aantalwerpen.Text = "Roll";
                        SetAllElementsInvisible1();
                        SetAllElementsInvisible2();
                        SetAllElementsInvisible3();
                        SetAllElementsInvisible4();
                        SetAllElementsInvisible5();
                        counttheplayers();

                        checkbox1.Background = Brushes.Red;
                        checkbox2.Background = Brushes.Red;
                        checkbox3.Background = Brushes.Red;
                        checkbox4.Background = Brushes.Red;
                        checkbox5.Background = Brushes.Red;

                        MyInt1 = 0;
                        MyInt2 = 0;
                        MyInt3 = 0;
                        MyInt4 = 0;
                        MyInt5 = 0;

                        totalP5part1.Text = helft2P5.ToString();

                        int i;

                        i = Int32.Parse(totalP5part2.Text);

                        totalgrandP5 = i + helft2P5;
                        allP5.Text = totalgrandP5.ToString();

                        endcounter--;

                        if (endcounter < 1)
                        {
                            endGame();
                        }
                    }
                }
                else
                {
                    fullhuisP5 = "0";
                    FullhouseP5.Content = "0";

                    aantalwerpen.Text = "Roll";
                    SetAllElementsInvisible1();
                    SetAllElementsInvisible2();
                    SetAllElementsInvisible3();
                    SetAllElementsInvisible4();
                    SetAllElementsInvisible5();
                    counttheplayers();

                    checkbox1.Background = Brushes.Red;
                    checkbox2.Background = Brushes.Red;
                    checkbox3.Background = Brushes.Red;
                    checkbox4.Background = Brushes.Red;
                    checkbox5.Background = Brushes.Red;

                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;

                    totalP5part1.Text = helft2P5.ToString();

                    int i;

                    i = Int32.Parse(totalP5part2.Text);

                    totalgrandP5 = i + helft2P5;
                    allP5.Text = totalgrandP5.ToString();

                    endcounter--;

                    if (endcounter < 1)
                    {
                        endGame();
                    }
                }
            }
            else
            {
                MessageBox.Show("It's not player 5's turn");
            }
        }

        private void FullhouseP6_Click(object sender, RoutedEventArgs e)
        {
            if (aantalwerpen.Text == "Roll")
            {
                MessageBox.Show("Please roll dice at least once");
                return;
            }

            if (fullhuisP6 != "")
            {
                MessageBox.Show("You already filled in this field");
                return;
            }

            if (playernumbercount.Text == "6")
            {
                int bereken = 0;
                int counter = 0;
                int test2 = 0;

                if (MyInt1 == 1)
                {
                    counter++;
                }
                if (MyInt2 == 1)
                {
                    counter++;
                }
                if (MyInt3 == 1)
                {
                    counter++;
                }
                if (MyInt4 == 1)
                {
                    counter++;
                }
                if (MyInt5 == 1)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 1;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (MyInt1 == 2)
                {
                    counter++;
                }
                if (MyInt2 == 2)
                {
                    counter++;
                }
                if (MyInt3 == 2)
                {
                    counter++;
                }
                if (MyInt4 == 2)
                {
                    counter++;
                }
                if (MyInt5 == 2)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 2;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (MyInt1 == 3)
                {
                    counter++;
                }
                if (MyInt2 == 3)
                {
                    counter++;
                }
                if (MyInt3 == 3)
                {
                    counter++;
                }
                if (MyInt4 == 3)
                {
                    counter++;
                }
                if (MyInt5 == 3)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 3;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (MyInt1 == 4)
                {
                    counter++;
                }
                if (MyInt2 == 4)
                {
                    counter++;
                }
                if (MyInt3 == 4)
                {
                    counter++;
                }
                if (MyInt4 == 4)
                {
                    counter++;
                }
                if (MyInt5 == 4)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 4;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (MyInt1 == 5)
                {
                    counter++;
                }
                if (MyInt2 == 5)
                {
                    counter++;
                }
                if (MyInt3 == 5)
                {
                    counter++;
                }
                if (MyInt4 == 5)
                {
                    counter++;
                }
                if (MyInt5 == 5)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 5;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (MyInt1 == 6)
                {
                    counter++;
                }
                if (MyInt2 == 6)
                {
                    counter++;
                }
                if (MyInt3 == 6)
                {
                    counter++;
                }
                if (MyInt4 == 6)
                {
                    counter++;
                }
                if (MyInt5 == 6)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    bereken = 100;
                    counter = 0;
                    test2 = 6;
                }
                else
                {
                    bereken = bereken - 5;
                    counter = 0;
                }

                if (bereken > 74)
                {
                    bereken = 0;
                    counter = 0;

                    if (MyInt1 == 1 && test2 != 1)
                    {
                        counter++;
                    }
                    if (MyInt2 == 1 && test2 != 1)
                    {
                        counter++;
                    }
                    if (MyInt3 == 1 && test2 != 1)
                    {
                        counter++;
                    }
                    if (MyInt4 == 1 && test2 != 1)
                    {
                        counter++;
                    }
                    if (MyInt5 == 1 && test2 != 1)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (MyInt1 == 2 && test2 != 2)
                    {
                        counter++;
                    }
                    if (MyInt2 == 2 && test2 != 2)
                    {
                        counter++;
                    }
                    if (MyInt3 == 2 && test2 != 2)
                    {
                        counter++;
                    }
                    if (MyInt4 == 2 && test2 != 2)
                    {
                        counter++;
                    }
                    if (MyInt5 == 2 && test2 != 2)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (MyInt1 == 3 && test2 != 3)
                    {
                        counter++;
                    }
                    if (MyInt2 == 3 && test2 != 3)
                    {
                        counter++;
                    }
                    if (MyInt3 == 3 && test2 != 3)
                    {
                        counter++;
                    }
                    if (MyInt4 == 3 && test2 != 3)
                    {
                        counter++;
                    }
                    if (MyInt5 == 3 && test2 != 3)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (MyInt1 == 4 && test2 != 4)
                    {
                        counter++;
                    }
                    if (MyInt2 == 4 && test2 != 4)
                    {
                        counter++;
                    }
                    if (MyInt3 == 4 && test2 != 4)
                    {
                        counter++;
                    }
                    if (MyInt4 == 4 && test2 != 4)
                    {
                        counter++;
                    }
                    if (MyInt5 == 4 && test2 != 4)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (MyInt1 == 5 && test2 != 5)
                    {
                        counter++;
                    }
                    if (MyInt2 == 5 && test2 != 5)
                    {
                        counter++;
                    }
                    if (MyInt3 == 5 && test2 != 5)
                    {
                        counter++;
                    }
                    if (MyInt4 == 5 && test2 != 5)
                    {
                        counter++;
                    }
                    if (MyInt5 == 5 && test2 != 5)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (MyInt1 == 6 && test2 != 6)
                    {
                        counter++;
                    }
                    if (MyInt2 == 6 && test2 != 6)
                    {
                        counter++;
                    }
                    if (MyInt3 == 6 && test2 != 6)
                    {
                        counter++;
                    }
                    if (MyInt4 == 6 && test2 != 6)
                    {
                        counter++;
                    }
                    if (MyInt5 == 6 && test2 != 6)
                    {
                        counter++;
                    }

                    if (counter >= 2)
                    {
                        bereken = 100;
                        counter = 0;
                    }
                    else
                    {
                        bereken = bereken - 5;
                        counter = 0;
                    }

                    if (bereken > 74)
                    {
                        fullhuisP6 = "25";
                        FullhouseP6.Content = "25";
                        tbFullhouseP6.Text = "25";

                        aantalwerpen.Text = "Roll";
                        SetAllElementsInvisible1();
                        SetAllElementsInvisible2();
                        SetAllElementsInvisible3();
                        SetAllElementsInvisible4();
                        SetAllElementsInvisible5();
                        counttheplayers();

                        checkbox1.Background = Brushes.Red;
                        checkbox2.Background = Brushes.Red;
                        checkbox3.Background = Brushes.Red;
                        checkbox4.Background = Brushes.Red;
                        checkbox5.Background = Brushes.Red;

                        MyInt1 = 0;
                        MyInt2 = 0;
                        MyInt3 = 0;
                        MyInt4 = 0;
                        MyInt5 = 0;

                        fullhouseP6 = Int32.Parse(tbFullhouseP6.Text);

                        helft2P6 = helft2P6 + fullhouseP6; // En hier tel je dan ook nog de andere waardes uit part 2 op
                        totalP6part1.Text = helft2P6.ToString();

                        fullhuisP6 = "Hoi";

                        int i;

                        i = Int32.Parse(totalP6part2.Text);

                        totalgrandP6 = i + helft2P6;
                        allP6.Text = totalgrandP6.ToString();

                        endcounter--;

                        if (endcounter < 1)
                        {
                            endGame();
                        }
                    }
                    else
                    {
                        fullhuisP6 = "0";
                        FullhouseP6.Content = "0";

                        aantalwerpen.Text = "Roll";
                        SetAllElementsInvisible1();
                        SetAllElementsInvisible2();
                        SetAllElementsInvisible3();
                        SetAllElementsInvisible4();
                        SetAllElementsInvisible5();
                        counttheplayers();

                        checkbox1.Background = Brushes.Red;
                        checkbox2.Background = Brushes.Red;
                        checkbox3.Background = Brushes.Red;
                        checkbox4.Background = Brushes.Red;
                        checkbox5.Background = Brushes.Red;

                        MyInt1 = 0;
                        MyInt2 = 0;
                        MyInt3 = 0;
                        MyInt4 = 0;
                        MyInt5 = 0;

                        totalP6part1.Text = helft2P6.ToString();

                        int i;

                        i = Int32.Parse(totalP6part2.Text);

                        totalgrandP6 = i + helft2P6;
                        allP6.Text = totalgrandP6.ToString();

                        endcounter--;

                        if (endcounter < 1)
                        {
                            endGame();
                        }
                    }
                }
                else
                {
                    fullhuisP6 = "0";
                    FullhouseP6.Content = "0";

                    aantalwerpen.Text = "Roll";
                    SetAllElementsInvisible1();
                    SetAllElementsInvisible2();
                    SetAllElementsInvisible3();
                    SetAllElementsInvisible4();
                    SetAllElementsInvisible5();
                    counttheplayers();

                    checkbox1.Background = Brushes.Red;
                    checkbox2.Background = Brushes.Red;
                    checkbox3.Background = Brushes.Red;
                    checkbox4.Background = Brushes.Red;
                    checkbox5.Background = Brushes.Red;

                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;

                    totalP6part1.Text = helft2P6.ToString();

                    int i;

                    i = Int32.Parse(totalP6part2.Text);

                    totalgrandP6 = i + helft2P6;
                    allP6.Text = totalgrandP6.ToString();

                    endcounter--;

                    if (endcounter < 1)
                    {
                        endGame();
                    }
                }
            }
            else
            {
                MessageBox.Show("It's not player 6's turn");
            }
        }

        private void players_TextChanged(object sender, TextChangedEventArgs e)
        {
            int testing = 0;

            if (players.Text == "")
            {
                return;
            }

            try
            {
                testing = Int32.Parse(players.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill in a number");
                return;
            }

            if (testing < 2 || testing > 6)
            {
                MessageBox.Show("You must play with at least 2 players and the maximum amount of players is 6");
                return;
            }
            else
            {
                question.Visibility = Visibility.Visible;
                Norules.Visibility = Visibility.Visible;
                Yesrules.Visibility = Visibility.Visible;
                nop.Visibility = Visibility.Hidden;
                players.Visibility = Visibility.Hidden;
            }
        }

        private void Yesrules_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                aantalspelers = Int32.Parse(players.Text);

                if (aantalspelers == 2)
                {
                    endcounter = 26;
                }
                else if (aantalspelers == 3)
                {
                    endcounter = 39;
                }
                else if (aantalspelers == 4)
                {
                    endcounter = 52;
                }
                else if (aantalspelers == 5)
                {
                    endcounter = 65;
                }
                else if (aantalspelers == 6)
                {
                    endcounter = 78;
                }

                if (aantalspelers > 1 && aantalspelers < 7)
                {
                    witteachtergrond.Visibility = Visibility.Visible;
                    checkbox1.Visibility = Visibility.Visible;
                    checkbox2.Visibility = Visibility.Visible;
                    checkbox3.Visibility = Visibility.Visible;
                    checkbox4.Visibility = Visibility.Visible;
                    checkbox5.Visibility = Visibility.Visible;
                    rolldice.Visibility = Visibility.Visible;
                    aantalwerpen.Visibility = Visibility.Visible;
                    Norules.Visibility = Visibility.Hidden;
                    players.Visibility = Visibility.Hidden;
                    nop.Visibility = Visibility.Hidden;
                    Part1.Visibility = Visibility.Visible;
                    Player1part1.Visibility = Visibility.Visible;
                    Player2part1.Visibility = Visibility.Visible;
                    Part2.Visibility = Visibility.Visible;
                    Player1part2.Visibility = Visibility.Visible;
                    Player2part2.Visibility = Visibility.Visible;
                    backgroundcounter.Visibility = Visibility.Visible;
                    playertekst.Visibility = Visibility.Visible;
                    playernumbercount.Visibility = Visibility.Visible;
                    question.Visibility = Visibility.Hidden;
                    Yesrules.Visibility = Visibility.Hidden;

                    if (aantalspelers == 3)
                    {
                        Player3part1.Visibility = Visibility.Visible;
                        Player3part2.Visibility = Visibility.Visible;
                    }
                    else if (aantalspelers == 4)
                    {
                        Player3part1.Visibility = Visibility.Visible;
                        Player4part1.Visibility = Visibility.Visible;
                        Player3part2.Visibility = Visibility.Visible;
                        Player4part2.Visibility = Visibility.Visible;
                    }
                    else if (aantalspelers == 5)
                    {
                        Player3part1.Visibility = Visibility.Visible;
                        Player4part1.Visibility = Visibility.Visible;
                        Player5part1.Visibility = Visibility.Visible;
                        Player3part2.Visibility = Visibility.Visible;
                        Player4part2.Visibility = Visibility.Visible;
                        Player5part2.Visibility = Visibility.Visible;
                    }
                    else if (aantalspelers == 6)
                    {
                        Player3part1.Visibility = Visibility.Visible;
                        Player4part1.Visibility = Visibility.Visible;
                        Player5part1.Visibility = Visibility.Visible;
                        Player6part1.Visibility = Visibility.Visible;
                        Player3part2.Visibility = Visibility.Visible;
                        Player4part2.Visibility = Visibility.Visible;
                        Player5part2.Visibility = Visibility.Visible;
                        Player6part2.Visibility = Visibility.Visible;
                    }

                    MessageBox.Show("Welcome to Yahtzee! One of the most popular dice games. This guide will tell you how the game works!");
                    CancelGuide.Visibility = Visibility.Visible;
                    pijl.Visibility = Visibility.Visible;
                    MessageBox.Show("You can always cancel this guide and go to the game when you click on the button left in the bottom");
                    pijl.Visibility = Visibility.Hidden;
                    rolldice.Visibility = Visibility.Hidden;
                    Step1.Visibility = Visibility.Visible;
                    Next.Visibility = Visibility.Visible;
                    border.Visibility = Visibility.Visible;
                }
                else
                {
                    MessageBox.Show("Please fill in a number between 2 and 6");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill in a number between 2 and 6");
            }
        }

        private void CancelGuide_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult stopguide = MessageBox.Show("Do you want to stop the guide?", "Stop guide?", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (stopguide == MessageBoxResult.Yes)
            {
                CancelGuide.Visibility = Visibility.Hidden;
                rolldice.Visibility = Visibility.Visible;
                Next.Visibility = Visibility.Hidden;
                Step1.Visibility = Visibility.Hidden;
                Step2.Visibility = Visibility.Hidden;
                Step3.Visibility = Visibility.Hidden;
                border.Visibility = Visibility.Hidden;
                pijl.Visibility = Visibility.Hidden;
                pijl2.Visibility = Visibility.Hidden;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        { 
            if (Step1.Visibility == Visibility.Visible)
            {
                Step1.Visibility = Visibility.Hidden;
                Step2.Visibility = Visibility.Visible;
            }
            else if(Step2.Visibility == Visibility.Visible)
            {
                Step2.Visibility = Visibility.Hidden;
                Step3.Visibility = Visibility.Visible;
            }
            else if (Step3.Visibility == Visibility.Visible)
            {
                Step3.Visibility = Visibility.Hidden;
                border.Visibility = Visibility.Hidden;
                MessageBox.Show("Okay! Let's explain how the application works!");
                rolldice.Visibility = Visibility.Visible;
                pijl2.Visibility = Visibility.Visible;
                MessageBox.Show("Click on the button 'Roll dice' on the left at the bottom.");
                Next.Visibility = Visibility.Hidden;
            }
        }

        private void endGame()
        {
            int totaalP1;
            int totaalP2;
            int totaalP3;
            int totaalP4;
            int totaalP5;
            int totaalP6;

            totaalP1 = Int32.Parse(allP1.Text);
            totaalP2 = Int32.Parse(allP2.Text);
            totaalP3 = Int32.Parse(allP3.Text);
            totaalP4 = Int32.Parse(allP4.Text);
            totaalP5 = Int32.Parse(allP5.Text);
            totaalP6 = Int32.Parse(allP6.Text);

            int[] puntenArray = { totaalP1, totaalP2, totaalP3, totaalP4, totaalP5, totaalP6 };

            Array.Sort(puntenArray);

            if (totaalP1 == puntenArray[5])
            {
                MessageBox.Show("Speler 1 heeft gewonnen met " + puntenArray[5] + " punten!");
            }
            
            if (totaalP2 == puntenArray[5])
            {
                MessageBox.Show("Speler 2 heeft gewonnen met " + puntenArray[5] + " punten!");
            }
            
            if (totaalP3 == puntenArray[5])
            {
                MessageBox.Show("Speler 3 heeft gewonnen met " + puntenArray[5] + " punten!");
            }
            
            if (totaalP4 == puntenArray[5])
            {
                MessageBox.Show("Speler 4 heeft gewonnen met " + puntenArray[5] + " punten!");
            }
            
            if (totaalP5 == puntenArray[5])
            {
                MessageBox.Show("Speler 5 heeft gewonnen met " + puntenArray[5] + " punten!");
            }
            
            if (totaalP6 == puntenArray[5])
            {
                MessageBox.Show("Speler 6 heeft gewonnen met " + puntenArray[5] + " punten!");
            }
        }
    }
}
    

