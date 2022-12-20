using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoComposite
{
    public class NewMember : Member
    {
        public NewMember(string name, int products) : base(name, products)
        {}
        public override double GetSalary()
        {
            return PRICE = Products * (1-COMMISION);
        }
    }
}