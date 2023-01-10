using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASM1Demo
{
    public class SellTicket
    {
        private string[] movies = {"Phim 1", "Phim 2", "Phim 3"};
        private const  int PRICE = 5;
        public void PrintMenu()
        {
            Console.WriteLine("Movies List");
            for(int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + movies[i]);
            }
        }
        public void PrintBill(Ticket t)
        {
            Console.WriteLine("Ticket information: ");
            Console.WriteLine("Movie :" + t.Movie);
            Console.WriteLine("Seats: " + t.Seats);
            Console.WriteLine("Number of ticket: " + t.Number);
        }
        public void PrintInvoice(Customer c)
        {
            int payment = PRICE * c.tickets.Number;
            Console.WriteLine("Payment: " + payment + "," + c.GetIncentives());
        }
        
        public void Run()
        {
            bool run = true;
            while(run)
            {
                PrintMenu();

                Customer c = new Customer();
                int choice = c.GetMoiveChoice();
                int nTickets = c.GetNumberOfTicket();
                string seats = c.GetSeats(nTickets);
                c.GetIncentives();
                string movie = movies[choice];

                Ticket t = new Ticket(movie, seats, nTickets);

                PrintBill(t);
                c.tickets = t;

                PrintInvoice(c);
            }
        }
    }
}