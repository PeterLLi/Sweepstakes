using System;
using System.Collections.Generic;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        public int registrationNumber { get; set; }
        public Dictionary<int, Contestant> contestantInfo = new Dictionary<int, Contestant>();

        public Sweepstakes()
        {
            registrationNumber = 1;
        }

        public void RegisterContestant()
        {
            Contestant contestant = new Contestant();

            Console.WriteLine("First name: ");
            contestant.firstName = Console.ReadLine();
            Console.WriteLine("Last name: ");
            contestant.lastName = Console.ReadLine();
            Console.WriteLine("Email: ");
            contestant.email = Console.ReadLine();
            contestant.registrationNumber = registrationNumber;
            contestantInfo.Add(contestant.registrationNumber, contestant);
            registrationNumber++;
            Console.WriteLine("");
            Console.WriteLine($"Information received: First name: {contestant.firstName} \nLast name: {contestant.lastName} \nEmail address: {contestant.email} \nRegistration:{contestant.registrationNumber}");
            Console.WriteLine("");
            UserInterface.getContestant(contestant);
        }

        public string PickWinner()
        {
            return "hello";
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            
            Console.WriteLine("This is it");
        }
    }
}
