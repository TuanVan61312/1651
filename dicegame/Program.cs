internal class Program
{
    const int REWARD = 5;
    private static void Main(string[] args)
    {
        // int cantplaying;
        bool playing = true;
        int balance = EnterBalance();
        while(playing)
        {
        int dice1 = Dice1();
        int dice2 = Dice2();
        int dice3 = Dice3();

        Console.WriteLine(dice1);
        Console.WriteLine(dice2);
        Console.WriteLine(dice3);

        string userchoice = GetUserChoice();
        int sumofdice = SumofDice(dice1, dice2, dice3);

        string result = CompareResults(userchoice, sumofdice);
        balance = UpdateBalance(balance, result);
        PrintResult(result, sumofdice, balance);


        playing = isContinue() && IsEnoughToPlay(balance);

        // cantplaying = NotEnoughToPlay(balance);
        }
    }
    static int Dice1()
    {
        Random ramdom = new Random();
        int[] choices = {1,2,3,4,5,6};
        int dice = choices[ramdom.Next(1, 6)];
        return dice;
    }
    static int Dice2()
    {
        Random ramdom = new Random();
        int[] choices = {1,2,3,4,5,6};
        int dice = choices[ramdom.Next(1, 6)];
        return dice;
    }
    static int Dice3()
    {
        Random ramdom = new Random();
        int[] choices = {1,2,3,4,5,6};
        int dice = choices[ramdom.Next(1, 6)];
        return dice;
    }

    static int SumofDice(int dice1, int dice2, int dice3)
    {
        int sum = dice1 + dice2 + dice3;
        return sum;
    }

    static string GetUserChoice()
    {
        string userChoice = "";
        bool validChoice = false;
        while(!validChoice)
        {
            Console.WriteLine("chon Tai hoac Xiu ");
            userChoice = Console.ReadLine();
            validChoice = userChoice == "Tai" || userChoice == "Xiu";
            if (!validChoice)
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }  
        return userChoice;
    }
    
    static string CompareResults(string userchoice, int sumofdice)
    {
        if ((userchoice == "Tai" && sumofdice >= 10) || (userchoice == "Xiu" && sumofdice <= 9))
        {
            return "Win";
        }else
        {
            return "Lose";
        }
    }

    static void PrintResult(string result, int sumofdice, int balance)
    {
        Console.WriteLine("Sum of dice: " + sumofdice);
        Console.WriteLine("Game result: " + result);
        Console.WriteLine("Balance: " + balance);
    }

    static bool isContinue()
    {
        Console.WriteLine("Do you want play again ? (y/n): ");
        string playAgain = Console.ReadLine();
        bool playing = playAgain == "y";
        return playing;
    }

    static int EnterBalance()
    {
        Console.WriteLine("Enter your balance: ");
        int balance = int.Parse(Console.ReadLine());
        return balance;
    }

    static int UpdateBalance(int balance, string result)
    {
        if (result == "Win") balance += REWARD;
        else if (result == "Lose") balance -= REWARD;
        return balance;
    }

    static bool IsEnoughToPlay(int balance)
    {
        return balance >= REWARD;
    }

    // static bool NotEnoughToPlay(int balance)
    // {
    //     return balance < REWARD;
    // }
}