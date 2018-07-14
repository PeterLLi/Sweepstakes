using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Sweepstakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        public Stack<Sweepstakes> sweetstakes;

        public SweepstakesStackManager(){
            sweetstakes = new Stack<Sweepstakes>();
            //stack();
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
