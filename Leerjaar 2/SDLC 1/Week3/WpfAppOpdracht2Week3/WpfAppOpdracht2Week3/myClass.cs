using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppOpdracht2Week3
{
    internal class myClass
    {
        public class Mens : Speler
        {
            public int Levens { get; private set; }
            public Mens(string naam, int levens) { }

            public void VerlaagLeven() { }
        }
        public class Robot : Speler
        {
            public int Niveau { get; set; }
            public Robot(string naam, int niveau) { }
        }
        
        public class Speler
        {
            public string Naam { get; set; }    
            public int Score { get; private set; }
            //Relaties vergeten! Als er niks staat, is het een 'onzichtbare' 1!!
            private Batje batje;
            public void VerhoogScore() { }
        }
        public class Batje
        {
            public int X { get; private set; }
            public int Y { get; private set; }
            private Speler speler;
            public void NieuwePositie(int x, int y) { } 
        }
        public class Speelveld
        {
            public int Hoogte { get; set; }
            public int Breedte { get; set; }
            private Batje batjeLinks;
            private Batje batjeRechts;
            private Bal bal; 
            public Batje BalGeraakt() { }
        }
        public class Bal
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Richting { get; set; }
            public void NieuweRichting() { }
        }
    }
}
