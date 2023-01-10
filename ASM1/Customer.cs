using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASM1
{
    public class Customer
    {
        // private string name;
        // private int age;
        // private int phone;
        // public string Name
        // {
        //     get {return name;}
        //     set {name = value;}
        // }
        // public int Age
        // {
        //     get {return age;}
        //     set {age = value;}
        // }
        // public int Phone 
        // {
        //     get {return phone;}
        //     set {phone = value;}
        // }
        // private int MIN_NTICKET = 1;
        // private int MAX_NTICKET = 5;
        // public bool VIP {get;set;}
        private List<Ticket> tickets;
        private IIncentivesForCustomer incentivesForCustomer;
        public Customer(IIncentivesForCustomer incentivesForCustomer)
        {
            tickets = new List<Ticket>();
            this.incentivesForCustomer = incentivesForCustomer;
        }
        public void SetIncentivesForCustomer (IIncentivesForCustomer incentivesForCustomer)
        {
            this.incentivesForCustomer = incentivesForCustomer;
        }
        public void BuyTicket(Ticket t)
        {
            tickets.Add(t);
        }
        // public int GetMovieChoice(int maxChoice)
        // {
        //     bool invalidChoice = true;
        //     int choice = 0;
        //     while (invalidChoice)
        //     {
        //         Console.Write("Your choice: ");
        //         choice = int.Parse(Console.ReadLine());
        //         invalidChoice = (choice < 1) || (choice > maxChoice);
        //         if(invalidChoice)
        //         {
        //             Console.WriteLine("Invalid choice. Try again!!");
        //         }
        //     }
        //     return choice;
        // }
        // public int GetNumberOfTickets()
        // {
        //     bool invalidNTickets = true;
        //     int nTickets = 0;
        //     while (invalidNTickets)
        //     {
        //         Console.Write("Enter number of tickets: ");
        //         nTickets = int.Parse(Console.ReadLine());
        //         invalidNTickets = (nTickets < MIN_NTICKET) || (nTickets) > MAX_NTICKET;
        //         if(invalidNTickets)
        //         {
        //             Console.WriteLine("Number must be in [1, 5]. Try again.");
        //         }
        //     }
        //     return nTickets;
        // }
        // public string GetSeats(int nTickets)
        // {
        //     string seats = "";
        //     for(int i = 0; i < nTickets; i++)
        //     {
        //         Console.Write("Enter seat: ");
        //         string seat = Console.ReadLine();
        //         seats += seat;
        //     }
        //     return seats;
        // }
        // public void SetVIP()
        // {
        //     Console.Write("Are you VIP member? (y/n): ");
        //     string answer = Console.ReadLine();
        //     if(answer == "y")
        //     {
        //         VIP = true;
        //     }else
        //     {
        //         VIP = false;
        //     }
        // }
        public void Show()
        {
            incentivesForCustomer.Incentives(tickets);
            foreach(Ticket t in tickets)
            {
                Console.WriteLine(t);
            }
        }
    }
}