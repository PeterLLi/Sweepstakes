using System;
using System.Collections.Generic;

namespace Sweepstakes
{
    public static class Factory
    {
        public static SweepstakesQueueManager CreateQueue(){
            return new SweepstakesQueueManager();
        }

        public static SweepstakesStackManager CreateStack(){
            return new SweepstakesStackManager();
        }
    }
}
