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

namespace Catan_vierkanten
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random _myRandom1 = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void roll_Click(object sender, RoutedEventArgs e)
        {
            int myInt1 = _myRandom1.Next(1, 7);
            int myInt2 = _myRandom1.Next(1, 7);

            if (myInt1 == 1 && myInt2 == 1)
            {
                SetAllElementsInvisible();
                block11.Visibility = Visibility.Visible;
                block21.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 1 && myInt2 == 2)
            {
                SetAllElementsInvisible();
                block11.Visibility = Visibility.Visible;
                block22.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 1 && myInt2 == 3)
            {
                SetAllElementsInvisible();
                block11.Visibility = Visibility.Visible;
                block23.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 1 && myInt2 == 4)
            {
                SetAllElementsInvisible();
                block11.Visibility = Visibility.Visible;
                block24.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 1 && myInt2 == 5)
            {
                SetAllElementsInvisible();
                block11.Visibility = Visibility.Visible;
                block25.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 1 && myInt2 == 6)
            {
                SetAllElementsInvisible();
                block11.Visibility = Visibility.Visible;
                block26.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 2 && myInt2 == 1)
            {
                SetAllElementsInvisible();
                block12.Visibility = Visibility.Visible;
                block21.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 2 && myInt2 == 2)
            {
                SetAllElementsInvisible();
                block12.Visibility = Visibility.Visible;
                block22.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 2 && myInt2 == 3)
            {
                SetAllElementsInvisible();
                block12.Visibility = Visibility.Visible;
                block23.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 2 && myInt2 == 4)
            {
                SetAllElementsInvisible();
                block12.Visibility = Visibility.Visible;
                block24.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 2 && myInt2 == 5)
            {
                SetAllElementsInvisible();
                block12.Visibility = Visibility.Visible;
                block25.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 2 && myInt2 == 6)
            {
                SetAllElementsInvisible();
                block12.Visibility = Visibility.Visible;
                block26.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 3 && myInt2 == 1)
            {
                SetAllElementsInvisible();
                block13.Visibility = Visibility.Visible;
                block21.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 3 && myInt2 == 2)
            {
                SetAllElementsInvisible();
                block13.Visibility = Visibility.Visible;
                block22.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 3 && myInt2 == 3)
            {
                SetAllElementsInvisible();
                block13.Visibility = Visibility.Visible;
                block23.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 3 && myInt2 == 4)
            {
                SetAllElementsInvisible();
                block13.Visibility = Visibility.Visible;
                block24.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 3 && myInt2 == 5)
            {
                SetAllElementsInvisible();
                block13.Visibility = Visibility.Visible;
                block25.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 3 && myInt2 == 6)
            {
                SetAllElementsInvisible();
                block13.Visibility = Visibility.Visible;
                block26.Visibility = Visibility.Visible;
            }

            else if (myInt1 == 4 && myInt2 == 1)
            {
                SetAllElementsInvisible();
                block14.Visibility = Visibility.Visible;
                block21.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 4 && myInt2 == 2)
            {
                SetAllElementsInvisible();
                block14.Visibility = Visibility.Visible;
                block22.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 4 && myInt2 == 3)
            {
                SetAllElementsInvisible();
                block14.Visibility = Visibility.Visible;
                block23.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 4 && myInt2 == 4)
            {
                SetAllElementsInvisible();
                block14.Visibility = Visibility.Visible;
                block24.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 4 && myInt2 == 5)
            {
                SetAllElementsInvisible();
                block14.Visibility = Visibility.Visible;
                block25.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 4 && myInt2 == 6)
            {
                SetAllElementsInvisible();
                block14.Visibility = Visibility.Visible;
                block26.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 5 && myInt2 == 1)
            {
                SetAllElementsInvisible();
                block15.Visibility = Visibility.Visible;
                block21.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 5 && myInt2 == 2)
            {
                SetAllElementsInvisible();
                block15.Visibility = Visibility.Visible;
                block22.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 5 && myInt2 == 3)
            {
                SetAllElementsInvisible();
                block15.Visibility = Visibility.Visible;
                block23.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 5 && myInt2 == 4)
            {
                SetAllElementsInvisible();
                block15.Visibility = Visibility.Visible;
                block24.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 5 && myInt2 == 5)
            {
                SetAllElementsInvisible();
                block15.Visibility = Visibility.Visible;
                block25.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 5 && myInt2 == 6)
            {
                SetAllElementsInvisible();
                block15.Visibility = Visibility.Visible;
                block26.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 6 && myInt2 == 1)
            {
                SetAllElementsInvisible();
                block16.Visibility = Visibility.Visible;
                block21.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 6 && myInt2 == 2)
            {
                SetAllElementsInvisible();
                block16.Visibility = Visibility.Visible;
                block22.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 6 && myInt2 == 3)
            {
                SetAllElementsInvisible();
                block16.Visibility = Visibility.Visible;
                block23.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 6 && myInt2 == 4)
            {
                SetAllElementsInvisible();
                block16.Visibility = Visibility.Visible;
                block24.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 6 && myInt2 == 5)
            {
                SetAllElementsInvisible();
                block16.Visibility = Visibility.Visible;
                block25.Visibility = Visibility.Visible;
            }
            else if (myInt1 == 6 && myInt2 == 6)
            {
                SetAllElementsInvisible();
                block16.Visibility = Visibility.Visible;
                block26.Visibility = Visibility.Visible;
            }

            if(myInt1 + myInt2 == 2)
            {
                sheep2block.Background = Brushes.DarkGray;
            }
            else
            {
                sheep2block.Background = Brushes.White;
            }
            if (myInt1 + myInt2 == 3)
            {
                ore3block.Background = Brushes.DarkGray;
                wood3block.Background = Brushes.DarkGray;
            }
            else
            {
                ore3block.Background = Brushes.White;
                wood3block.Background = Brushes.White;
            }
            if (myInt1 + myInt2 == 4)
            {
                wheat4block.Background = Brushes.DarkGray;
                sheep4block.Background = Brushes.DarkGray;
            }
            else
            {
                wheat4block.Background = Brushes.White;
                sheep4block.Background = Brushes.White;
            }
            if (myInt1 + myInt2 == 5)
            {
                brick5block.Background = Brushes.DarkGray;
                sheep5block.Background = Brushes.DarkGray;
            }
            else
            {
                brick5block.Background = Brushes.White;
                sheep5block.Background = Brushes.White;
            }
            if (myInt1 + myInt2 == 6)
            {
                brick6block.Background = Brushes.DarkGray;
                wheat6block.Background = Brushes.DarkGray;
            }
            else
            {
                brick6block.Background = Brushes.White;
                wheat6block.Background = Brushes.White;
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

        private void desert_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
