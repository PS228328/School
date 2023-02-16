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

namespace Wpf_prg2_timers
{
    /// <summary>
    /// Interaction logic for Bartender.xaml
    /// </summary>
    public partial class Bartender : Window
    {
        Random rndRandomizer = new Random();
        DispatcherTimer TmrMove = new DispatcherTimer();
        DispatcherTimer TmrSpawnBeer = new DispatcherTimer();
        int score;
        int fails = 30;
        //key downs makes a move left/right, automatically up/down
        //spawns a glass of beer at top        
        //game time in seconds

       

        public Bartender()
        {
            InitializeComponent();
            
        }
        public Bartender(string myName)
        {
            InitializeComponent();
            InitialiseTimers();
            tblUser.Text = myName;
        }

        private void InitialiseTimers()
        {
            TmrMove.Start();
            TmrMove.Interval = TimeSpan.FromMilliseconds(1);
            TmrMove.Tick += TmrMove_Tick;

            TmrSpawnBeer.Start();
            TmrSpawnBeer.Interval = TimeSpan.FromMilliseconds(500);
            TmrSpawnBeer.Tick += TmrSpawnBeer_Tick;
        }

        private void TmrMove_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.A))
            {
                imgWaiter.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/oktoberfest2.png"));
                if (imgWaiter.Margin.Left > 0)
                {
                    imgWaiter.Margin = new Thickness(imgWaiter.Margin.Left - 10, 0, 0, 0);
                }
            }

            if (Keyboard.IsKeyDown(Key.D))
            {
                imgWaiter.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/oktoberfest1.png"));
                if (imgWaiter.Margin.Left < grGameGrid.ActualWidth - 200)
                {
                    imgWaiter.Margin = new Thickness(imgWaiter.Margin.Left + 10, 0, 0, 0);
                }
            }

            foreach (Image img in grGameGrid.Children.OfType<Image>())
            {
                if (img != imgWaiter)
                {
                    img.Margin = new Thickness(img.Margin.Left, img.Margin.Top + 2, 0, 0);

                    if (GetRectOfImage(img).IntersectsWith(GetRectOfImage(imgWaiter)))
                    {
                        score = Int32.Parse(tblScore.Text);
                        score = score + 5;
                        tblScore.Text = score.ToString();
                        grGameGrid.Children.Remove(img);
                        return;
                    }
                    else if(img.Margin.Top >= grGameGrid.ActualHeight - img.ActualHeight)
                    {
                        score = Int32.Parse(tblScore.Text);
                        fails = Int32.Parse(failures.Text);
                        score = score - 5;
                        fails--;
                        tblScore.Text = score.ToString();
                        failures.Text = fails.ToString();
                        grGameGrid.Children.Remove(img);
                        return;
                    }

                    if (fails < 1)
                    {
                        TmrMove.Stop();
                        TmrSpawnBeer.Stop();
                        MessageBox.Show("Game over");
                        return;
                    }
                }
            }
        }

        private void TmrSpawnBeer_Tick(object sender, EventArgs e)
        {
            NewBeer();
        }
        private void TmrEndGame_Tick(object sender, EventArgs e)
        {

        }

        private void NewBeer()
        {
            //creates new Image 
            Image img = new Image();
            img.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/beer.png"));
            img.Width = 50;
            img.Height = 60;

            //spawns somewhere at top window. Random x-position
            double dbLeft = (rndRandomizer.NextDouble() * grGameGrid.ActualWidth) - img.Width;
            img.HorizontalAlignment = HorizontalAlignment.Left;
            img.VerticalAlignment = VerticalAlignment.Top;
            img.Margin = new Thickness(dbLeft, 0, 0, 0);
            grGameGrid.Children.Add(img);
           
        }

        private Rect GetRectOfImage(Image img)
        {
            Point pRectLocation = img.TranslatePoint(new Point(0, 0), grGameGrid);
            return new Rect(pRectLocation.X, pRectLocation.Y, img.ActualWidth, img.ActualHeight);
        }
    }
   

}
