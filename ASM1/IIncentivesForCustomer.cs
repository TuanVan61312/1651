using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASM1
{
    public interface IIncentivesForCustomer
    {
        public double Payment(Ticket t);
        public void Incentives(List<Ticket> tickets)
        {
            
        }
    }
    public class IncentivesByDiscount : IIncentivesForCustomer
    {
        public double Payment(Ticket t)
        {
            return t.Price;
        }
    }
    public class IncentivesbyGift : IIncentivesForCustomer
    {
        public double Payment(Ticket t)
        {
            return t.Price;
        }
    }
    public class IncentivesByTicket : IIncentivesForCustomer
    {
        public double Payment(Ticket t)
        {
            return t.Price;
        }
    }
}