using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoPolymorphism
{
    public class Dog : Animal
    {
        public override void Say()
        {
            Console.WriteLine("cho");
        }
    }
}