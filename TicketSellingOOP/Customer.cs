using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSellingOOP
{
    public class Customer
    {
        private int MIN_NTICKET = 1;
        private int MAX_TICKET = 5;
        public bool VIP { get; set; }
        public Ticket MyTicket { get; set; }

        public Customer()
        {
            MyTicket = new Ticket();
        }

        public int GetMovieChoice(int maxChoice)
        {
            // ask user to enter a choice (1, 2, 3, ..)
            // then return choice
            bool invalidChoice = true;
            int choice = 0;
            while(invalidChoice)
            {
                Console.Write("your choice: ");
                choice = int.Parse(Console.ReadLine());
                invalidChoice = (choice < 1) || (choice > maxChoice);
                if (invalidChoice) System.Console.WriteLine("Invalid choice, try again");
            }
            return choice;  
        }

        public int GetNumberOfTickets()
        {
            bool invalidTicket = true;
            int nTickets = 0;
            while(invalidTicket)
            {
                Console.Write("How many tickets?");
                nTickets = int.Parse(Console.ReadLine());
                invalidTicket = (nTickets < MIN_NTICKET) || (nTickets > MAX_TICKET);
                if (invalidTicket) System.Console.WriteLine("number must be in [1,5], try again");  
            }
            
            return nTickets;
        }

        public string GetSeats(int nTickets)
        {
            string seats = "";
            for (int i = 0; i < nTickets; i++)
            {
                Console.WriteLine("enter seat: ");
                string seat = Console.ReadLine();
                seats += seat;
            }
            return seats;
        }

        public void SetVIP()
        {
            // ask user if user wants to be VIP or not
            // set VIP property
             Console.Write("are you a vip member ? (y/n): ");
            string answer = Console.ReadLine();
            if(answer == "Y")
            {
                VIP = true;
            }else
            {
                VIP = false;
            }
        } 
    }
}