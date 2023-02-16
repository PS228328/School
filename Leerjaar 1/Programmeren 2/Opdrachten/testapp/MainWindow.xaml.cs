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

namespace testapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer _timer = new DispatcherTimer();
        string[] _myQuestions = { "", "", "", "", "", "", "", "", "", "", "", "" };
        string[] _myAnswers = { "", "", "", "", "", "", "", "", "", "", "", "" };
        double[] _Answers = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,};
        int[] _sumPickSaver = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,};
        Random _myRandom = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tijdens dit onderdeel kun je, in tegenstelling tot onderdeel 1, door de vragen heen bladeren. Je krijgt 12 vragen waar je er minimaal 10 goed moet hebben. Je krijgt voor alle vragen samen 10 minuten de tijd.");
            MessageBoxResult myResult = MessageBox.Show("Wil je doorgaan? Terugkeren is niet meer mogelijk hierna", "Doorgaan?", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (myResult == MessageBoxResult.Yes)
            {
                btStart.Visibility = Visibility.Hidden;
                tbOnderdeel.Visibility = Visibility.Hidden;
                myPanel.Visibility = Visibility.Visible;
                legenda.Visibility = Visibility.Visible;
                tbSum.Visibility = Visibility.Visible;
                tbEqual.Visibility = Visibility.Visible;
                tbAnswer.Visibility = Visibility.Visible;

                int counter = 0;

                while (counter < 12)
                {
                    int sumpicker = _myRandom.Next(1, 7);
                    int randompm1;
                    int randomkd1;
                    int randompm2;
                    int randomkd2;
                    int random3;
                    int random4;

                    string qu;

                    if (sumpicker == 1)
                    {
                        randompm1 = _myRandom.Next(1, 100);
                        randompm2 = _myRandom.Next(1, 100);
                        randomkd1 = _myRandom.Next(1, 10);
                        randomkd2 = _myRandom.Next(1, 10);

                        if (randompm2 > randompm1)
                        {
                            qu = randomkd1 + " * " + randomkd2 + " + " + randompm2 + " - " + randompm1;
                            _Answers[counter] = randomkd1 * randomkd2 + randompm2 - randompm1;
                        }
                        else
                        {
                            qu = randomkd1 + " * " + randomkd2 + " + " + randompm1 + " - " + randompm2;
                            _Answers[counter] = randomkd1 * randomkd2 + randompm1 - randompm2;
                        }
                        _myQuestions[counter] = qu;
                        _sumPickSaver[counter] = sumpicker;
                    }
                    else if (sumpicker == 2)
                    {
                        randompm1 = _myRandom.Next(1, 20);
                        randompm2 = _myRandom.Next(1, 20);
                        randomkd1 = _myRandom.Next(1, 20);
                        randomkd2 = _myRandom.Next(1, 20);
                        random3 = _myRandom.Next(20, 150);
                        if (randompm2 > randompm1)
                        {
                            qu = randompm2 + " + " + randompm1 + " * (" + randomkd1 + " + " + randomkd2 + ") + " + random3;
                            _Answers[counter] = randompm2 + randompm1 * (randomkd1 + randomkd2) + random3;
                        }
                        else
                        {
                            qu = randompm2 + " + " + randompm1 + " * (" + randomkd1 + " + " + randomkd2 + ") + " + random3;
                            _Answers[counter] = randompm2 + randompm1 * (randomkd1 + randomkd2) + random3;
                        }
                        _myQuestions[counter] = qu;
                        _sumPickSaver[counter] = sumpicker;
                    }
                    else if (sumpicker == 3)
                    {
                        randompm1 = _myRandom.Next(1, 9);
                        randompm2 = _myRandom.Next(1, 9);
                        randomkd1 = _myRandom.Next(1, 16);
                        randomkd2 = _myRandom.Next(1, 50);

                        qu = randompm1 + " * " + randompm2 + " * " + randomkd1 + " - " + randomkd2;
                        _Answers[counter] = randompm1 * randompm2 * randomkd1 - randomkd2;

                        _myQuestions[counter] = qu;
                        _sumPickSaver[counter] = sumpicker;
                    }
                    else if (sumpicker == 4)
                    {
                        randompm1 = _myRandom.Next(1, 13);
                        randompm2 = _myRandom.Next(1, 10);
                        randomkd1 = _myRandom.Next(1, 15);
                        randomkd2 = _myRandom.Next(40, 251);

                        qu = randompm1 + " * (" + randompm2 + " + " + randomkd1 + ") - " + randomkd2;
                        _Answers[counter] = randompm1 * (randompm2 + randomkd1) - randomkd2;

                        _myQuestions[counter] = qu;
                        _sumPickSaver[counter] = sumpicker;
                    }
                    else if (sumpicker == 5)
                    {
                        randompm1 = _myRandom.Next(1, 20);
                        randompm2 = _myRandom.Next(1, 7);
                        randomkd1 = _myRandom.Next(1, 20);
                        randomkd2 = _myRandom.Next(1, 20);

                        qu = randompm1 + " + " + randompm2 + " * " + randomkd1 + " - " + randomkd2;
                        _Answers[counter] = randompm1 + randompm2 * randomkd1 - randomkd2;

                        _myQuestions[counter] = qu;
                        _sumPickSaver[counter] = sumpicker;
                    }
                    else if (sumpicker == 6)
                    {
                        randompm1 = _myRandom.Next(1, 60);
                        randompm2 = _myRandom.Next(1, 60);
                        randomkd1 = _myRandom.Next(1, 60);
                        randomkd2 = _myRandom.Next(1, 60);
                        random3 = _myRandom.Next(1, 20);
                        random4 = _myRandom.Next(3, 8);

                        qu = randompm1 + " + " + randompm2 + " + " + randomkd1 + " - " + randomkd2 + " + " + random3 + " * " + random4;
                        _Answers[counter] = randompm1 + randompm2 + randomkd1 - randomkd2 + random3 * random4;

                        _myQuestions[counter] = qu;
                        _sumPickSaver[counter] = sumpicker;
                    }
                    counter++;
                }
                _timer.Start();
                _timer.Interval = TimeSpan.FromSeconds(1);
                _timer.Tick += _timer_Tick;

                MessageBox.Show("Selecteer een vakje om de vraag te zien");
            }
            else
            {
                return;
            }
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            string MandS = time.Text;
            string[] split = MandS.Split(':');

            int minutes = Int32.Parse(split[0]);
            int seconds = Int32.Parse(split[1]);

            if (seconds == 0)
            {
                minutes--;
                seconds = 59;

                if (seconds < 10)
                {
                    time.Text = minutes.ToString() + ":0" + seconds.ToString();
                }
                else
                {
                    time.Text = minutes.ToString() + ":" + seconds.ToString();
                }
            }
            else
            {
                seconds--;

                if (seconds < 10)
                {
                    time.Text = minutes.ToString() + ":0" + seconds.ToString();
                }
                else
                {
                    time.Text = minutes.ToString() + ":" + seconds.ToString();
                }
            }

            if (minutes == 0 && seconds == 0)
            {
                _timer.Stop();
            }
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            if (tbAnswer.Text != "")
            {
                saveAnswer();
            }
            setAllButtonsBlue();
            bt1.Background = Brushes.PaleVioletRed;
            tbSum.Text = _myQuestions[0];
            tbAnswer.Text = _myAnswers[0];
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            if (tbAnswer.Text != "")
            {
                saveAnswer();
            }
            setAllButtonsBlue();
            bt2.Background = Brushes.PaleVioletRed;
            tbSum.Text = _myQuestions[1];
            tbAnswer.Text = _myAnswers[1];
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            if (tbAnswer.Text != "")
            {
                saveAnswer();
            }
            setAllButtonsBlue();
            bt3.Background = Brushes.PaleVioletRed;
            tbSum.Text = _myQuestions[2];
            tbAnswer.Text = _myAnswers[2];
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            if (tbAnswer.Text != "")
            {
                saveAnswer();
            }
            setAllButtonsBlue();
            bt4.Background = Brushes.PaleVioletRed;
            tbSum.Text = _myQuestions[3];
            tbAnswer.Text = _myAnswers[3];
        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            if (tbAnswer.Text != "")
            {
                saveAnswer();
            }
            setAllButtonsBlue();
            bt5.Background = Brushes.PaleVioletRed;
            tbSum.Text = _myQuestions[4];
            tbAnswer.Text = _myAnswers[4];
        }

        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            if (tbAnswer.Text != "")
            {
                saveAnswer();
            }
            setAllButtonsBlue();
            bt6.Background = Brushes.PaleVioletRed;
            tbSum.Text = _myQuestions[5];
            tbAnswer.Text = _myAnswers[5];
        }

        private void bt7_Click(object sender, RoutedEventArgs e)
        {
            if (tbAnswer.Text != "")
            {
                saveAnswer();
            }
            setAllButtonsBlue();
            bt7.Background = Brushes.PaleVioletRed;
            tbSum.Text = _myQuestions[6];
            tbAnswer.Text = _myAnswers[6];
        }

        private void bt8_Click(object sender, RoutedEventArgs e)
        {
            if (tbAnswer.Text != "")
            {
                saveAnswer();
            }
            setAllButtonsBlue();
            bt8.Background = Brushes.PaleVioletRed;
            tbSum.Text = _myQuestions[7];
            tbAnswer.Text = _myAnswers[7];
        }

        private void bt9_Click(object sender, RoutedEventArgs e)
        {
            if (tbAnswer.Text != "")
            {
                saveAnswer();
            }
            setAllButtonsBlue();
            bt9.Background = Brushes.PaleVioletRed;
            tbSum.Text = _myQuestions[8];
            tbAnswer.Text = _myAnswers[8];
        }

        private void bt10_Click(object sender, RoutedEventArgs e)
        {
            if (tbAnswer.Text != "")
            {
                saveAnswer();
            }
            setAllButtonsBlue();
            bt10.Background = Brushes.PaleVioletRed;
            tbSum.Text = _myQuestions[9];
            tbAnswer.Text = _myAnswers[9];
        }

        private void bt11_Click(object sender, RoutedEventArgs e)
        {
            if (tbAnswer.Text != "")
            {
                saveAnswer();
            }
            setAllButtonsBlue();
            bt11.Background = Brushes.PaleVioletRed;
            tbSum.Text = _myQuestions[10];
            tbAnswer.Text = _myAnswers[10];
        }

        private void bt12_Click(object sender, RoutedEventArgs e)
        {
            if (tbAnswer.Text != "")
            {
                saveAnswer();
            }
            setAllButtonsBlue();
            bt12.Background = Brushes.PaleVioletRed;
            tbSum.Text = _myQuestions[11];
            tbAnswer.Text = _myAnswers[11];
        }

        private void setAllButtonsBlue()
        {
            if (_myAnswers[0] != "")
            {
                bt1.Background = Brushes.LawnGreen;
            }
            else
            {
                bt1.Background = Brushes.Cyan;
            }

            if (_myAnswers[1] != "")
            {
                bt2.Background = Brushes.LawnGreen;
            }
            else
            {
                bt2.Background = Brushes.Cyan;
            }

            if (_myAnswers[2] != "")
            {
                bt3.Background = Brushes.LawnGreen;
            }
            else
            {
                bt3.Background = Brushes.Cyan;
            }

            if (_myAnswers[3] != "")
            {
                bt4.Background = Brushes.LawnGreen;
            }
            else
            {
                bt4.Background = Brushes.Cyan;
            }

            if (_myAnswers[4] != "")
            {
                bt5.Background = Brushes.LawnGreen;
            }
            else
            {
                bt5.Background = Brushes.Cyan;
            }

            if (_myAnswers[5] != "")
            {
                bt6.Background = Brushes.LawnGreen;
            }
            else
            {
                bt6.Background = Brushes.Cyan;
            }

            if (_myAnswers[6] != "")
            {
                bt7.Background = Brushes.LawnGreen;
            }
            else
            {
                bt7.Background = Brushes.Cyan;
            }

            if (_myAnswers[7] != "")
            {
                bt8.Background = Brushes.LawnGreen;
            }
            else
            {
                bt8.Background = Brushes.Cyan;
            }

            if (_myAnswers[8] != "")
            {
                bt9.Background = Brushes.LawnGreen;
            }
            else
            {
                bt9.Background = Brushes.Cyan;
            }

            if (_myAnswers[9] != "")
            {
                bt10.Background = Brushes.LawnGreen;
            }
            else
            {
                bt10.Background = Brushes.Cyan;
            }

            if (_myAnswers[10] != "")
            {
                bt11.Background = Brushes.LawnGreen;
            }
            else
            {
                bt11.Background = Brushes.Cyan;
            }

            if (_myAnswers[11] != "")
            {
                bt12.Background = Brushes.LawnGreen;
            }
            else
            {
                bt12.Background = Brushes.Cyan;
            }
        }

        private void saveAnswer()
        {
            if (bt1.Background == Brushes.PaleVioletRed)
            {
                _myAnswers[0] = tbAnswer.Text;
            }
            else if (bt2.Background == Brushes.PaleVioletRed)
            {
                _myAnswers[1] = tbAnswer.Text;
            }
            else if (bt3.Background == Brushes.PaleVioletRed)
            {
                _myAnswers[2] = tbAnswer.Text;
            }
            else if (bt4.Background == Brushes.PaleVioletRed)
            {
                _myAnswers[3] = tbAnswer.Text;
            }
            else if (bt5.Background == Brushes.PaleVioletRed)
            {
                _myAnswers[4] = tbAnswer.Text;
            }
            else if (bt6.Background == Brushes.PaleVioletRed)
            {
                _myAnswers[5] = tbAnswer.Text;
            }
            else if (bt7.Background == Brushes.PaleVioletRed)
            {
                _myAnswers[6] = tbAnswer.Text;
            }
            else if (bt8.Background == Brushes.PaleVioletRed)
            {
                _myAnswers[7] = tbAnswer.Text;
            }
            else if (bt9.Background == Brushes.PaleVioletRed)
            {
                _myAnswers[8] = tbAnswer.Text;
            }
            else if (bt10.Background == Brushes.PaleVioletRed)
            {
                _myAnswers[9] = tbAnswer.Text;
            }
            else if (bt11.Background == Brushes.PaleVioletRed)
            {
                _myAnswers[10] = tbAnswer.Text;
            }
            else if (bt12.Background == Brushes.PaleVioletRed)
            {
                _myAnswers[11] = tbAnswer.Text;
            }
        }

        private void btEnd_Click(object sender, RoutedEventArgs e)
        {
            int totaalgoed = 0;
            int counter = 0;
            while (counter < 12)
            {
                string[] a = _myQuestions[counter].Split(' ');
                if (_sumPickSaver[counter] == 1)
                {
                    double d1 = Double.Parse(a[0]);
                    double d2 = Double.Parse(a[2]);
                    double d3 = Double.Parse(a[4]);
                    double d4 = Double.Parse(a[6]);
                    double uitkomst = d1 * d2 + d3 - d4;

                    if (uitkomst == _Answers[counter])
                    {
                        totaalgoed++;
                    }
                }
                else if(_sumPickSaver[counter] == 2)
                {
                    
                }
                else if (_sumPickSaver[counter] == 3)
                {
                    
                }
                else if (_sumPickSaver[counter] == 4)
                {
                    
                }
                else if (_sumPickSaver[counter] == 5)
                {
                    
                }
                else if (_sumPickSaver[counter] == 6)
                {
                    
                }
                counter++;
            }
        }
    }
}
