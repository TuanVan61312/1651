using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCustomersManagement
{
    public class SubrciceCustomer : Customer
    {
        private int subType;
        public int SubType
        {
            get { return subType; }
            set { subType = value; }
        }
        private const int MONTHLY = 250000;
        private const double SALE = 0.1;

        public SubrciceCustomer()
        {
            subType = 0;
        }
        public SubrciceCustomer(string name, string email, int subType) : base(name, email)
        {
            SubType = subType;
        }
        public override double GetPayment()
        {
            if(subType == 0) return MONTHLY;
            else return MONTHLY * (1 - SALE);
        }
    }
}