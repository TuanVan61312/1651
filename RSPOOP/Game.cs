using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSPOOP
{
    public class Game
    {
        private const int REWARD = 5;
        private Player player;
        private Bot bot;

        public Game()
        {
            player = new Player();
            bot = new Bot();
        }

        public string CompareResults(string userChoice, string computerChoice)
        {
            if (userChoice == computerChoice)
            {
                return "Tie";
            }
            else if ((userChoice == "Rock" && computerChoice == "Scissors") ||
                (userChoice == "Paper" && computerChoice == "Rock") ||
                (userChoice == "Scissors" && computerChoice == "Paper"))
            {
                return "Win";
            }
            else
            {
                return "Lose";
            }
        }

        public void UpdateBalance(string result)
        {
            if (result == "Win") player.UpdateBalance(REWARD);
            else if(result == "Lose") player.UpdateBalance(-REWARD);
        }

        public void PrintGameStatus(string result)
        {
            Console.WriteLine("Game result: " + result);
            Console.WriteLine("Your current balance: " + player.Balance);
        }

        public void PrintFinalStatus()
        {
            Console.WriteLine("Your final balance: " + player.Balance);
            Console.WriteLine("Thanks for playing!");
        }

        public void Play()
        {
            player.Deposit(50);
            bool playing = true;
            while(playing)
            {
                string computerChoice = bot.GetChoice();
                string userChoice = player.GetChoice();

                string result = CompareResults(userChoice, computerChoice);
                UpdateBalance(result);
                PrintGameStatus(result);
            }
            PrintFinalStatus();
        }
    }
}