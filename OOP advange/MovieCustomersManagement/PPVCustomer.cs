using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCustomersManagement
{
    // const int PRICE = 5;
    public class PPVCustomer : Customer
    {
        private int movies;
        private const int PRICE = 1000;
        
        public int Movies
        {
            get { return movies; }
            set { movies = value; }
        }

        public PPVCustomer()
        {
            movies = 0;
        }
        public PPVCustomer(int movies, string name, string email) : base(name, email)
        {
            Movies = movies;
        }
        public override double GetPayment()
        {
            return movies * PRICE;
        }
    }
}