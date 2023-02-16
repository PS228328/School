using System;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Memory4FoutenWpf.Model
{
    class Kaart
    {
        public OpenDicht Status { get; private set; }
        private BitmapImage blank = new BitmapImage();
        private BitmapImage afbeelding = new BitmapImage();

        private Image image = new Image
        {
            Height = 125,
            Width = 100,
            Margin = new Thickness(5)
        };
        public Kaart(int id, MouseButtonEventHandler eh)
        {
            blank.BeginInit();
            blank.UriSource = new Uri("Images/blank.png", UriKind.Relative);
            blank.EndInit();

            image.Source = blank;
            image.Tag = id;
            image.MouseDown += eh;
            Status = OpenDicht.Dicht;
        }
        public void Nieuw(BitmapImage afbeelding)
        {
            this.afbeelding = afbeelding;
        }
        public void ToonOpen()
        {
            image.Source = afbeelding;
            Status = OpenDicht.Open;
        }
        public void ToonDicht()
        {
            image.Source = blank;
            Status = OpenDicht.Dicht;
        }
        public Image GetImage()
        {
            return image;
        }
    }
}
