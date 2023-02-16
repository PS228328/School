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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace EXTRA_opdracht_2_WPF_PRG_2_Joris_Wulms
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        int counter = 0;
        int getgetal;
        DispatcherTimer _myTimer = new DispatcherTimer();
        public Window2(int getal)
        {
            InitializeComponent();

            _myTimer.Interval = TimeSpan.FromSeconds(1);
            _myTimer.Tick += _myTimer_Tick;
            _myTimer.Start();
            getgetal = getal;
        }

        private void _myTimer_Tick(object sender, EventArgs e)
        {
            if (counter < getgetal)
            {
                counter++;
                tbTimer.Text = counter.ToString();
            }
        }
    }
}
