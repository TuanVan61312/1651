using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASM1
{
    public class Ticket
    {
        private string movie;
        private string seats;
        private double price;
        public string Movie
        {
            get {return movie;}
            set {movie = value;}
        }
        public string Seats
        {
            get {return seats;}
            set {seats = value;}
        }
        public double Price
        {
            get {return price;}
            set {price = value;}
        }
        public Ticket()
        {
            Movie = "No movie";
            Seats = "0A";
            Price = 0;
        }
        public Ticket(string movie, string seats, double price)
        {
            Movie = movie;
            Seats = seats;
            Price = price;
        }
        public override string ToString()
        {
            return string.Format("Movie: {0}, Seats: {1}, Price: {2}", movie, seats, price);
        }
    }
}