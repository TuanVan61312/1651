using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASM1Demo
{
    public class Customer
    {
        private IncentivesForCustomer incentives;
        public Ticket tickets {get; set;}
        public Customer()
        {
            tickets = new Ticket();
        }
        public int GetMoiveChoice()
        {
            bool invalidChoice = true;
            int choice = 0;
            while(invalidChoice)
            {
                Console.Write("Your Choice: ");
                choice = int.Parse(Console.ReadLine());
                invalidChoice = (choice < 1) || (choice > 3);
                if(invalidChoice)
                {
                    Console.WriteLine("Invalid choice, please try again");
                }
            }
            return choice;
        }
        public int GetNumberOfTicket()
        {
            bool invalidNumTicket = true;
            int nTickets = 0;
            while(invalidNumTicket)
            {
                Console.Write("Enter number of ticket: ");
                nTickets = int.Parse(Console.ReadLine());
                invalidNumTicket = (nTickets < 1) || (nTickets > 5);
                if(invalidNumTicket)
                {
                    Console.WriteLine("Choose from 1 to 5");
                }
            }
            return nTickets;
        }
        public string GetSeats(int nTickets)
        {
            string seats = "";
            for(int i = 0; i < nTickets; i++)
            {
                Console.Write("Enter Seat: ");
                string seat = Console.ReadLine();
                seats = seats + seat;
            }
            return seats;
        }
        public int GetIncentives()
        {
            Console.WriteLine("Choose Icentives ");
            Console.WriteLine("1. Incentives by Discount");
            Console.WriteLine("2. Incentives by Gift");
            Console.WriteLine("3. Incentives by Ticket");
            Console.WriteLine("Your choice: ");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1: incentives = new IncentivesByDiscount(); break;
                case 2: incentives = new IncentivesByGift(); break;
                case 3: incentives = new IncentivesByTicket(); break;
                default: incentives = new IncentivesByDiscount(); break;   
                                                   
            }
            return choice;
        }
        public void SetIncentivesForCustomer(IncentivesForCustomer incentivesForCustomer)
        {
            this.incentives = incentives;
        }    
    }
}