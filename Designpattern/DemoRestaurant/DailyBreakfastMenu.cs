using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoRestaurant
{
    public abstract class DailyBreakfastMenu
    {
        public void ShowMenu()
        {
            // Console.WriteLine("Welcome to the restaurant");
            Breakfast bf = CreateBreakfast();
            bf.Show();
            string answer = Console.ReadLine();
            Console.WriteLine("Great choice! Please wait a moment");
        }
        protected abstract Breakfast CreateBreakfast();
    }
}