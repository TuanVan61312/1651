using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoPolymorphism
{
    public class Cat : Animal
    {
        public override void Say()
        {
            Console.WriteLine("123");
        }
    }
}