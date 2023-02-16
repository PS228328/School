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

namespace Qwixx
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random myRandom = new Random();

        int MyInt1;
        int MyInt2;
        int MyInt3;
        int MyInt4;
        int MyInt5;
        int MyInt6;
        int Wittestenenuitkomst;
        int minus = 0;
        int redcounter;
        int yellowcounter;
        int bluecounter;
        int greencounter;
        int totalscore;
        string rode2;
        string rode3;
        string rode4;
        string rode5;
        string rode6;
        string rode7;
        string rode8;
        string rode9;
        string rode10;
        string rode11;
        string rode12;
        string gele2;
        string gele3;
        string gele4;
        string gele5;
        string gele6;
        string gele7;
        string gele8;
        string gele9;
        string gele10;
        string gele11;
        string gele12;
        string blauwe2;
        string blauwe3;
        string blauwe4;
        string blauwe5;
        string blauwe6;
        string blauwe7;
        string blauwe8;
        string blauwe9;
        string blauwe10;
        string blauwe11;
        string blauwe12;
        string groene2;
        string groene3;
        string groene4;
        string groene5;
        string groene6;
        string groene7;
        string groene8;
        string groene9;
        string groene10;
        string groene11;
        string groene12;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RollDice_Click(object sender, RoutedEventArgs e)
        {
            setblock1invisible();
            setblock2invisible();
            setblockredinvisible();
            setblockyellowinvisible();
            setblockblueinvisible();
            setblockgreeninvisible();

            RollDice.Visibility = Visibility.Hidden;
            Action.Visibility = Visibility.Visible;
            Skipaction.Visibility = Visibility.Visible;

            Action.Text = "Action 1";

            MyInt1 = myRandom.Next(1, 7);
            MyInt2 = myRandom.Next(1, 7);
            MyInt3 = myRandom.Next(1, 7);
            MyInt4 = myRandom.Next(1, 7);
            MyInt5 = myRandom.Next(1, 7);
            MyInt6 = myRandom.Next(1, 7);

            Wittestenenuitkomst = MyInt1 + MyInt2;

            aanwijzingen.Text = "Player rolls " + Wittestenenuitkomst + ", please select this number in one of the colors if you want";

            //DICEBLOCK1

            if (MyInt1 == 1)
            {
                block11.Visibility = Visibility.Visible;
            }
            else if (MyInt1 == 2)
            {
                block12.Visibility = Visibility.Visible;
            }
            else if (MyInt1 == 3)
            {
                block13.Visibility = Visibility.Visible;
            }
            else if (MyInt1 == 4)
            {
                block14.Visibility = Visibility.Visible;
            }
            else if (MyInt1 == 5)
            {
                block15.Visibility = Visibility.Visible;
            }
            else if (MyInt1 == 6)
            {
                block16.Visibility = Visibility.Visible;
            }

            //DICEBLOCK2

            if (MyInt2 == 1)
            {
                block21.Visibility = Visibility.Visible;
            }
            else if (MyInt2 == 2)
            {
                block22.Visibility = Visibility.Visible;
            }
            else if (MyInt2 == 3)
            {
                block23.Visibility = Visibility.Visible;
            }
            else if (MyInt2 == 4)
            {
                block24.Visibility = Visibility.Visible;
            }
            else if (MyInt2 == 5)
            {
                block25.Visibility = Visibility.Visible;
            }
            else if (MyInt2 == 6)
            {
                block26.Visibility = Visibility.Visible;
            }

            //REDDICEBLOCK

            if (MyInt3 == 1)
            {
                redblock1.Visibility = Visibility.Visible;
            }
            else if (MyInt3 == 2)
            {
                redblock2.Visibility = Visibility.Visible;
            }
            else if (MyInt3 == 3)
            {
                redblock3.Visibility = Visibility.Visible;
            }
            else if (MyInt3 == 4)
            {
                redblock4.Visibility = Visibility.Visible;
            }
            else if (MyInt3 == 5)
            {
                redblock5.Visibility = Visibility.Visible;
            }
            else if (MyInt3 == 6)
            {
                redblock6.Visibility = Visibility.Visible;
            }

            //YELLOWDICEBLOCK

            if (MyInt4 == 1)
            {
                yellowblock1.Visibility = Visibility.Visible;
            }
            else if (MyInt4 == 2)
            {
                yellowblock2.Visibility = Visibility.Visible;
            }
            else if (MyInt4 == 3)
            {
                yellowblock3.Visibility = Visibility.Visible;
            }
            else if (MyInt4 == 4)
            {
                yellowblock4.Visibility = Visibility.Visible;
            }
            else if (MyInt4 == 5)
            {
                yellowblock5.Visibility = Visibility.Visible;
            }
            else if (MyInt4 == 6)
            {
                yellowblock6.Visibility = Visibility.Visible;
            }

            //BLUEDICEBLOCK

            if (MyInt5 == 1)
            {
                blueblock1.Visibility = Visibility.Visible;
            }
            else if (MyInt5 == 2)
            {
                blueblock2.Visibility = Visibility.Visible;
            }
            else if (MyInt5 == 3)
            {
                blueblock3.Visibility = Visibility.Visible;
            }
            else if (MyInt5 == 4)
            {
                blueblock4.Visibility = Visibility.Visible;
            }
            else if (MyInt5 == 5)
            {
                blueblock5.Visibility = Visibility.Visible;
            }
            else if (MyInt5 == 6)
            {
                blueblock6.Visibility = Visibility.Visible;
            }

            //GREENDICEBLOCK

            if (MyInt6 == 1)
            {
                greenblock1.Visibility = Visibility.Visible;
            }
            else if (MyInt6 == 2)
            {
                greenblock2.Visibility = Visibility.Visible;
            }
            else if (MyInt6 == 3)
            {
                greenblock3.Visibility = Visibility.Visible;
            }
            else if (MyInt6 == 4)
            {
                greenblock4.Visibility = Visibility.Visible;
            }
            else if (MyInt6 == 5)
            {
                greenblock5.Visibility = Visibility.Visible;
            }
            else if (MyInt6 == 6)
            {
                greenblock6.Visibility = Visibility.Visible;
            }
        }

        private void setblock1invisible()
        {
            block11.Visibility = Visibility.Hidden;
            block12.Visibility = Visibility.Hidden;
            block13.Visibility = Visibility.Hidden;
            block14.Visibility = Visibility.Hidden;
            block15.Visibility = Visibility.Hidden;
            block16.Visibility = Visibility.Hidden;
        }

        private void setblock2invisible()
        {
            block21.Visibility = Visibility.Hidden;
            block22.Visibility = Visibility.Hidden;
            block23.Visibility = Visibility.Hidden;
            block24.Visibility = Visibility.Hidden;
            block25.Visibility = Visibility.Hidden;
            block26.Visibility = Visibility.Hidden;
        }

        private void setblockredinvisible()
        {
            redblock1.Visibility = Visibility.Hidden;
            redblock2.Visibility = Visibility.Hidden;
            redblock3.Visibility = Visibility.Hidden;
            redblock4.Visibility = Visibility.Hidden;
            redblock5.Visibility = Visibility.Hidden;
            redblock6.Visibility = Visibility.Hidden;
        }

        private void setblockyellowinvisible()
        {
            yellowblock1.Visibility = Visibility.Hidden;
            yellowblock2.Visibility = Visibility.Hidden;
            yellowblock3.Visibility = Visibility.Hidden;
            yellowblock4.Visibility = Visibility.Hidden;
            yellowblock5.Visibility = Visibility.Hidden;
            yellowblock6.Visibility = Visibility.Hidden;
        }

        private void setblockblueinvisible()
        {
            blueblock1.Visibility = Visibility.Hidden;
            blueblock2.Visibility = Visibility.Hidden;
            blueblock3.Visibility = Visibility.Hidden;
            blueblock4.Visibility = Visibility.Hidden;
            blueblock5.Visibility = Visibility.Hidden;
            blueblock6.Visibility = Visibility.Hidden;
        }

        private void setblockgreeninvisible()
        {
            greenblock1.Visibility = Visibility.Hidden;
            greenblock2.Visibility = Visibility.Hidden;
            greenblock3.Visibility = Visibility.Hidden;
            greenblock4.Visibility = Visibility.Hidden;
            greenblock5.Visibility = Visibility.Hidden;
            greenblock6.Visibility = Visibility.Hidden;
        }

        private void red2_Click(object sender, RoutedEventArgs e)
        {
            if (redlocker.Text == "Lock")
            {
                MessageBox.Show("This color is locked");
                return;
            }

            rode2 = red2.Content.ToString();
            if(rode2 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if(rode2 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            } 

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt3 == 2 || MyInt2 + MyInt3 == 2)
                {
                    red2.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforredcounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the red 2");
                }
            }

            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 2)
                {
                    red2.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforredcounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void red3_Click(object sender, RoutedEventArgs e)
        {
            if (redlocker.Text == "Lock")
            {
                MessageBox.Show("This color is locked");
                return;
            }

            rode3 = red3.Content.ToString();
            if (rode3 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (rode3 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt3 == 3 || MyInt2 + MyInt3 == 3)
                {
                    red3.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforredcounter();
                    Warningforminus5.Visibility = Visibility.Hidden;

                    if (rode2 != "X")
                    {
                        red2.Content = "-";
                    }
                }
                else
                {
                    MessageBox.Show("There is no way to combine the red 3");
                }
            }

            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 3)
                {
                    red3.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforredcounter();

                    if(rode2 != "X")
                    {
                        red2.Content = "-";
                    }
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }

        }

        private void red4_Click(object sender, RoutedEventArgs e)
        {
            if (redlocker.Text == "Lock")
            {
                MessageBox.Show("This color is locked");
                return;
            }

            rode4 = red4.Content.ToString();
            if (rode4 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (rode4 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt3 == 4 || MyInt2 + MyInt3 == 4)
                {
                    red4.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforredcounter();
                    Warningforminus5.Visibility = Visibility.Hidden;

                    if (rode2 != "X")
                    {
                        red2.Content = "-";
                    }

                    if (rode3 != "X")
                    {
                        red3.Content = "-";
                    }
                }
                else
                {
                    MessageBox.Show("There is no way to combine the red 4");
                }
            }

            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 4)
                {
                    red4.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforredcounter();

                    if (rode2 != "X")
                    {
                        red2.Content = "-";
                    }

                    if (rode3 != "X")
                    {
                        red3.Content = "-";
                    }
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void red5_Click(object sender, RoutedEventArgs e)
        {
            if (redlocker.Text == "Lock")
            {
                MessageBox.Show("This color is locked");
                return;
            }

            rode5 = red5.Content.ToString();
            if (rode5 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (rode5 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt3 == 5 || MyInt2 + MyInt3 == 5)
                {
                    red5.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforredcounter();
                    Warningforminus5.Visibility = Visibility.Hidden;

                    if (rode2 != "X")
                    {
                        red2.Content = "-";
                    }

                    if (rode3 != "X")
                    {
                        red3.Content = "-";
                    }

                    if (rode4 != "X")
                    {
                        red4.Content = "-";
                    }
                }
                else
                {
                    MessageBox.Show("There is no way to combine the red 5");
                }
            }

            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 5)
                {
                    red5.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforredcounter();

                    if (rode2 != "X")
                    {
                        red2.Content = "-";
                    }

                    if (rode3 != "X")
                    {
                        red3.Content = "-";
                    }

                    if (rode4 != "X")
                    {
                        red4.Content = "-";
                    }
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }

        }

        private void red6_Click(object sender, RoutedEventArgs e)
        {
            if (redlocker.Text == "Lock")
            {
                MessageBox.Show("This color is locked");
                return;
            }

            rode6 = red6.Content.ToString();
            if (rode6 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (rode6 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt3 == 6 || MyInt2 + MyInt3 == 6)
                {
                    red6.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforredcounter();
                    Warningforminus5.Visibility = Visibility.Hidden;

                    if (rode2 != "X")
                    {
                        red2.Content = "-";
                    }

                    if (rode3 != "X")
                    {
                        red3.Content = "-";
                    }

                    if (rode4 != "X")
                    {
                        red4.Content = "-";
                    }

                    if (rode5 != "X")
                    {
                        red5.Content = "-";
                    }
                }
                else
                {
                    MessageBox.Show("There is no way to combine the red 6");
                }
            }

            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 6)
                {
                    red6.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforredcounter();

                    if (rode2 != "X")
                    {
                        red2.Content = "-";
                    }

                    if (rode3 != "X")
                    {
                        red3.Content = "-";
                    }

                    if (rode4 != "X")
                    {
                        red4.Content = "-";
                    }

                    if (rode5 != "X")
                    {
                        red5.Content = "-";
                    }
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void red7_Click(object sender, RoutedEventArgs e)
        {
            if (redlocker.Text == "Lock")
            {
                MessageBox.Show("This color is locked");
                return;
            }

            rode7 = red7.Content.ToString();
            if (rode7 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (rode7 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }
            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt3 == 7 || MyInt2 + MyInt3 == 7)
                {
                    red7.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforredcounter();
                    Warningforminus5.Visibility = Visibility.Hidden;

                    if (rode2 != "X")
                    {
                        red2.Content = "-";
                    }

                    if (rode3 != "X")
                    {
                        red3.Content = "-";
                    }

                    if (rode4 != "X")
                    {
                        red4.Content = "-";
                    }

                    if (rode5 != "X")
                    {
                        red5.Content = "-";
                    }

                    if(rode6 != "X")
                    {
                        red6.Content = "-";
                    }
                }
                else
                {
                    MessageBox.Show("There is no way to combine the red 7");
                }
            }

            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 7)
                {
                    red7.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforredcounter();

                    if (rode2 != "X")
                    {
                        red2.Content = "-";
                    }

                    if (rode3 != "X")
                    {
                        red3.Content = "-";
                    }

                    if (rode4 != "X")
                    {
                        red4.Content = "-";
                    }

                    if (rode5 != "X")
                    {
                        red5.Content = "-";
                    }

                    if (rode6 != "X")
                    {
                        red6.Content = "-";
                    }
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void red8_Click(object sender, RoutedEventArgs e)
        {
            if (redlocker.Text == "Lock")
            {
                MessageBox.Show("This color is locked");
                return;
            }

            rode8 = red8.Content.ToString();
            if (rode8 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (rode8 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt3 == 8 || MyInt2 + MyInt3 == 8)
                {
                    red8.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforredcounter();
                    Warningforminus5.Visibility = Visibility.Hidden;

                    if (rode2 != "X")
                    {
                        red2.Content = "-";
                    }

                    if (rode3 != "X")
                    {
                        red3.Content = "-";
                    }

                    if (rode4 != "X")
                    {
                        red4.Content = "-";
                    }

                    if (rode5 != "X")
                    {
                        red5.Content = "-";
                    }

                    if (rode6 != "X")
                    {
                        red6.Content = "-";
                    }

                    if(rode7 != "X")
                    {
                        red7.Content = "-";
                    }
                }
                else
                {
                    MessageBox.Show("There is no way to combine the red 8");
                }
            }

            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 8)
                {
                    red8.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforredcounter();

                    if (rode2 != "X")
                    {
                        red2.Content = "-";
                    }

                    if (rode3 != "X")
                    {
                        red3.Content = "-";
                    }

                    if (rode4 != "X")
                    {
                        red4.Content = "-";
                    }

                    if (rode5 != "X")
                    {
                        red5.Content = "-";
                    }

                    if (rode6 != "X")
                    {
                        red6.Content = "-";
                    }

                    if (rode7 != "X")
                    {
                        red7.Content = "-";
                    }
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }

        }

        private void red9_Click(object sender, RoutedEventArgs e)
        {
            if (redlocker.Text == "Lock")
            {
                MessageBox.Show("This color is locked");
                return;
            }

            rode9 = red9.Content.ToString();
            if (rode9 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (rode9 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt3 == 9 || MyInt2 + MyInt3 == 9)
                {
                    red9.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforredcounter();
                    Warningforminus5.Visibility = Visibility.Hidden;

                    if (rode2 != "X")
                    {
                        red2.Content = "-";
                    }

                    if (rode3 != "X")
                    {
                        red3.Content = "-";
                    }

                    if (rode4 != "X")
                    {
                        red4.Content = "-";
                    }

                    if (rode5 != "X")
                    {
                        red5.Content = "-";
                    }

                    if (rode6 != "X")
                    {
                        red6.Content = "-";
                    }

                    if (rode7 != "X")
                    {
                        red7.Content = "-";
                    }

                    if(rode8 != "X")
                    {
                        red8.Content = "-";
                    }
                }
                else
                {
                    MessageBox.Show("There is no way to combine the red 9");
                }
            }
            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 9)
                {
                    red9.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforredcounter();

                    if (rode2 != "X")
                    {
                        red2.Content = "-";
                    }

                    if (rode3 != "X")
                    {
                        red3.Content = "-";
                    }

                    if (rode4 != "X")
                    {
                        red4.Content = "-";
                    }

                    if (rode5 != "X")
                    {
                        red5.Content = "-";
                    }

                    if (rode6 != "X")
                    {
                        red6.Content = "-";
                    }

                    if (rode7 != "X")
                    {
                        red7.Content = "-";
                    }

                    if (rode8 != "X")
                    {
                        red8.Content = "-";
                    }
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void red10_Click(object sender, RoutedEventArgs e)
        {
            if (redlocker.Text == "Lock")
            {
                MessageBox.Show("This color is locked");
                return;
            }

            rode10 = red10.Content.ToString();
            if (rode10 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (rode10 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }
            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt3 == 10 || MyInt2 + MyInt3 == 10)
                {
                    red10.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforredcounter();
                    Warningforminus5.Visibility = Visibility.Hidden;

                    if (rode2 != "X")
                    {
                        red2.Content = "-";
                    }

                    if (rode3 != "X")
                    {
                        red3.Content = "-";
                    }

                    if (rode4 != "X")
                    {
                        red4.Content = "-";
                    }

                    if (rode5 != "X")
                    {
                        red5.Content = "-";
                    }

                    if (rode6 != "X")
                    {
                        red6.Content = "-";
                    }

                    if (rode7 != "X")
                    {
                        red7.Content = "-";
                    }

                    if (rode8 != "X")
                    {
                        red8.Content = "-";
                    }

                    if(rode9 != "X")
                    {
                        red9.Content = "-";
                    }
                }
                else
                {
                    MessageBox.Show("There is no way to combine the red 10");
                }
            }

            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 10)
                {
                    red10.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforredcounter();

                    if (rode2 != "X")
                    {
                        red2.Content = "-";
                    }

                    if (rode3 != "X")
                    {
                        red3.Content = "-";
                    }

                    if (rode4 != "X")
                    {
                        red4.Content = "-";
                    }

                    if (rode5 != "X")
                    {
                        red5.Content = "-";
                    }

                    if (rode6 != "X")
                    {
                        red6.Content = "-";
                    }

                    if (rode7 != "X")
                    {
                        red7.Content = "-";
                    }

                    if (rode8 != "X")
                    {
                        red8.Content = "-";
                    }

                    if (rode9 != "X")
                    {
                        red9.Content = "-";
                    }
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void red11_Click(object sender, RoutedEventArgs e)
        {
            if (redlocker.Text == "Lock")
            {
                MessageBox.Show("This color is locked");
                return;
            }

            rode11 = red11.Content.ToString();
            if (rode11 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (rode11 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }
            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt3 == 11 || MyInt2 + MyInt3 == 11)
                {
                    red11.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforredcounter();
                    Warningforminus5.Visibility = Visibility.Hidden;

                    if (rode2 != "X")
                    {
                        red2.Content = "-";
                    }

                    if (rode3 != "X")
                    {
                        red3.Content = "-";
                    }

                    if (rode4 != "X")
                    {
                        red4.Content = "-";
                    }

                    if (rode5 != "X")
                    {
                        red5.Content = "-";
                    }

                    if (rode6 != "X")
                    {
                        red6.Content = "-";
                    }

                    if (rode7 != "X")
                    {
                        red7.Content = "-";
                    }

                    if (rode8 != "X")
                    {
                        red8.Content = "-";
                    }

                    if (rode9 != "X")
                    {
                        red9.Content = "-";
                    }

                    if(rode10 != "X")
                    {
                        red10.Content = "-";
                    }
                }
                else
                {
                    MessageBox.Show("There is no way to combine the red 11");
                }
            }

            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 11)
                {
                    red11.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforredcounter();

                    if (rode2 != "X")
                    {
                        red2.Content = "-";
                    }

                    if (rode3 != "X")
                    {
                        red3.Content = "-";
                    }

                    if (rode4 != "X")
                    {
                        red4.Content = "-";
                    }

                    if (rode5 != "X")
                    {
                        red5.Content = "-";
                    }

                    if (rode6 != "X")
                    {
                        red6.Content = "-";
                    }

                    if (rode7 != "X")
                    {
                        red7.Content = "-";
                    }

                    if (rode8 != "X")
                    {
                        red8.Content = "-";
                    }

                    if (rode9 != "X")
                    {
                        red9.Content = "-";
                    }

                    if (rode10 != "X")
                    {
                        red10.Content = "-";
                    }
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void red12_Click(object sender, RoutedEventArgs e)
        {
            if (redlocker.Text == "Lock")
            {
                MessageBox.Show("This color is locked");
                return;
            }

            rode12 = red12.Content.ToString();
            if (rode12 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (rode12 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }
            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt3 == 12 || MyInt2 + MyInt3 == 12)
                {
                    if (redcounter < 15)
                    {
                        MessageBox.Show("You can't choose this number because you don't have enough X'es in the red color");
                        return;
                    }

                    red12.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforredcounter();
                    Warningforminus5.Visibility = Visibility.Hidden;

                    redlocker.Text = "Lock";
                    redlocker.Background = Brushes.Black;
                    redlocker.Foreground = Brushes.White;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the red 12");
                }
            }
            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 12)
                {
                    if (redcounter < 15)
                    {
                        MessageBox.Show("You can't choose this number because you don't have enough X'es in the red color");
                        return;
                    }

                    red12.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforredcounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void yellow2_Click(object sender, RoutedEventArgs e)
        {

            gele2 = yellow2.Content.ToString();
            if (gele2 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (gele2 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt4 == 2 || MyInt2 + MyInt4 == 2)
                {
                    yellow2.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforyellowcounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the yellow 2");
                }
            }

            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 2)
                {
                    yellow2.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforyellowcounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void yellow3_Click(object sender, RoutedEventArgs e)
        {

            gele3 = yellow3.Content.ToString();
            if (gele3 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (gele3 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt4 == 3 || MyInt2 + MyInt4 == 3)
                {
                    yellow3.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforyellowcounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the yellow 3");
                }
            }

            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 3)
                {
                    yellow3.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforyellowcounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void yellow4_Click(object sender, RoutedEventArgs e)
        {

            gele4 = yellow4.Content.ToString();
            if (gele4 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (gele4 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt4 == 4 || MyInt2 + MyInt4 == 4)
                {
                    yellow4.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforyellowcounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the yellow 4");
                }
            }

            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 4)
                {
                    yellow4.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforyellowcounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void yellow5_Click(object sender, RoutedEventArgs e)
        {

            gele5 = yellow5.Content.ToString();
            if (gele5 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (gele5 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt4 == 5 || MyInt2 + MyInt4 == 5)
                {
                    yellow5.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforyellowcounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the yellow 5");
                }
            }

            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 5)
                {
                    yellow5.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforyellowcounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void yellow6_Click(object sender, RoutedEventArgs e)
        {

            gele6 = yellow6.Content.ToString();
            if (gele6 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (gele6 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt4 == 6 || MyInt2 + MyInt4 == 6)
                {
                    yellow6.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforyellowcounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the yellow 6");
                }
            }

            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 6)
                {
                    yellow6.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforyellowcounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void yellow7_Click(object sender, RoutedEventArgs e)
        {

            gele7 = yellow7.Content.ToString();
            if (gele7 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (gele7 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }
            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt4 == 7 || MyInt2 + MyInt4 == 7)
                {
                    yellow7.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforyellowcounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the yellow 7");
                }
            }

            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 7)
                {
                    yellow7.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforyellowcounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void yellow8_Click(object sender, RoutedEventArgs e)
        {

            gele8 = yellow8.Content.ToString();
            if (gele8 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (gele8 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt4 == 8 || MyInt2 + MyInt4 == 8)
                {
                    yellow8.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforyellowcounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the yellow 8");
                }
            }

            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 8)
                {
                    yellow8.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforyellowcounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void yellow9_Click(object sender, RoutedEventArgs e)
        {
            gele9 = yellow9.Content.ToString();
            if (gele9 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (gele9 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt4 == 9 || MyInt2 + MyInt4 == 9)
                {
                    yellow9.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforyellowcounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the yellow 8");
                }
            }

            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 9)
                {
                    yellow9.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforyellowcounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void yellow10_Click(object sender, RoutedEventArgs e)
        {

            gele10 = yellow10.Content.ToString();
            if (gele10 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (gele10 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt4 == 10 || MyInt2 + MyInt4 == 10)
                {
                    yellow10.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforyellowcounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the yellow 10");
                }
            }
            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 10)
                {
                    yellow10.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforyellowcounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void yellow11_Click(object sender, RoutedEventArgs e)
        {

            gele11 = yellow11.Content.ToString();
            if (gele11 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (gele11 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }
            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt4 == 11 || MyInt2 + MyInt4 == 11)
                {
                    yellow11.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforyellowcounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the yellow 11");
                }
            }
            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 11)
                {
                    yellow11.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforyellowcounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void yellow12_Click(object sender, RoutedEventArgs e)
        {
            
            gele12 = yellow12.Content.ToString();
            if (gele12 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (gele12 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt4 == 12 || MyInt2 + MyInt4 == 12)
                {
                    yellow12.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforyellowcounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the yellow 12");
                }
            }
            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 12)
                {
                    yellow12.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforyellowcounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void blue12_Click(object sender, RoutedEventArgs e)
        {

            blauwe12 = blue12.Content.ToString();
            if (blauwe12 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (blauwe12 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt5 == 12 || MyInt2 + MyInt5 == 12)
                {
                    blue12.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforbluecounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the blue 12");
                }
            }
            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 12)
                {
                    blue12.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforbluecounter(); 
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void blue11_Click(object sender, RoutedEventArgs e)
        {

            blauwe11 = blue11.Content.ToString();
            if (blauwe11 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (blauwe11 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt5 == 11 || MyInt2 + MyInt5 == 11)
                {
                    blue11.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforbluecounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the blue 11");
                }
            }
            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 11)
                {
                    blue11.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforbluecounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }

        }

        private void blue10_Click(object sender, RoutedEventArgs e)
        {

            blauwe10 = blue10.Content.ToString();
            if (blauwe10 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (blauwe10 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt5 == 10 || MyInt2 + MyInt5 == 10)
                {
                    blue10.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforbluecounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the blue 10");
                }
            }
            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 10)
                {
                    blue10.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforbluecounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void blue9_Click(object sender, RoutedEventArgs e)
        {

            blauwe9 = blue9.Content.ToString();
            if (blauwe9 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (blauwe9 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt5 == 9 || MyInt2 + MyInt5 == 9)
                {
                    blue9.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforbluecounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the blue 9");
                }
            }
            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 9)
                {
                    blue9.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforbluecounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void blue8_Click(object sender, RoutedEventArgs e)
        {

            blauwe8 = blue8.Content.ToString();
            if (blauwe8 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (blauwe8 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt5 == 8 || MyInt2 + MyInt5 == 8)
                {
                    blue8.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforbluecounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the blue 8");
                }
            }
            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 8)
                {
                    blue8.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforbluecounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }

        }

        private void blue7_Click(object sender, RoutedEventArgs e)
        {

            blauwe7 = blue7.Content.ToString();
            if (blauwe7 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (blauwe7 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt5 == 7 || MyInt2 + MyInt5 == 7)
                {
                    blue7.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforbluecounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the blue 7");
                }
            }
            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 7)
                {
                    blue7.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforbluecounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }

        }

        private void blue6_Click(object sender, RoutedEventArgs e)
        {

            blauwe6 = blue6.Content.ToString();
            if (blauwe6 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (blauwe6 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt5 == 6 || MyInt2 + MyInt5 == 6)
                {
                    blue6.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforbluecounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the blue 6");
                }
            }
            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 6)
                {
                    blue6.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforbluecounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void blue5_Click(object sender, RoutedEventArgs e)
        {

            blauwe5 = blue5.Content.ToString();
            if (blauwe5 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (blauwe5 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt5 == 5 || MyInt2 + MyInt5 == 5)
                {
                    blue5.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforbluecounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the blue 5");
                }
            }
            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 5)
                {
                    blue5.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforbluecounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void blue4_Click(object sender, RoutedEventArgs e)
        {

            blauwe4 = blue4.Content.ToString();
            if (blauwe4 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (blauwe4 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt5 == 4 || MyInt2 + MyInt5 == 4)
                {
                    blue4.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforbluecounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the blue 4");
                }
            }
            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 4)
                {
                    blue4.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforbluecounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void blue3_Click(object sender, RoutedEventArgs e)
        {

            blauwe3 = blue3.Content.ToString();
            if (blauwe3 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (blauwe3 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt5 == 3 || MyInt2 + MyInt5 == 3)
                {
                    blue3.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforbluecounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the blue 3");
                }
            }
            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 3)
                {
                    blue3.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforbluecounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void blue2_Click(object sender, RoutedEventArgs e)
        {

            blauwe2 = blue2.Content.ToString();
            if (blauwe2 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (blauwe2 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt5 == 2 || MyInt2 + MyInt5 == 2)
                {
                    blue2.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforbluecounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the blue 2");
                }
            }
            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 2)
                {
                    blue2.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforbluecounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void green12_Click(object sender, RoutedEventArgs e)
        {

            groene12 = green12.Content.ToString();
            if (groene12 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (groene12 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt6 == 12 || MyInt2 + MyInt6 == 12)
                {
                    green12.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforgreencounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the green 12");
                }
            }
            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 12)
                {
                    green12.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforgreencounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }

        }

        private void green11_Click(object sender, RoutedEventArgs e)
        {

            groene11 = green11.Content.ToString();
            if (groene11 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (groene11 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt6 == 11 || MyInt2 + MyInt6 == 11)
                {
                    green11.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforgreencounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the green 11");
                }
            }
            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 11)
                {
                    green11.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforgreencounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void green10_Click(object sender, RoutedEventArgs e)
        {

            groene10 = green10.Content.ToString();
            if (groene10 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (groene10 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt6 == 10 || MyInt2 + MyInt6 == 10)
                {
                    green10.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforgreencounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the green 10");
                }
            }
            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 10)
                {
                    green10.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforgreencounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void green9_Click(object sender, RoutedEventArgs e)
        {

            groene9 = green9.Content.ToString();
            if (groene9 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (groene9 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt6 == 9 || MyInt2 + MyInt6 == 9)
                {
                    green9.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforgreencounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the green 9");
                }
            }
            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 9)
                {
                    green9.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforgreencounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }

        }

        private void green8_Click(object sender, RoutedEventArgs e)
        {

            groene8 = green8.Content.ToString();
            if (groene8 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (groene8 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt6 == 8 || MyInt2 + MyInt6 == 8)
                {
                    green8.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforgreencounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the green 8");
                }
            }
            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 8)
                {
                    green8.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforgreencounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }

        }

        private void green7_Click(object sender, RoutedEventArgs e)
        {

            groene7 = green7.Content.ToString();
            if (groene7 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (groene7 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt6 == 7 || MyInt2 + MyInt6 == 7)
                {
                    green7.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforgreencounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the green 7");
                }
            }
            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 7)
                {
                    green7.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforgreencounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }

        }

        private void green6_Click(object sender, RoutedEventArgs e)
        {

            groene6 = green6.Content.ToString();
            if (groene6 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (groene6 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt6 == 6 || MyInt2 + MyInt6 == 6)
                {
                    green6.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforgreencounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the green 6");
                }
            }
            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 6)
                {
                    green6.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforgreencounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void green5_Click(object sender, RoutedEventArgs e)
        {

            groene5 = green5.Content.ToString();
            if (groene5 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (groene5 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt6 == 5 || MyInt2 + MyInt6 == 5)
                {
                    green5.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforgreencounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the green 5");
                }
            }
            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 5)
                {
                    green5.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforgreencounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void green4_Click(object sender, RoutedEventArgs e)
        {

            groene4 = green4.Content.ToString();
            if (groene4 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (groene4 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt6 == 4 || MyInt2 + MyInt6 == 4)
                {
                    green4.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforgreencounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the green 4");
                }
            }
            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 4)
                {
                    green4.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforgreencounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }

        }

        private void green3_Click(object sender, RoutedEventArgs e)
        {

            groene3 = green3.Content.ToString();
            if (groene3 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (groene3 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt6 == 3 || MyInt2 + MyInt6 == 3)
                {
                    green3.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforgreencounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the green 3");
                }
            }
            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 3)
                {
                    green3.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforgreencounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }

        }

        private void green2_Click(object sender, RoutedEventArgs e)
        {

            groene2 = green2.Content.ToString();
            if (groene2 == "X")
            {
                MessageBox.Show("This number already has an X");
                return;
            }

            if (groene2 == "-")
            {
                MessageBox.Show("You can't select this number anymore");
                return;
            }

            if (Action.Text == "Action 2")
            {
                if (MyInt1 + MyInt6 == 2 || MyInt2 + MyInt6 == 2)
                {
                    green2.Content = "X";
                    Skipaction2.Visibility = Visibility.Hidden;
                    RollDice.Visibility = Visibility.Visible;
                    Action.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, please roll dice";
                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                    codeforgreencounter();
                    Warningforminus5.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("There is no way to combine the green 2");
                }
            }
            if (Action.Text == "Action 1")
            {
                if (MyInt1 + MyInt2 == 2)
                {
                    green2.Content = "X";
                    Action.Text = "Action 2";
                    Skipaction2.Visibility = Visibility.Visible;
                    Skipaction.Visibility = Visibility.Hidden;
                    aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                    codeforgreencounter();
                }
                else
                {
                    MessageBox.Show("This number is not rolled!");
                }
            }
        }

        private void Skipaction1_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resultturn1 = MessageBox.Show("If you skip this turn, you must do action 2, otherwise we will subtract 5 points from your total score. Are you sure?", "Watch out!", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if(resultturn1 == MessageBoxResult.Yes)
            {
                Action.Text = "Action 2";
                Skipaction2.Visibility = Visibility.Visible;
                Skipaction.Visibility = Visibility.Hidden;
                aanwijzingen.Text = "Player, you can combine one white dice with a colored dice if you want";
                Warningforminus5.Visibility = Visibility.Visible;
            }
            else
            {
                return;
            }
        }

        private void Skipaction2_Click(object sender, RoutedEventArgs e)
        {
            if (Warningforminus5.Visibility == Visibility.Visible)
            {
                MessageBoxResult resultturn2 = MessageBox.Show("If you skip this turn, we will subtract 5 points from your total score, are you sure?", "Watch out!", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (resultturn2 == MessageBoxResult.Yes)
                {
                    Skipaction2.Visibility = Visibility.Hidden;
                    Action.Visibility = Visibility.Hidden;
                    Action.Text = "No action";
                    RollDice.Visibility = Visibility.Visible;
                    aanwijzingen.Text = "Player, please roll dice";
                    Warningforminus5.Visibility = Visibility.Hidden;

                    minus = int.Parse(minusaftrek.Text);
                    minus = minus + 5;

                    minusaftrek.Text = minus.ToString();

                    setblock1invisible();
                    setblock2invisible();
                    setblockredinvisible();
                    setblockyellowinvisible();
                    setblockblueinvisible();
                    setblockgreeninvisible();
                    MyInt1 = 0;
                    MyInt2 = 0;
                    MyInt3 = 0;
                    MyInt4 = 0;
                    MyInt5 = 0;
                    MyInt6 = 0;
                    Action.Text = "";
                }
                else
                {
                    return;
                }
            }

            Skipaction2.Visibility = Visibility.Hidden;
            Action.Visibility = Visibility.Hidden;
            Action.Text = "No action";
            RollDice.Visibility = Visibility.Visible;
            aanwijzingen.Text = "Player, please roll dice";
            setblock1invisible();
            setblock2invisible();
            setblockredinvisible();
            setblockyellowinvisible();
            setblockblueinvisible();
            setblockgreeninvisible();
            MyInt1 = 0;
            MyInt2 = 0;
            MyInt3 = 0;
            MyInt4 = 0;
            MyInt5 = 0;
            MyInt6 = 0;
            Action.Text = "";
        }

        private void codeforredcounter()
        {
            redcounter = int.Parse(countred.Text);
            if(redcounter == 0)
            {
                redcounter = 1;
                countred.Text = redcounter.ToString();
            }

            else if (redcounter == 1)
            {
                redcounter = 3;
                countred.Text = redcounter.ToString();
            }

            else if (redcounter == 3)
            {
                redcounter = 6;
                countred.Text = redcounter.ToString();
            }

            else if (redcounter == 6)
            {
                redcounter = 10;
                countred.Text = redcounter.ToString();
            }

            else if (redcounter == 10)
            {
                redcounter = 15;
                countred.Text = redcounter.ToString();
            }

            else if (redcounter == 15)
            {
                redcounter = 21;
                countred.Text = redcounter.ToString();
            }

            else if (redcounter == 21)
            {
                redcounter = 28;
                countred.Text = redcounter.ToString();
            }

            else if (redcounter == 28)
            {
                redcounter = 36;
                countred.Text = redcounter.ToString();
            }

            else if (redcounter == 36)
            {
                redcounter = 45;
                countred.Text = redcounter.ToString();
            }

            else if (redcounter == 45)
            {
                redcounter = 55;
                countred.Text = redcounter.ToString();
            }

            else if (redcounter == 55)
            {
                redcounter = 66;
                countred.Text = redcounter.ToString();
            }

            else if (redcounter == 66)
            {
                redcounter = 78;
                countred.Text = redcounter.ToString();
            }
        }

        private void codeforyellowcounter()
        {
            yellowcounter = int.Parse(countyellow.Text);
            if (yellowcounter == 0)
            {
                yellowcounter = 1;
                countyellow.Text = yellowcounter.ToString();
            }

            else if (yellowcounter == 1)
            {
                yellowcounter = 3;
                countyellow.Text = yellowcounter.ToString();
            }

            else if (yellowcounter == 3)
            {
                yellowcounter = 6;
                countyellow.Text = yellowcounter.ToString();
            }

            else if (yellowcounter == 6)
            {
                yellowcounter = 10;
                countyellow.Text = yellowcounter.ToString();
            }

            else if (yellowcounter == 10)
            {
                yellowcounter = 15;
                countyellow.Text = yellowcounter.ToString();
            }

            else if (yellowcounter == 15)
            {
                yellowcounter = 21;
                countyellow.Text = yellowcounter.ToString();
            }

            else if (yellowcounter == 21)
            {
                yellowcounter = 28;
                countyellow.Text = yellowcounter.ToString();
            }

            else if (yellowcounter == 28)
            {
                yellowcounter = 36;
                countyellow.Text = yellowcounter.ToString();
            }

            else if (yellowcounter == 36)
            {
                yellowcounter = 45;
                countyellow.Text = yellowcounter.ToString();
            }

            else if (yellowcounter == 45)
            {
                yellowcounter = 55;
                countyellow.Text = yellowcounter.ToString();
            }

            else if (yellowcounter == 55)
            {
                yellowcounter = 66;
                countyellow.Text = yellowcounter.ToString();
            }

            else if (yellowcounter == 66)
            {
                yellowcounter = 78;
                countyellow.Text = yellowcounter.ToString();
            }
        }

        private void codeforbluecounter()
        {
            bluecounter = int.Parse(countblue.Text);
            if (bluecounter == 0)
            {
                bluecounter = 1;
                countblue.Text = bluecounter.ToString();
            }

            else if (bluecounter == 1)
            {
                bluecounter = 3;
                countblue.Text = bluecounter.ToString();
            }

            else if (bluecounter == 3)
            {
                bluecounter = 6;
                countblue.Text = bluecounter.ToString();
            }

            else if (bluecounter == 6)
            {
                bluecounter = 10;
                countblue.Text = bluecounter.ToString();
            }

            else if (bluecounter == 10)
            {
                bluecounter = 15;
                countblue.Text = bluecounter.ToString();
            }

            else if (bluecounter == 15)
            {
                bluecounter = 21;
                countblue.Text = bluecounter.ToString();
            }

            else if (bluecounter == 21)
            {
                bluecounter = 28;
                countblue.Text = bluecounter.ToString();
            }

            else if (bluecounter == 28)
            {
                bluecounter = 36;
                countblue.Text = bluecounter.ToString();
            }

            else if (bluecounter == 36)
            {
                bluecounter = 45;
                countblue.Text = bluecounter.ToString();
            }

            else if (bluecounter == 45)
            {
                bluecounter = 55;
                countblue.Text = bluecounter.ToString();
            }

            else if (bluecounter == 55)
            {
                bluecounter = 66;
                countblue.Text = bluecounter.ToString();
            }

            else if (bluecounter == 66)
            {
                bluecounter = 78;
                countblue.Text = bluecounter.ToString();
            }
        }

        private void codeforgreencounter()
        {
            greencounter = int.Parse(countgreen.Text);
            if (greencounter == 0)
            {
                greencounter = 1;
                countgreen.Text = greencounter.ToString();
            }

            else if (greencounter == 1)
            {
                greencounter = 3;
                countgreen.Text = greencounter.ToString();
            }

            else if (greencounter == 3)
            {
                greencounter = 6;
                countgreen.Text = greencounter.ToString();
            }

            else if (greencounter == 6)
            {
                greencounter = 10;
                countgreen.Text = greencounter.ToString();
            }

            else if (greencounter == 10)
            {
                greencounter = 15;
                countgreen.Text = greencounter.ToString();
            }

            else if (greencounter == 15)
            {
                greencounter = 21;
                countgreen.Text = greencounter.ToString();
            }

            else if (greencounter == 21)
            {
                greencounter = 28;
                countgreen.Text = greencounter.ToString();
            }

            else if (greencounter == 28)
            {
                greencounter = 36;
                countgreen.Text = greencounter.ToString();
            }

            else if (greencounter == 36)
            {
                greencounter = 45;
                countgreen.Text = greencounter.ToString();
            }

            else if (greencounter == 45)
            {
                greencounter = 55;
                countgreen.Text = greencounter.ToString();
            }

            else if (greencounter == 55)
            {
                greencounter = 66;
                countgreen.Text = greencounter.ToString();
            }

            else if (greencounter == 66)
            {
                greencounter = 78;
                countgreen.Text = greencounter.ToString();
            }
        }
    }
}
