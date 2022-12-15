using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoRestaurant
{
    public class WeekendMenu : DailyBreakfastMenu
    {
        protected override Breakfast CreateBreakfast()
        {
            return new WeekendBeakfast();
        }
    }
}