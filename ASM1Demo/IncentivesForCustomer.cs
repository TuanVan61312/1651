using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASM1Demo
{
        public interface IncentivesForCustomer
    {
        double DoIncentives(double PRICE);
    }
    public class IncentivesByDiscount : IncentivesForCustomer
    {
        public double DoIncentives(double PRICE)
        {
            Console.WriteLine("Incentives by Discount");
            return PRICE * 0.75;
        }
    }
    public class IncentivesByGift : IncentivesForCustomer
    {
        public double DoIncentives(double PRICE)
        {
            Console.WriteLine("Incentives by Gift");
            return PRICE * 0.5;
        }
    }
    public class IncentivesByTicket : IncentivesForCustomer
    {
        public double DoIncentives(double PRICE)
        {
            Console.WriteLine("Incentives by Ticket");
            return PRICE * 0.25;
        }
    }
}