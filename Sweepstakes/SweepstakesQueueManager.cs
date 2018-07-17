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
            Sweepstakes sweepstakes = new Sweepstakes();
            return sweepstakes;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            GetSweepstakes();
        }
    }
}
