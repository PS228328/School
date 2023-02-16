using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppInleveropdrachtGarage.Classes
{
    internal class myClass
    {
        public class Verrichting
        {
            public DateTime Datum { get; set; } //Property
            public SoortVerrichting Soort { get; set; }
            public double Werktijd { get; set; }
            public string[] Materialen { get; set; }
            public double Reistijd { get; set; }
            private Auto auto; //Relatie met een auto
            public Verrichting(Auto auto) { } //Relatie naar auto want een verrichting heeft maar een auto
        }
        public class Auto
        {
            public string Kenteken { get; }
            public int KmStand { get; set; }
            public DateTime VolgendeAPK { get; set; }
            private List<Verrichting> verrichtingen; //Lijst met verrichtingen
            private Contact eigenaar;
            private Contact gebruiker;
            public Auto(string kenteken, Contact eigenaar, Contact gebruiker, int kmStand) { }
            public void NieuweVerrichting(Verrichting verrichting) { }
        }
        public class Contact
        {
            public string Naam { get; }
            public Contact(string naam) { }
        }

        public enum SoortVerrichting { Kleinebeurt, Grotebeurt, Spoedreparatie, APK, HulpOnderweg}
        
    }
}
