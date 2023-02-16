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

namespace WPFAPP_Sudoku
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int Va1 = Int32.Parse(a1.Text);
                int Va2 = Int32.Parse(a2.Text);
                int Va3 = Int32.Parse(a3.Text);
                int Va4 = Int32.Parse(a4.Text);
                int Va5 = Int32.Parse(a5.Text);
                int Va6 = Int32.Parse(a6.Text);
                int Va7 = Int32.Parse(a7.Text);
                int Va8 = Int32.Parse(a8.Text);
                int Va9 = Int32.Parse(a9.Text);

                int Vb1 = Int32.Parse(b1.Text);
                int Vb2 = Int32.Parse(b2.Text);
                int Vb3 = Int32.Parse(b3.Text);
                int Vb4 = Int32.Parse(b4.Text);
                int Vb5 = Int32.Parse(b5.Text);
                int Vb6 = Int32.Parse(b6.Text);
                int Vb7 = Int32.Parse(b7.Text);
                int Vb8 = Int32.Parse(b8.Text);
                int Vb9 = Int32.Parse(b9.Text);

                int Vc1 = Int32.Parse(c1.Text);
                int Vc2 = Int32.Parse(c2.Text);
                int Vc3 = Int32.Parse(c3.Text);
                int Vc4 = Int32.Parse(c4.Text);
                int Vc5 = Int32.Parse(c5.Text);
                int Vc6 = Int32.Parse(c6.Text);
                int Vc7 = Int32.Parse(c7.Text);
                int Vc8 = Int32.Parse(c8.Text);
                int Vc9 = Int32.Parse(c9.Text);

                int Vd1 = Int32.Parse(d1.Text);
                int Vd2 = Int32.Parse(d2.Text);
                int Vd3 = Int32.Parse(d3.Text);
                int Vd4 = Int32.Parse(d4.Text);
                int Vd5 = Int32.Parse(d5.Text);
                int Vd6 = Int32.Parse(d6.Text);
                int Vd7 = Int32.Parse(d7.Text);
                int Vd8 = Int32.Parse(d8.Text);
                int Vd9 = Int32.Parse(d9.Text);

                int Ve1 = Int32.Parse(e1.Text);
                int Ve2 = Int32.Parse(e2.Text);
                int Ve3 = Int32.Parse(e3.Text);
                int Ve4 = Int32.Parse(e4.Text);
                int Ve5 = Int32.Parse(e5.Text);
                int Ve6 = Int32.Parse(e6.Text);
                int Ve7 = Int32.Parse(e7.Text);
                int Ve8 = Int32.Parse(e8.Text);
                int Ve9 = Int32.Parse(e9.Text);

                int Vf1 = Int32.Parse(f1.Text);
                int Vf2 = Int32.Parse(f2.Text);
                int Vf3 = Int32.Parse(f3.Text);
                int Vf4 = Int32.Parse(f4.Text);
                int Vf5 = Int32.Parse(f5.Text);
                int Vf6 = Int32.Parse(f6.Text);
                int Vf7 = Int32.Parse(f7.Text);
                int Vf8 = Int32.Parse(f8.Text);
                int Vf9 = Int32.Parse(f9.Text);

                int Vg1 = Int32.Parse(g1.Text);
                int Vg2 = Int32.Parse(g2.Text);
                int Vg3 = Int32.Parse(g3.Text);
                int Vg4 = Int32.Parse(g4.Text);
                int Vg5 = Int32.Parse(g5.Text);
                int Vg6 = Int32.Parse(g6.Text);
                int Vg7 = Int32.Parse(g7.Text);
                int Vg8 = Int32.Parse(g8.Text);
                int Vg9 = Int32.Parse(g9.Text);

                int Vh1 = Int32.Parse(h1.Text);
                int Vh2 = Int32.Parse(h2.Text);
                int Vh3 = Int32.Parse(h3.Text);
                int Vh4 = Int32.Parse(h4.Text);
                int Vh5 = Int32.Parse(h5.Text);
                int Vh6 = Int32.Parse(h6.Text);
                int Vh7 = Int32.Parse(h7.Text);
                int Vh8 = Int32.Parse(h8.Text);
                int Vh9 = Int32.Parse(h9.Text);

                int Vi1 = Int32.Parse(i1.Text);
                int Vi2 = Int32.Parse(i2.Text);
                int Vi3 = Int32.Parse(i3.Text);
                int Vi4 = Int32.Parse(i4.Text);
                int Vi5 = Int32.Parse(i5.Text);
                int Vi6 = Int32.Parse(i6.Text);
                int Vi7 = Int32.Parse(i7.Text);
                int Vi8 = Int32.Parse(i8.Text);
                int Vi9 = Int32.Parse(i9.Text);

                int checks = 0;

                if (Va1 + Va2 + Va3 + Va4 + Va5 + Va6 + Va7 + Va8 + Va9 == 45)
                {
                    checks++;
                }

                if (Vb1 + Vb2 + Vb3 + Vb4 + Vb5 + Vb6 + Vb7 + Vb8 + Vb9 == 45)
                {
                    checks++;
                }

                if (Vc1 + Vc2 + Vc3 + Vc4 + Vc5 + Vc6 + Vc7 + Vc8 + Vc9 == 45)
                {
                    checks++;
                }

                if (Vd1 + Vd2 + Vd3 + Vd4 + Vd5 + Vd6 + Vd7 + Vd8 + Vd9 == 45)
                {
                    checks++;
                }

                if (Ve1 + Ve2 + Ve3 + Ve4 + Ve5 + Ve6 + Ve7 + Ve8 + Ve9 == 45)
                {
                    checks++;
                }

                if (Vf1 + Vf2 + Vf3 + Vf4 + Vf5 + Vf6 + Vf7 + Vf8 + Vf9 == 45)
                {
                    checks++;
                }

                if (Vg1 + Vg2 + Vg3 + Vg4 + Vg5 + Vg6 + Vg7 + Vg8 + Vg9 == 45)
                {
                    checks++;
                }

                if (Vh1 + Vh2 + Vh3 + Vh4 + Vh5 + Vh6 + Vh7 + Vh8 + Vh9 == 45)
                {
                    checks++;
                }

                if (Vi1 + Vi2 + Vi3 + Vi4 + Vi5 + Vi6 + Vi7 + Vi8 + Vi9 == 45)
                {
                    checks++;
                }

                if (Va1 + Vb1 + Vc1 + Vd1 + Ve1 + Vf1 + Vg1 + Vh1 + Vi1 == 45)
                {
                    checks++;
                }

                if (Va2 + Vb2 + Vc2 + Vd2 + Ve2 + Vf2 + Vg2 + Vh2 + Vi2 == 45)
                {
                    checks++;
                }

                if (Va3 + Vb3 + Vc3 + Vd3 + Ve3 + Vf3 + Vg3 + Vh3 + Vi3 == 45)
                {
                    checks++;
                }

                if (Va4 + Vb4 + Vc4 + Vd4 + Ve4 + Vf4 + Vg4 + Vh4 + Vi4 == 45)
                {
                    checks++;
                }

                if (Va5 + Vb5 + Vc5 + Vd5 + Ve5 + Vf5 + Vg5 + Vh5 + Vi5 == 45)
                {
                    checks++;
                }

                if (Va6 + Vb6 + Vc6 + Vd6 + Ve6 + Vf6 + Vg6 + Vh6 + Vi6 == 45)
                {
                    checks++;
                }

                if (Va7 + Vb7 + Vc7 + Vd7 + Ve7 + Vf7 + Vg7 + Vh7 + Vi7 == 45)
                {
                    checks++;
                }

                if (Va8 + Vb8 + Vc8 + Vd8 + Ve8 + Vf8 + Vg8 + Vh8 + Vi8 == 45)
                {
                    checks++;
                }

                if (Va9 + Vb9 + Vc9 + Vd9 + Ve9 + Vf9 + Vg9 + Vh9 + Vi9 == 45)
                {
                    checks++;
                }

                if (Va1 + Va2 + Va3 + Vb1 + Vb2 + Vb3 + Vc1 + Vc2 + Vc3 == 45)
                {
                    checks++;
                }

                if (Va4 + Va5 + Va6 + Vb4 + Vb5 + Vb6 + Vc4 + Vc5 + Vc6 == 45)
                {
                    checks++;
                }

                if (Va7 + Va8 + Va9 + Vb7 + Vb8 + Vb9 + Vc7 + Vc8 + Vc9 == 45)
                {
                    checks++;
                }

                if (Vd1 + Vd2 + Vd3 + Ve1 + Ve2 + Ve3 + Vf1 + Vf2 + Vf3 == 45)
                {
                    checks++;
                }

                if (Vd4 + Vd5 + Vd6 + Ve4 + Ve5 + Ve6 + Vf4 + Vf5 + Vf6 == 45)
                {
                    checks++;
                }

                if (Vd7 + Vd8 + Vd9 + Ve7 + Ve8 + Ve9 + Vf7 + Vf8 + Vf9 == 45)
                {
                    checks++;
                }

                if (Vg1 + Vg2 + Vg3 + Vh1 + Vh2 + Vh3 + Vi1 + Vi2 + Vi3 == 45)
                {
                    checks++;
                }

                if (Vg4 + Vg5 + Vg6 + Vh4 + Vh5 + Vh6 + Vi4 + Vi5 + Vi6 == 45)
                {
                    checks++;
                }

                if (Vg7 + Vg8 + Vg9 + Vh7 + Vh8 + Vh9 + Vi7 + Vi8 + Vi9 == 45)
                {
                    checks++;
                }

                if (checks == 27)
                {
                    MessageBox.Show("Well done!");
                }
                else
                {
                    MessageBox.Show("Oops, you made some mistakes");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
