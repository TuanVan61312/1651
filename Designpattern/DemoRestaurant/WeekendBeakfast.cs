using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoRestaurant
{
    public class WeekendBeakfast : Breakfast
    {
        public override void Show()
        {
            Console.WriteLine("Weekend breakfast");
            Console.WriteLine("Today we have: ");
            Console.WriteLine("1. Pancakes");
            Console.WriteLine("2. Sausages");
            Console.WriteLine("3. Cake");
            Console.WriteLine("4. Coffee");
            Console.WriteLine("What do you want?: ");
        }
    }
}