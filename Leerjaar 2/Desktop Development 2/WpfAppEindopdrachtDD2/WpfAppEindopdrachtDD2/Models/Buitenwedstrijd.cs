using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEindopdrachtDD2
{
    public class Buitenwedstrijd : Wedstrijd, ICoronaCheckEvenement
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
        private bool doorstroom;
        public bool Doorstroom
        {
            get { return doorstroom; }
            set { doorstroom = value; }
        }
    }
}
