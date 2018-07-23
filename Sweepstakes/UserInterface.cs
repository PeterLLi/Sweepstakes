using System;
using System.Collections.Generic;

namespace Sweepstakes
{
    public class UserInterface
    {
        public int registrationNumber { get; set; }

        public UserInterface()
        {
            registrationNumber = 1;
            String userManagerChoice;

            Console.WriteLine("Queue or Stack?");
            userManagerChoice = Console.ReadLine();
            userManagerChoice.ToLower();

            do
            {
                if(userManagerChoice == ""){
                    Console.WriteLine("Please enter something");
                    userManagerChoice = Console.ReadLine();
                } else if (userManagerChoice != "queue" && userManagerChoice != "stack"){
                    userManagerChoice = Console.ReadLine();
                    Console.WriteLine("Please enter something valid");
                }
            } while (userManagerChoice != null && userManagerChoice != "queue" && userManagerChoice != "stack");

            if(userManagerChoice == "queue"){
                Factory.CreateQueue();
            } else if (userManagerChoice == "stack"){
                Factory.CreateStack();
            }
        }

        public void MainMenu(Sweepstakes sweepstakes){
            Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
            List<string> menu = new List<string>();
            int menuChoice;

            menu.Add("1. Register contestant");
            menu.Add("2. Play");
            Console.WriteLine("Welcome to sweepstakes");

            for (int i = 0; i < menu.Count; i++)
            {
                Console.WriteLine(menu[i]);
            }
            while (!int.TryParse(Console.ReadLine(), out menuChoice))
            {
                Console.WriteLine("Please input something valid");
                Console.WriteLine("Choose a menu option");
            }

            switch (menuChoice)
            {
                case 1:
                    sweepstakes.addContestant();
                    MainMenu(sweepstakes);
                    break;
                case 2:
                    string winnerInfo = sweepstakes.PickWinner();
                    Console.WriteLine(winnerInfo);
                    MainMenu(sweepstakes);
                    break;
            }
        }


    }
}
