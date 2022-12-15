using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoRestaurant
{
    public class Restaurant
    {
        private DailyBreakfastMenu menu;
        public void Open()
        {
            DayOfWeek day = DateTime.Now.DayOfWeek;
            if(day == DayOfWeek.Saturday || day == DayOfWeek.Sunday)
            {
                menu = new WeekendMenu();
            }
            else
            {
                menu = new NormalMenu();
            }
            Console.WriteLine("today is {0}", day);
            Console.WriteLine("Opening the restaurant....");
        }
        public void WelcomCustomer()
        {
            while (true)
            {
                Console.WriteLine("Welcome to the restaurant");
                menu.ShowMenu();
                Console.WriteLine("Waiting for new customer...");
                string c = Console.ReadLine();
                if (c == "q") break;
            }
        }
    }
}