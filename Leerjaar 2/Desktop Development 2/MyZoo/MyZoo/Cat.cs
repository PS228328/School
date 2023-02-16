using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    internal class Cat : Feline, IPet
    {
        public void BeFriendly()
        {
            Console.WriteLine("Miauw!");
        }
        public void Play()
        {
            Console.WriteLine("Spinnn!");
        }
        public void MakeNoise()
        {
            Console.WriteLine("My noise is " + Sound);
        }
        public void Eat()
        {
            Console.WriteLine("I like to eat " + Food);
        }
    }
}
