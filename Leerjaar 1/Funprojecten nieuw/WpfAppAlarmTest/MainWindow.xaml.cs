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

namespace WpfAppAlarmTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DateTime _date = DateTime.Now;
        DispatcherTimer _timer = new DispatcherTimer();
        int _jaar = 0;
        int _maand = 0;
        int _dag = 0;

        public MainWindow()
        {
            InitializeComponent();
            GeefEerstVolgendeTest();
            _timer.Start();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += _timer_Tick;
        }

        private void GeefEerstVolgendeTest()
        {
            int jaar = _date.Year;
            int maand = _date.Month;
            int dag = _date.Day;

            string[] maanden = {"", "januari", "februari", "maart", "april", "mei", "juni", "juli", "augustus", "september", "oktober", "november", "december" };

            bool dateFound = false;

            while (dateFound == false)
            {
                DateTime dateValue = new DateTime(jaar, maand, dag);
                if (dateValue.DayOfWeek == DayOfWeek.Monday && dag < 8)
                {
                    tbNextTest.Text = "Maandag " + dag + " " + maanden[maand] + " om 12:00";
                    _dag = dag;
                    _maand = maand;
                    _jaar = jaar;
                    dateFound = true;
                }
                else if (dag < 8)
                {
                    tbNextTest.Text = "Maandag " + dag + " " + maanden[maand] + " om 12:00";
                    dag++;
                }
                else
                {
                    dag++;
                    if (dag > 7)
                    {
                        dag = 1;
                        maand++;
                        if (maand == 13)
                        {
                            maand = 1;
                            jaar++;
                        }
                    }
                }
            }

        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            _date = DateTime.Now;
            DatePicker datePickerTest = new DatePicker();
            datePickerTest.SelectedDate = new DateTime(_jaar, _maand, _dag, 12, 0, 0, 0);

            DateTime now = DateTime.Now;
            int nextdays = 0;
            int amount = 0;
            int hour = now.Hour;

            if (now.Day > _dag)
            {
                if (now.Month == 4 || now.Month == 6 || now.Month == 9 || now.Month == 11)
                {
                    amount = 30;
                }
                else if (now.Month == 2 && now.Year % 4 != 0)
                {
                    amount = 28;
                }
                else if (now.Month == 2 && now.Year % 4 == 0)
                {
                    amount = 29;
                }
                else
                {
                    amount = 31;
                }
                nextdays = amount - now.Day + _dag;
            }

            if (36 - now.Hour < 24)
            {
                tbDayCount.Text = "Dat is over " + nextdays + " dagen, " + (35 - now.Hour).ToString() + " uren, " + (59 - now.Minute) + " minuten en " + (60 - now.Second) + " seconden";
            }
            else
            {
                tbDayCount.Text = "Dat is over " + (nextdays + 1) + " dagen, " + (11 - now.Hour).ToString() + " uren, " + (59 - now.Minute) + " minuten en " + (60 - now.Second) + " seconden";
            }

            if (_date.Month == _maand && _date.Year == _jaar && _date.Day == _dag && _date.Hour == 12 && _date.Minute < 2)
            {
                Eerstvolgende.Visibility = Visibility.Hidden;
                MessageBox.Show("Test vind plaats...");
                GeefEerstVolgendeTest();
            }
            else
            {
                Eerstvolgende.Visibility = Visibility.Visible;
            }
        }
    }
}
