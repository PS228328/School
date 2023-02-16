using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    abstract class Canine : Animal
    {
        public void Roam()
        {
            Console.WriteLine("I'm roaming around");
        }
    }
}
