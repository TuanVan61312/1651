using ASM1;

Customer tuan = new Customer(new IncentivesByDiscount());
tuan.BuyTicket(new Ticket("HN-HP", "1A", 50));
tuan.BuyTicket(new Ticket("aaaaa", "5A", 40));
tuan.BuyTicket(new Ticket("wwww", "6A", 30));
tuan.Show();
Console.WriteLine("====================");
tuan.SetIncentivesForCustomer(new IncentivesByDiscount());
tuan.Show();
Console.WriteLine("====================");
tuan.SetIncentivesForCustomer(new IncentivesbyGift());
tuan.Show();
Console.WriteLine("====================");
tuan.SetIncentivesForCustomer(new IncentivesByTicket());
tuan.Show();