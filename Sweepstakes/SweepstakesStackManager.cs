using System;
using System.Collections.Generic;

namespace Sweepstakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        public Stack<Sweepstakes> sweetstakes;

        public SweepstakesStackManager(){
            sweetstakes = new Stack<Sweepstakes>();
        }

        public Sweepstakes GetSweepstakes(){
            Sweepstakes sweepstakes = new Sweepstakes();
            return sweepstakes;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            GetSweepstakes();
        }
    }
}
