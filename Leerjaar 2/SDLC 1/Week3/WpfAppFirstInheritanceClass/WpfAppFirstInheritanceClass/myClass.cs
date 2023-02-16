using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppFirstInheritanceClass
{
    internal class myClass
    {
        public class Bol
        {
            public double Diameter { get; set; }
            public double Omtrek() { }
            public double Oppervlakte() { }
            public double Inhoud() { }
        }
        public class Ster : Bol
        {
            public string Naam { get; set; }
            private List<Planeet> planeten;
            public Ster (string naam, double diameter) { }
        }
        public class Planeet : Bol
        {
            public string Naam { get; set; }
            public int Rangnummer { get; set; }
            public double Omlooptijd { get; set; }
            private Ster ster;
            private List<Maan> manen;
            public Planeet (string naam, double diameter) { }   
        }
        public class Maan : Bol
        {
            public string Naam { get; set; }
            public int Rangnummer { get; set; }
            public double Omlooptijd { get; set; }
            private Planeet planeet;
            public Maan(string naam, double diameter) { }
        }
    }
}
