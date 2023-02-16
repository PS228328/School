using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEindopdrachtDD2
{
    public class BioscoopUitje : Uitje
    {
        private DateTime aanvangsTijdstip;
        public DateTime AanvangsTijdstip
        {
            get { return aanvangsTijdstip;}
            set { aanvangsTijdstip = value; }
        }
        private TimeSpan duur;
        public TimeSpan Duur
        {
            get { return duur; }
            set { duur = value; }
        }
        private string film;
        public string Film
        {
            get { return film; }
            set { film = value; }
        }
        private string zaal;
        public string Zaal
        {
            get { return zaal; }
            set { zaal = value; }
        }
        private string stoel;
        public string Stoel
        {
            get { return stoel; }
            set { stoel = value; }
        }
    }
}
