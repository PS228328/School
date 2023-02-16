using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEindopdrachtDD2
{
    public abstract class Uitje : ICoronaCheckEvenement
    {
        public bool VastePlaats(bool boolean)
        {
            return boolean;
        }
        public bool Buiten(bool boolean)
        {
            return boolean;
        }
        public bool CoronaCheckRequired(bool boolean)
        {
            return boolean;
        }
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
        private bool doorstroom;
        public bool Doorstroom
        {
            get { return doorstroom; }
            set { doorstroom = value; }
        }
        private bool binnenevent;
        public bool Binnenevent
        {
            get { return binnenevent; }
            set { binnenevent = value; }
        }
    }       
}
