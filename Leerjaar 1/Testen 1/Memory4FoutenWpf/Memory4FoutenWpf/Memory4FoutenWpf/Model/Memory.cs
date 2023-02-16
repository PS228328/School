using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;


namespace Memory4FoutenWpf.Model
{
    class Memory
    {
        private BitmapImage[] bitmaps = new BitmapImage[12];
        private Kaart[] kaart = new Kaart[24];
        private int[] verdeling = new int[24];

        private Random r = new Random();
        private int eervorige = -1;
        private int vorige = -1;
        private int aantalOpen = 0;
        public int Score { get; private set; }
        public int tijd = 0;

        public Memory(MouseButtonEventHandler eh, StackPanel[] panels)
        {
            for (int i = 0; i < 12; i++)
            {
                BitmapImage bm = new BitmapImage();
                bm.BeginInit();
                bm.UriSource = new Uri("Images/" + i + ".png", UriKind.Relative);
                bm.EndInit();
                bitmaps[i] = bm;
            }
            for (int i = 0; i < 24; i++)
            {
                kaart[i] = new Kaart(i, eh);
                panels[i / 6].Children.Add(kaart[i].GetImage() );
            }
        }

        /** Start een nieuw Spel, verdeel de kaarten opnieuw, verberg alle kaarten en reset de score en verlopen tijd **/
       public void NieuwSpel()
       {
           for (int i = 0; i < 24; i++) verdeling[i] = 0;
           for (int i = 1; i <= 12; i++) for (int j = 0; j < 2; j++)
               {
                   int x = r.Next(24);
                   while (verdeling[x % 24] > 0) x++;
                   verdeling[x % 24] = i;
               }
           tijd = 0;
           for (int i = 0; i < 24; i++) kaart[i].Nieuw(bitmaps[verdeling[i] - 1]);
           for (int i = 0; i < 24; i++) kaart[i].ToonDicht();
           Score = 0;
        }

        /** Controleer of laatste 2 geopende kaarten gelijk zijn, dan blijven deze open
         *  Anders gaan deze open kaarten dicht en gaat de aangeklikte kaart open
         *  Controleer of de laatste enkele open kaart gelijk is aan de aangeklikte kaart
         *  **/

        public void Beurt(int x)
        {
           if (aantalOpen == 0 && kaart[x].Status == OpenDicht.Dicht)
           {
               kaart[x].ToonOpen();
               vorige = x;
               aantalOpen = 1;
           }
           else if (aantalOpen == 1 && kaart[x].Status == OpenDicht.Dicht)
           {
               kaart[x].ToonOpen();
               aantalOpen = 2;
               eervorige = x;
               if (verdeling[x] == verdeling[vorige])
               {
                   Score++;
                   eervorige = -1;
                   vorige = -1;
                   aantalOpen = 0;
               }
           }
           else if (aantalOpen == 2 && kaart[x].Status == OpenDicht.Dicht)
           {
                kaart[eervorige].ToonDicht();
                kaart[vorige].ToonDicht();
                kaart[x].ToonOpen();
                vorige = x;
                aantalOpen = 1;
           }
        }
    }
}
