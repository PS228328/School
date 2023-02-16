using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    abstract class Animal
    {
        private string food;
        public string Food
        {
            get { return food; }
            set { food = value; }
        }
        private string sound;
        public string Sound
        {
            get { return sound; }
            set { sound = value; }
        }
        public void MakeNoise()
        {
            Console.WriteLine("My noise is " + sound);
        }
        public void Eat() 
        {
            Console.WriteLine("I like to eat " + food);
        }
        public void Roam() 
        {
            Console.WriteLine("I'm roaming around");
        }
    }
}
