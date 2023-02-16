using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEindopdrachtDD2
{
    public class MuseumUitje : Uitje
    {
        private decimal toegangsprijs;
        public decimal Toegangsprijs
        {
            get { return toegangsprijs; }
            set { toegangsprijs = value; }
        }
    }
}
