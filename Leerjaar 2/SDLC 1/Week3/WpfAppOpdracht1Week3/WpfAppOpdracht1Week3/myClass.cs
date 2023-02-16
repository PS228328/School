using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppOpdracht1Week3.Classes
{
    internal class myClass
    {
        public class Persoon
        {
            public string Naam { get; set; }    
            public string Adres { get; set; }   
            public string Woonplaats { get; set; }
        }
        public class Abonnee : Persoon
        {
            public string Bankrekening { get; }
            public DateTime Einddatum { get; private set; }
            private Abonnee(string naam, string adres, string woonplaats, string bankrekening) { }
            private AdministratieED administratieed; //relatie
            public bool Verlenging(DateTime einddatum) { }
        }
        public class AdministratieED
        {
            public double Abonnementsprijs { get; set; }
            private List<Abonnee> abonnees;
            private void NieuweAbonnee(Abonnee abonnee) { }
            private void StopAbonnement(Abonnee abonnee) { }
        }
    }
}
