using System;
using System.Collections.Generic;

namespace Sweepstakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        public Queue<Sweepstakes> sweepstakes;

        public SweepstakesQueueManager()
        {
            sweepstakes = new Queue<Sweepstakes>();
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
