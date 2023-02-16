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

namespace Wereldklok
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

        int uur = 0;
        int minuten = 0;
        int getalUurAmsterdam;
        int getalUurLonden;
        int getalUurTokio;
        int getalUurAuckland;
        int getalUurLosAngeles;
        int getalUurRioDeJaneiro;
        int getalMinutenLonden;
        int getalMinutenTokio;
        int getalMinutenAuckland;
        int getalMinutenLosAngeles;
        int getalMinutenRioDeJaneiro;

        private void TimeZone_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                uur = Int32.Parse(tbUurAmsterdam.Text);
                minuten = Int32.Parse(tbMinutenAmsterdam.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Vul aub bij uren een getal in tussen 0 en 24, en bij minuten een getal tussen 0 en 60");
                return;

                throw;
            }

            if (getalUurAmsterdam < 6 || getalUurAmsterdam > 17)
            {
                tbUurAmsterdam.Background = Brushes.Black;
                tbUurAmsterdam.Foreground = Brushes.White;
                tbMinutenAmsterdam.Background = Brushes.Black;
                tbMinutenAmsterdam.Foreground = Brushes.White;
            }
            else
            {
                tbUurAmsterdam.Background = Brushes.White;
                tbUurAmsterdam.Foreground = Brushes.Black;
                tbMinutenAmsterdam.Background = Brushes.White;
                tbMinutenAmsterdam.Foreground = Brushes.Black;
            }

            if (uur < 0 || uur > 23 || minuten < 0 || minuten > 59)
            {
                MessageBox.Show("Vul aub bij uren een getal in tussen 0 en 24, en bij minuten een getal tussen 0 en 60");
                return;
            }

            getalUurAmsterdam = uur;

            getalMinutenLonden = minuten;
            tbMinutenLonden.Text = getalMinutenLonden.ToString();

            getalMinutenTokio = minuten;
            tbMinutenTokio.Text = getalMinutenTokio.ToString();

            getalMinutenAuckland = minuten;
            tbMinutenAuckland.Text = getalMinutenAuckland.ToString();

            getalMinutenLosAngeles = minuten;
            tbMinutenLosAngeles.Text = getalMinutenLosAngeles.ToString();

            getalMinutenRioDeJaneiro = minuten;
            tbMinutenRioDeJaneiro.Text = getalMinutenRioDeJaneiro.ToString();

            getalUurLonden = uur - 1;

            if (getalUurLonden < 0)
            {
                getalUurLonden = getalUurLonden + 24;
                yttLonden.Text = "Gisteren";
            }
            else
            {
                yttLonden.Text = "Vandaag";
            }
            if (getalUurLonden < 10)
            {
                tbUurLonden.Text = 0 + getalUurLonden.ToString();
            }
            else
            {
                tbUurLonden.Text = getalUurLonden.ToString();
            }

            if (getalMinutenLonden < 10)
            {
                tbMinutenLonden.Text = 0 + getalMinutenLonden.ToString();
            }
            else
            {
                tbMinutenLonden.Text = getalMinutenLonden.ToString();
            }

            if (getalUurLonden < 6 || getalUurLonden > 17)
            {
                tbUurLonden.Background = Brushes.Black;
                tbUurLonden.Foreground = Brushes.White;
                tbMinutenLonden.Background = Brushes.Black;
                tbMinutenLonden.Foreground = Brushes.White;
            }
            else
            {
                tbUurLonden.Background = Brushes.White;
                tbUurLonden.Foreground = Brushes.Black;
                tbMinutenLonden.Background = Brushes.White;
                tbMinutenLonden.Foreground = Brushes.Black;
            }

            getalUurTokio = uur + 8;

            if (getalUurTokio > 23)
            {
                getalUurTokio = getalUurTokio - 24;
                yttTokio.Text = "Morgen";
            }
            else
            {
                yttTokio.Text = "Vandaag";
            }
            if (getalUurTokio < 10)
            {
                tbUurTokio.Text = 0 + getalUurTokio.ToString();
            }
            else
            {
                tbUurTokio.Text = getalUurTokio.ToString();
            }
            if (getalMinutenTokio < 10)
            {
                tbMinutenTokio.Text = 0 + getalMinutenTokio.ToString();
            }
            else
            {
                tbMinutenTokio.Text = getalMinutenTokio.ToString();
            }
            if (getalUurTokio < 6 || getalUurTokio > 17)
            {
                tbUurTokio.Background = Brushes.Black;
                tbUurTokio.Foreground = Brushes.White;
                tbMinutenTokio.Background = Brushes.Black;
                tbMinutenTokio.Foreground = Brushes.White;
            }
            else
            {
                tbUurTokio.Background = Brushes.White;
                tbUurTokio.Foreground = Brushes.Black;
                tbMinutenTokio.Background = Brushes.White;
                tbMinutenTokio.Foreground = Brushes.Black;
            }


            getalUurAuckland = uur + 11;

            if (getalUurAuckland > 23)
            {
                getalUurAuckland = getalUurAuckland - 24;
                yttAuckland.Text = "Morgen";
            }
            else
            {
                yttAuckland.Text = "Vandaag";
            }

            if (getalUurAuckland < 10)
            {
                tbUurAuckland.Text = 0 + getalUurAuckland.ToString();
            }
            else
            {
                tbUurAuckland.Text = getalUurAuckland.ToString();
            }
            if (getalMinutenAuckland < 10)
            {
                tbMinutenAuckland.Text = 0 + getalMinutenAuckland.ToString();
            }
            else
            {
                tbMinutenAuckland.Text = getalMinutenAuckland.ToString();
            }
            if (getalUurAuckland < 6 || getalUurAuckland > 17)
            {
                tbUurAuckland.Background = Brushes.Black;
                tbUurAuckland.Foreground = Brushes.White;
                tbMinutenAuckland.Background = Brushes.Black;
                tbMinutenAuckland.Foreground = Brushes.White;
            }
            else
            {
                tbUurAuckland.Background = Brushes.White;
                tbUurAuckland.Foreground = Brushes.Black;
                tbMinutenAuckland.Background = Brushes.White;
                tbMinutenAuckland.Foreground = Brushes.Black;
            }

            getalUurLosAngeles = uur - 9;

            if (getalUurLosAngeles < 0)
            {
                getalUurLosAngeles = getalUurLosAngeles + 24;
                yttLosAngeles.Text = "Gisteren";
            }
            else
            {
                yttLosAngeles.Text = "Vandaag";
            }

            if (getalUurLosAngeles < 10)
            {
                tbUurLosAngeles.Text = 0 + getalUurLosAngeles.ToString();
            }
            else
            {
                tbUurLosAngeles.Text = getalUurLosAngeles.ToString();
            }
            if (getalMinutenLosAngeles < 10)
            {
                tbMinutenLosAngeles.Text = 0 + getalMinutenLosAngeles.ToString();
            }
            else
            {
                tbMinutenLosAngeles.Text = getalMinutenLosAngeles.ToString();
            }
            if (getalUurLosAngeles < 6 || getalUurLosAngeles > 17)
            {
                tbUurLosAngeles.Background = Brushes.Black;
                tbUurLosAngeles.Foreground = Brushes.White;
                tbMinutenLosAngeles.Background = Brushes.Black;
                tbMinutenLosAngeles.Foreground = Brushes.White;
            }
            else
            {
                tbUurLosAngeles.Background = Brushes.White;
                tbUurLosAngeles.Foreground = Brushes.Black;
                tbMinutenLosAngeles.Background = Brushes.White;
                tbMinutenLosAngeles.Foreground = Brushes.Black;
            }

            getalUurRioDeJaneiro = uur - 5;

            if (getalUurRioDeJaneiro < 0)
            {
                getalUurRioDeJaneiro = getalUurRioDeJaneiro + 24;
                yttRioDeJaneiro.Text = "Gisteren";
            }
            else
            {
                yttRioDeJaneiro.Text = "Vandaag";
            }

            if (getalUurRioDeJaneiro < 10)
            {
                tbUurRioDeJaneiro.Text = 0 + getalUurRioDeJaneiro.ToString();
            }
            else
            {
                tbUurRioDeJaneiro.Text = getalUurRioDeJaneiro.ToString();
            }
            if (getalMinutenRioDeJaneiro < 10)
            {
                tbMinutenRioDeJaneiro.Text = 0 + getalMinutenRioDeJaneiro.ToString();
            }
            else
            {
                tbMinutenRioDeJaneiro.Text = getalMinutenRioDeJaneiro.ToString();
            }
            if (getalUurRioDeJaneiro < 6 || getalUurRioDeJaneiro > 17)
            {
                tbUurRioDeJaneiro.Background = Brushes.Black;
                tbUurRioDeJaneiro.Foreground = Brushes.White;
                tbMinutenRioDeJaneiro.Background = Brushes.Black;
                tbMinutenRioDeJaneiro.Foreground = Brushes.White;
            }
            else
            {
                tbUurRioDeJaneiro.Background = Brushes.White;
                tbUurRioDeJaneiro.Foreground = Brushes.Black;
                tbMinutenRioDeJaneiro.Background = Brushes.White;
                tbMinutenRioDeJaneiro.Foreground = Brushes.Black;
            }
        }
    }
}
