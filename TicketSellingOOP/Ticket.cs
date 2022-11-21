using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSellingOOP
{
    public class Ticket
    {
        private string movie;
        private string seats;
        private int number;

        public string Movie
        {
            get {return Movie;}
            set 
            {
                if (value == "") Movie = "Choose a movie";
                else Movie = value;
            }
        }

        public string Seats
        {
            get {return Seats;}
            set 
            {
                if (value == "") Seats = "choose a seat";
                else Seats = value;
            }
        }

        public int Number
        {
            get {return Number;}
            set
            {
                if (value == 0) Number = 1;
                else Number = value;
            }
        }

        public Ticket()
        {
            Movie = "X-men";
            Seats = "1A";
            Number = 1;
        }

        public Ticket(string movie, string seats, int number)
        {
            Movie = movie;
            Seats = seats;
            Number = number;
        }
    }
}