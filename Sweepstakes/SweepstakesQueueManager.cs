using System;
using System.Collections.Generic;

namespace Sweepstakes
{
    
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        public SweepstakesQueueManager()
        {
            Queue();
        }

        public void Queue(){
            Queue<string> QueueSweepstakes = new Queue<string>();
            QueueSweepstakes.Enqueue("Hello");
            QueueSweepstakes.Enqueue("Hello");
            QueueSweepstakes.Enqueue("Hello");

            foreach(String queueWord in QueueSweepstakes){
                Console.WriteLine(queueWord);
            }
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
