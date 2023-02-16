using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEindopdrachtDD2
{
    public abstract class Wedstrijd
    {
        private string naam;
        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }
        private DateTime startDatum;
        public DateTime StartDatum
        {
            get { return startDatum; }
            set { startDatum = value; }
        }
        private TimeSpan wedstrijdDuur;
        public TimeSpan WedstrijdDuur
        {
            get { return wedstrijdDuur; }
            set { wedstrijdDuur = value; }
        }
    }

}
