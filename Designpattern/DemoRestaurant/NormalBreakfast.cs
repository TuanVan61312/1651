using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoRestaurant
{
    public class NormalBreakfast : Breakfast
    {
        public override void Show()
        {
            Console.WriteLine("Normal daily breakfast");
            Console.WriteLine("Today we have: ");
            Console.WriteLine("1. Bread");
            Console.WriteLine("2. Egg");
            Console.WriteLine("3. Coffee");
            Console.WriteLine("What do you want?: ");
        }
    }
}