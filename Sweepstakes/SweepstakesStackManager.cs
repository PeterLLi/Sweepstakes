using System;
using System.Collections.Generic;

namespace Sweepstakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        public Stack<Sweepstakes> sweetstakes;

        public SweepstakesStackManager()
        {
            sweetstakes = new Stack<Sweepstakes>();
        }

        public Sweepstakes GetSweepstakes()
        {
            Contestant contestant = new Contestant();
            string name = contestant.firstName;
            Sweepstakes sweepstakes = new Sweepstakes(name);
            return sweepstakes;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            GetSweepstakes();
        }
    }
}
