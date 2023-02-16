using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppWeek3Inleveropdracht
{
    internal class myClass
    {
        public abstract class Auto
        {
            public string Kenteken { get; private set; }
            public string Model { get; private set; }
            public bool Inzetbaar { get; set; }
        }
        public class Standaard : Auto
        {
            public bool Trekhaakaanwezig { get; set; }
            public Standaard(string kenteken, string model, bool minibarAanwezig) { }
        }
        public class Limousine : Auto
        {
            public bool minibarAanwezig { get; set; }   
            public Limousine(string kenteken, string model, bool minibarAanwezig) { }
        }
        public class Four4WD : Auto
        {
            public Four4WD(string kenteken, string model) { }   
        }
        public class Vrachtwagen : Auto
        {
            public int Laadvermogen { get; set; }
            public Vrachtwagen(string kenteken, string model, int laadvermogen) { }
        }
        public class CarRent
        {
            public string Naam { get; set; }
            private List<Chauffeur> chauffeurs;
            private List<Auto> autos;
            public bool Verhuur(Auto auto, DateTime datum) { }
            public bool Verhuur(Chauffeur chauffeur, DateTime datum) { }
            public bool Retourneer(Auto auto) { }
            public bool Retourneer(Chauffeur chauffeur) { }
        }
        public class Chauffeur
        {
            public int Personeelsnummer { get; set; }
            public string Naam { get; set; }
            public Chauffeur(string naam) { }
        }
    }
}
