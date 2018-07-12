using System;
using System.Collections.Generic;

namespace Sweepstakes
{
    public class Contestant
    {
        public List<string> contestants = new List<string>();
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public int registrationNumber { get; set; }

        public void AddContestant()
        {
            string userChoice;   
            Console.WriteLine("Adding contestant");
            Console.WriteLine("Does this look correct?");
            Console.WriteLine("");
            userChoice = Console.ReadLine();
            userChoice.ToLower();
        }
    }
}
