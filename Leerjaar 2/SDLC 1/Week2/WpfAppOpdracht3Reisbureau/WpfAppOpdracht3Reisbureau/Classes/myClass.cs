using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace WpfAppOpdracht3Reisbureau.Classes
{
    internal class myClass
    {
        //Classes zijn goed!
        public class Klant
        {
            public string Naam { get; set; } //Property, maar zet hem public en niet private!!
            private List<Boeking> boekingen; //Relatie naar boekingen, correct :)
            //public void NieuweBoeking() { } Hoefde niet
        }
        public class Boeking
        {
            public DateTime Datum { get; set; } //Property
            public int AantalPersonen { get; set; } //Property
            public double DeelBetaald { get; set; } //Property
            private Klant klant; //Refereert naar klant, want er is maar een klant voor een boeking
            private Reis reis; //Een boeking heeft maar een reis
            public Boeking (Reis reis) { } //Constructor
            public double Prijs() { }
        }
        public class Reis
        {
            public int Dagen { get; set; } //Property
            public double PrijsPpPd { get; set; } //Nog een property
            private Bestemming bestemming; //Relatie omdat een reis een bestemming moet hebben
            public Reis(Bestemming bestemming) { } //Deze hadden we!! :) (Constructor)
        }
        public class Bestemming
        {
            public string Locatie { get; set; }
            public string Plaats { get; set; }
            public string Land { get; set; }            
        }
    }
}
