using System;
using System.Collections.Generic;

namespace Sweepstakes
{
    public class UserInterface
    {
        public UserInterface()
        {
            String userManagerChoice;

            do
            {
                Console.WriteLine("Queue or Stack?");
                userManagerChoice = Console.ReadLine();
                userManagerChoice.ToLower();
                if(userManagerChoice == ""){
                    Console.WriteLine("Please enter something");
                } else if (userManagerChoice != "queue" && userManagerChoice != "stack"){
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
            List<string> menu = new List<string>();
            int menuChoice;

            menu.Add("1. Register contestant");
            menu.Add("2. Get contestant information");
            menu.Add("3. Play");
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
                    sweepstakes.RegisterContestant();
                    MainMenu(sweepstakes);
                    break;
                case 2:
                    
                    break;
            }
        }
    }
}
