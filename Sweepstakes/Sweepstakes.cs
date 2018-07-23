using System;
using System.Collections.Generic;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        public int registrationNumber { get; set; }
        public Dictionary<int, Contestant> contestantInfo = new Dictionary<int, Contestant>();

        public Sweepstakes(string name)
        {
            registrationNumber = 1;

        }

        public void addContestant()
        {
            Contestant contestant = new Contestant();
            Console.WriteLine("First name: ");
            contestant.firstName = Console.ReadLine();
            Console.WriteLine("Last name: ");
            contestant.lastName = Console.ReadLine();
            Console.WriteLine("Email: ");
            contestant.email = Console.ReadLine();
            contestant.registrationNumber = registrationNumber;
            registrationNumber++;
            string name = contestant.firstName;
            RegisterContestant(contestant);
        }

        public void RegisterContestant(Contestant contestant)
        {
            Console.WriteLine("");
            Console.WriteLine($"Information received: First name: {contestant.firstName} \nLast name: {contestant.lastName} \nEmail address: {contestant.email} \nRegistration:{contestant.registrationNumber}");
            contestantInfo.Add(contestant.registrationNumber, contestant);
            Console.WriteLine("");
            PrintContestantInfo(contestant);
        }

        public string PickWinner()
        {
            Random random = new Random();
            int randomContestant = random.Next(1, contestantInfo.Count + 1);
            if(contestantInfo.ContainsKey(randomContestant)){
                return contestantInfo[randomContestant].firstName + " " + contestantInfo[randomContestant].lastName;
            } else {
                Console.WriteLine(randomContestant);
                return "Error!";
            }

        }

        public void PrintContestantInfo(Contestant contestant)
        {
            string userConfirmation;
            Console.WriteLine("Does this look correct?");
            userConfirmation = Console.ReadLine();
            userConfirmation.ToLower();
            if(userConfirmation == "yes"){
                Console.WriteLine("Your information has been entered");
                return;
            } else {
                RegisterContestant(contestant);
            }
        }
    }
}
