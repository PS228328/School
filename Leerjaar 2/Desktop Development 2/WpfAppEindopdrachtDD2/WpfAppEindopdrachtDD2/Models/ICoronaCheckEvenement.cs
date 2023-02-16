using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEindopdrachtDD2
{
    public interface ICoronaCheckEvenement
    {
        public bool VastePlaats(bool boolean);
        public bool Buiten(bool boolean);
        public bool CoronaCheckRequired(bool boolean);
    }
}
