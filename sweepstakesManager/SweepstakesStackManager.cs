using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakesManager
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> stack;
        Sweepstakes currentSweepstakes;
        public SweepstakesStackManager()
        {
            stack = new Stack<Sweepstakes>();
        }

        public Sweepstakes GetSweepstakes()
        {
            currentSweepstakes = stack.Pop();
            return currentSweepstakes;
        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }

    }
}
