using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSellingOOP
{
    public class Staff
    {
        private string[] movies = {"Black Adam", "Black Pather 2", "Detective Conan"};
        private const int TICKET_PRICE = 5;
        public void PrintMovies()
        {
            // print a menu of 3 movies
            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine("movies list");
                Console.WriteLine((i+1) + "." + movies[i]);
            }
        }

        public void PrintTicket(Ticket t)
        {
            // print ticket attributes (movie, seats, number)
            Console.WriteLine("Ticket infomation: ");
            Console.WriteLine("Movies: " + t.Movie);
            Console.WriteLine("Seat: " + t.Seats);
            Console.WriteLine("Number of ticket: " + t.Number);
        }
        public void PrintInvoice(Customer c)
        {
            // calculate payment based customer's ticket & vip
            int payment = TICKET_PRICE * c.MyTicket.Number;
            Console.WriteLine("payment: " + payment);
        }

        public void SellTickets()
        {
            bool selling = true;
            while (selling)
            {
                PrintMovies();

                Customer c = new Customer();
                int choice = c.GetMovieChoice(movies.Length);
                int nTickets = c.GetNumberOfTickets();
                string seats = c.GetSeats(nTickets);
                string movie = movies[choice];

                Ticket t = new Ticket(movie, seats, nTickets);
                
                PrintTicket(t);
                
                c.MyTicket = t;
                c.SetVIP();

                PrintInvoice(c);
            }
        }
    }
}