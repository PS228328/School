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

namespace WpfAppEindprojectOp12021
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double getal;
        double macht;
        double uitkomst;
        double count;
        double uitkomstnegatief;

        Random _myRandom1 = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btOne_Click(object sender, RoutedEventArgs e)
        {
            if (btOne.Background == Brushes.DarkGray)
            {
                btOne.Background = Brushes.LightGray;
                btOne.Content = "Button 1 is pressed";
            }
            else if (btOne.Background == Brushes.LightGray)
            {
                btOne.Background = Brushes.DarkGray;
                btOne.Content = "Button 1";
            }
            DoMyThing();
        }

        private void btTwo_Click(object sender, RoutedEventArgs e)
        {
            if (btTwo.Background == Brushes.DarkGray)
            {
                btTwo.Background = Brushes.LightGray;
                btTwo.Content = "Button 2 is pressed";
            }
            else if (btTwo.Background == Brushes.LightGray)
            {
                btTwo.Background = Brushes.DarkGray;
                btTwo.Content = "Button 2";
            }
            DoMyThing();
        }

        private void btThree_Click(object sender, RoutedEventArgs e)
        {
            if (btThree.Background == Brushes.DarkGray)
            {
                btThree.Background = Brushes.LightGray;
                btThree.Content = "Button 3 is pressed";
            }
            else if (btThree.Background == Brushes.LightGray)
            {
                btThree.Background = Brushes.DarkGray;
                btThree.Content = "Button 3";
            }
            DoMyThing();
        }

        private void btFour_Click(object sender, RoutedEventArgs e)
        {
            if (btFour.Background == Brushes.DarkGray)
            {
                btFour.Background = Brushes.LightGray;
                btFour.Content = "Button 4 is pressed";
            }
            else if (btFour.Background == Brushes.LightGray)
            {
                btFour.Background = Brushes.DarkGray;
                btFour.Content = "Button 4";
            }
            DoMyThing();
        }
        private void DoMyThing()
        {
            if (btOne.Background == Brushes.DarkGray && btTwo.Background == Brushes.DarkGray && btThree.Background == Brushes.DarkGray && btFour.Background == Brushes.DarkGray)
            {
                gridColor.Background = Brushes.White;
            }
            else if (btOne.Background == Brushes.LightGray && btTwo.Background == Brushes.DarkGray && btThree.Background == Brushes.DarkGray && btFour.Background == Brushes.DarkGray)
            {
                gridColor.Background = Brushes.Red;
            }
            else if (btOne.Background == Brushes.LightGray && btTwo.Background == Brushes.LightGray && btThree.Background == Brushes.LightGray && btFour.Background == Brushes.DarkGray)
            {
                gridColor.Background = Brushes.Green;
            }
            else if (btOne.Background == Brushes.LightGray && btTwo.Background == Brushes.LightGray && btThree.Background != Brushes.LightGray)
            {
                gridColor.Background = Brushes.Yellow;
            }
            else if (btOne.Background == Brushes.DarkGray && btTwo.Background == Brushes.DarkGray && btThree.Background == Brushes.LightGray && btFour.Background == Brushes.LightGray)
            {
                gridColor.Background = Brushes.Blue;
            }
            else if (btOne.Background == Brushes.LightGray && btTwo.Background == Brushes.LightGray && btThree.Background == Brushes.LightGray && btFour.Background == Brushes.LightGray)
            {
                gridColor.Background = Brushes.Black;
            }
            else
            {
                gridColor.Background = Brushes.Purple;
            }
        }

        int counter = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (counter > 3)
            {
                counter = counter - 5;
                tbCounter.Text = counter.ToString();
            }

            counter = Int32.Parse(tbCounter.Text);
            counter++;

            tbCounter.Text = counter.ToString();
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            try
            {
                getal = Double.Parse(tbBegingetal.Text);
                macht = Double.Parse(tbPower.Text);
                uitkomst = getal;

                tbReeks.Text = "";

                if (macht == 0)
                {
                    tbReeks.Text = "1";
                    return;
                }

                if (macht == 1)
                {
                    tbReeks.Text = getal.ToString() + ",";
                    return;
                }

                count = 1;

                tbReeks.Text = tbReeks.Text + getal.ToString() + ", ";

                while (macht > count)
                {
                    uitkomst = uitkomst * getal;
                    tbReeks.Text = tbReeks.Text + uitkomst.ToString() + ", ";
                    count++;
                }

                if (macht < 0)
                {
                    macht = -1 * macht;
                    count = 0;
                    uitkomstnegatief = getal;
                    

                    while (macht > count)
                    {
                        uitkomst = 1 / getal;
                        getal = getal * uitkomstnegatief;
                        tbReeks.Text = tbReeks.Text + uitkomst.ToString() + ", ";
                        count++;
                    }

                }

                //Wanneer de macht 4 is, moet de while loop 4x lopen
            }
            catch (Exception)
            {
                MessageBox.Show("Vul aub een geldig getal in in beide vakken");
            }
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string invoer = tbAnimal.Text.ToLower();

            switch (invoer)
            {
                case "paard":
                    MessageBox.Show("Dit is het 1e dier in de combobox");
                    break;
                case "ezel":
                    MessageBox.Show("Dit is het 2e dier in de combobox");
                    break;
                case "giraf":
                    MessageBox.Show("Dit is het 3e dier in de combobox");
                    break;
                case "aap":
                    MessageBox.Show("Dit is het 4e dier in de combobox");
                    break;
                case "leeuw":
                    MessageBox.Show("Dit is het 5e dier in de combobox");
                    break;
                default:
                    MessageBoxResult Test = MessageBox.Show("Het lijkt erop dat dit dier nog niet in de lijst staat, wil je het toevoegen?", "Dier toevoegen", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (Test == MessageBoxResult.Yes)
                    {
                        ComboBoxItem myItem = new ComboBoxItem();
                        myItem.Content = invoer;
                        cmbAnimals.Items.Add(myItem);
                    }
                    break;
            }
        }

        double input;
        double output = 0;

        private void For_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                input = double.Parse(tbforJoris.Text);
                output = double.Parse(forJoris.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Vul aub een getal in!");
            }

            for (int a = 0; a < input; a++)
            {
                if (input == output || input < output)
                {
                    return;
                }
                MessageBoxResult mynewResult = MessageBox.Show("De teller staat nu op " + output + " wil je doorgaan?", "Doortellen", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (mynewResult == MessageBoxResult.Yes)
                {
                    output++;
                    forJoris.Text = output.ToString();
                }
                else
                {
                    return;
                }
            }
        }

        private void btTime_Click(object sender, RoutedEventArgs e)
        {
            int uur;
            int minuut;

            try
            {
                uur = Int32.Parse(tbUurAmsterdam.Text);
                minuut = Int32.Parse(tbMinutenAmsterdam.Text);

                if (uur < 0 || uur > 23 || minuut < 0 || minuut > 59)
                {
                    MessageBox.Show("Vul bij uren aub een HEEL getal in tussen 0 en 24, en bij minuten een HEEL getal tussen 0 en 60");
                    return;
                }

                if (uur > 0 && uur < 12)
                {
                    tbAMPMuren.Text = uur.ToString();
                    tbAMPMminuten.Text = minuut.ToString();
                    btTimeAMPM.Text = "AM";
                }
                else if (uur == 12)
                {
                    tbAMPMuren.Text = uur.ToString();
                    tbAMPMminuten.Text = minuut.ToString();
                    btTimeAMPM.Text = "PM";
                }
                else if (uur > 12 && uur < 24)
                {
                    uur = uur - 12;
                    tbAMPMuren.Text = uur.ToString();
                    tbAMPMminuten.Text = minuut.ToString();
                    btTimeAMPM.Text = "PM";
                }
                else if (uur == 0)
                {
                    uur = uur + 12;
                    tbAMPMuren.Text = uur.ToString();
                    tbAMPMminuten.Text = minuut.ToString();
                    btTimeAMPM.Text = "AM";
                }
                if (minuut < 10)
                {
                    tbAMPMminuten.Text = 0 + minuut.ToString();
                }
                if (uur < 10)
                {
                    tbAMPMuren.Text = 0 + uur.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vul bij uren aub een HEEL getal in tussen 0 en 24, en bij minuten een HEEL getal tussen 0 en 60");
            }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int myInt1 = _myRandom1.Next(1, 7);
            int myInt2 = _myRandom1.Next(1, 7);

            if (myInt1 == 1 && myInt2 == 1)
            {
                SetAllElementsInvisible();
                block11.Visibility = Visibility.Visible;
                block21.Visibility = Visibility.Visible;

                dicecounter.Text = "2";
            }
            else if (myInt1 == 1 && myInt2 == 2)
            {
                SetAllElementsInvisible();
                block11.Visibility = Visibility.Visible;
                block22.Visibility = Visibility.Visible;

                dicecounter.Text = "3";
            }
            else if (myInt1 == 1 && myInt2 == 3)
            {
                SetAllElementsInvisible();
                block11.Visibility = Visibility.Visible;
                block23.Visibility = Visibility.Visible;

                dicecounter.Text = "4";
            }
            else if (myInt1 == 1 && myInt2 == 4)
            {
                SetAllElementsInvisible();
                block11.Visibility = Visibility.Visible;
                block24.Visibility = Visibility.Visible;

                dicecounter.Text = "5";
            }
            else if (myInt1 == 1 && myInt2 == 5)
            {
                SetAllElementsInvisible();
                block11.Visibility = Visibility.Visible;
                block25.Visibility = Visibility.Visible;

                dicecounter.Text = "6";
            }
            else if (myInt1 == 1 && myInt2 == 6)
            {
                SetAllElementsInvisible();
                block11.Visibility = Visibility.Visible;
                block26.Visibility = Visibility.Visible;

                dicecounter.Text = "7";
            }
            else if (myInt1 == 2 && myInt2 == 1)
            {
                SetAllElementsInvisible();
                block12.Visibility = Visibility.Visible;
                block21.Visibility = Visibility.Visible;

                dicecounter.Text = "3";
            }
            else if (myInt1 == 2 && myInt2 == 2)
            {
                SetAllElementsInvisible();
                block12.Visibility = Visibility.Visible;
                block22.Visibility = Visibility.Visible;

                dicecounter.Text = "4";
            }
            else if (myInt1 == 2 && myInt2 == 3)
            {
                SetAllElementsInvisible();
                block12.Visibility = Visibility.Visible;
                block23.Visibility = Visibility.Visible;

                dicecounter.Text = "5";
            }
            else if (myInt1 == 2 && myInt2 == 4)
            {
                SetAllElementsInvisible();
                block12.Visibility = Visibility.Visible;
                block24.Visibility = Visibility.Visible;

                dicecounter.Text = "6";
            }
            else if (myInt1 == 2 && myInt2 == 5)
            {
                SetAllElementsInvisible();
                block12.Visibility = Visibility.Visible;
                block25.Visibility = Visibility.Visible;

                dicecounter.Text = "7";
            }
            else if (myInt1 == 2 && myInt2 == 6)
            {
                SetAllElementsInvisible();
                block12.Visibility = Visibility.Visible;
                block26.Visibility = Visibility.Visible;

                dicecounter.Text = "8";
            }
            else if (myInt1 == 3 && myInt2 == 1)
            {
                SetAllElementsInvisible();
                block13.Visibility = Visibility.Visible;
                block21.Visibility = Visibility.Visible;

                dicecounter.Text = "4";
            }
            else if (myInt1 == 3 && myInt2 == 2)
            {
                SetAllElementsInvisible();
                block13.Visibility = Visibility.Visible;
                block22.Visibility = Visibility.Visible;

                dicecounter.Text = "5";
            }
            else if (myInt1 == 3 && myInt2 == 3)
            {
                SetAllElementsInvisible();
                block13.Visibility = Visibility.Visible;
                block23.Visibility = Visibility.Visible;

                dicecounter.Text = "6";
            }
            else if (myInt1 == 3 && myInt2 == 4)
            {
                SetAllElementsInvisible();
                block13.Visibility = Visibility.Visible;
                block24.Visibility = Visibility.Visible;

                dicecounter.Text = "7";
            }
            else if (myInt1 == 3 && myInt2 == 5)
            {
                SetAllElementsInvisible();
                block13.Visibility = Visibility.Visible;
                block25.Visibility = Visibility.Visible;

                dicecounter.Text = "8";
            }
            else if (myInt1 == 3 && myInt2 == 6)
            {
                SetAllElementsInvisible();
                block13.Visibility = Visibility.Visible;
                block26.Visibility = Visibility.Visible;

                dicecounter.Text = "9";
            }

            else if (myInt1 == 4 && myInt2 == 1)
            {
                SetAllElementsInvisible();
                block14.Visibility = Visibility.Visible;
                block21.Visibility = Visibility.Visible;

                dicecounter.Text = "5";
            }
            else if (myInt1 == 4 && myInt2 == 2)
            {
                SetAllElementsInvisible();
                block14.Visibility = Visibility.Visible;
                block22.Visibility = Visibility.Visible;

                dicecounter.Text = "6";
            }
            else if (myInt1 == 4 && myInt2 == 3)
            {
                SetAllElementsInvisible();
                block14.Visibility = Visibility.Visible;
                block23.Visibility = Visibility.Visible;

                dicecounter.Text = "7";
            }
            else if (myInt1 == 4 && myInt2 == 4)
            {
                SetAllElementsInvisible();
                block14.Visibility = Visibility.Visible;
                block24.Visibility = Visibility.Visible;

                dicecounter.Text = "8";
            }
            else if (myInt1 == 4 && myInt2 == 5)
            {
                SetAllElementsInvisible();
                block14.Visibility = Visibility.Visible;
                block25.Visibility = Visibility.Visible;

                dicecounter.Text = "9";
            }
            else if (myInt1 == 4 && myInt2 == 6)
            {
                SetAllElementsInvisible();
                block14.Visibility = Visibility.Visible;
                block26.Visibility = Visibility.Visible;

                dicecounter.Text = "10";
            }
            else if (myInt1 == 5 && myInt2 == 1)
            {
                SetAllElementsInvisible();
                block15.Visibility = Visibility.Visible;
                block21.Visibility = Visibility.Visible;

                dicecounter.Text = "6";
            }
            else if (myInt1 == 5 && myInt2 == 2)
            {
                SetAllElementsInvisible();
                block15.Visibility = Visibility.Visible;
                block22.Visibility = Visibility.Visible;

                dicecounter.Text = "7";
            }
            else if (myInt1 == 5 && myInt2 == 3)
            {
                SetAllElementsInvisible();
                block15.Visibility = Visibility.Visible;
                block23.Visibility = Visibility.Visible;

                dicecounter.Text = "8";
            }
            else if (myInt1 == 5 && myInt2 == 4)
            {
                SetAllElementsInvisible();
                block15.Visibility = Visibility.Visible;
                block24.Visibility = Visibility.Visible;

                dicecounter.Text = "9";
            }
            else if (myInt1 == 5 && myInt2 == 5)
            {
                SetAllElementsInvisible();
                block15.Visibility = Visibility.Visible;
                block25.Visibility = Visibility.Visible;

                dicecounter.Text = "10";
            }
            else if (myInt1 == 5 && myInt2 == 6)
            {
                SetAllElementsInvisible();
                block15.Visibility = Visibility.Visible;
                block26.Visibility = Visibility.Visible;

                dicecounter.Text = "11";
            }
            else if (myInt1 == 6 && myInt2 == 1)
            {
                SetAllElementsInvisible();
                block16.Visibility = Visibility.Visible;
                block21.Visibility = Visibility.Visible;

                dicecounter.Text = "7";
            }
            else if (myInt1 == 6 && myInt2 == 2)
            {
                SetAllElementsInvisible();
                block16.Visibility = Visibility.Visible;
                block22.Visibility = Visibility.Visible;

                dicecounter.Text = "8";
            }
            else if (myInt1 == 6 && myInt2 == 3)
            {
                SetAllElementsInvisible();
                block16.Visibility = Visibility.Visible;
                block23.Visibility = Visibility.Visible;

                dicecounter.Text = "9";
            }
            else if (myInt1 == 6 && myInt2 == 4)
            {
                SetAllElementsInvisible();
                block16.Visibility = Visibility.Visible;
                block24.Visibility = Visibility.Visible;

                dicecounter.Text = "10";
            }
            else if (myInt1 == 6 && myInt2 == 5)
            {
                SetAllElementsInvisible();
                block16.Visibility = Visibility.Visible;
                block25.Visibility = Visibility.Visible;

                dicecounter.Text = "11";
            }
            else if (myInt1 == 6 && myInt2 == 6)
            {
                SetAllElementsInvisible();
                block16.Visibility = Visibility.Visible;
                block26.Visibility = Visibility.Visible;

                dicecounter.Text = "12";
            }
        }
        private void SetAllElementsInvisible()
        {
            block11.Visibility = Visibility.Hidden;
            block12.Visibility = Visibility.Hidden;
            block13.Visibility = Visibility.Hidden;
            block14.Visibility = Visibility.Hidden;
            block15.Visibility = Visibility.Hidden;
            block16.Visibility = Visibility.Hidden;
            block21.Visibility = Visibility.Hidden;
            block22.Visibility = Visibility.Hidden;
            block23.Visibility = Visibility.Hidden;
            block24.Visibility = Visibility.Hidden;
            block25.Visibility = Visibility.Hidden;
            block26.Visibility = Visibility.Hidden;
        }


    }
}
