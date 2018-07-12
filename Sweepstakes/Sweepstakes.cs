using System;
using System.Collections.Generic;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        public int registrationNumber { get; set; }
        Dictionary<int, Contestant> contestantInfo = new Dictionary<int, Contestant>();

        public Sweepstakes()
        {
            Interface();
            registrationNumber = 1;
        }

        public void Interface()
        {
            List<string> menu = new List<string>();
            int menuChoice;

            menu.Add("1. Register contestant");
            menu.Add("2. Get contestant information");
            menu.Add("3. PLay");
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

            switch(menuChoice)
            {
                case 1:
                    RegisterContestant();
                    break;
            }
        }


        public void RegisterContestant()
        {
            string firstName;
            string lastName;
            string email;
            Contestant contestant = new Contestant();

            Console.WriteLine("First name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Email: ");
            email = Console.ReadLine();

            contestant.firstName = firstName;
            contestant.lastName = lastName;
            contestant.email = email;

            contestant.AddContestant();
        }

        public string PickWinner()
        {
            return "hello";
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            
        }
    }
}
