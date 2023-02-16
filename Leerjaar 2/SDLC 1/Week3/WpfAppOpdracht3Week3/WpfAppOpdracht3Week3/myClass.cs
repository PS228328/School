using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppOpdracht3Week3
{
    internal class myClass
    {
        public class Persoon
        {
            public string Naam { get; }
            public Persoon(string naam) { }
        }
        public class Woning
        {
            public string Adres { get; }
            public double Inhoud { get; set; }
            public int Slaapkamers { get; set; }
        }
        public class Huurwoning : Woning
        {
            public double Huurprijs { get; set; }
            private Persoon huurder;
            private Persoon eigenaar;
            public Huurwoning(string adres, double inhoud, int slaapkamers, double huurprijs) { } 
        }
        public class Koopwoning : Woning
        {
            public bool TeKoop { get; set; }
            public double Koopprijs { get; set; }
            private Persoon eigenaar;
            public Koopwoning (string adres, string inhoud, int slaapkamers, double koopprijs) { }
        }
    }
}
