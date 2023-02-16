using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppFirstClass.Classes
{
    internal class firstSDLC
    {
        public class AdministratieED
        {
            public double Abonnementsprijs { get; set; }
            private List<Abonnee> abonnees;
            public void NieuweAbonnee(Abonnee abonnee) { }
            public void StopAbonnement(Abonnee abonnee) { }
            
        }
        //Get = lezen || Set = schrijven
        public class Abonnee
        {
            public string Naam { get; }
            public string Adres { get; set; }
            public string Woonplaats { get; set; }
            public string Bankrekening { get; }
            public DateTime Einddatum { get; private set; }
            private AdministratieED administratieED;
            public Abonnee(string naam, string adres, string woonplaats, string bankrekening, DateTime einddatum) { }
            public bool Verlenging(DateTime einddatum) { }
        }
    }
}
