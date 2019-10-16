using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakesManager
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> queue;
        Sweepstakes currentSweepstakes;

        public SweepstakesQueueManager()
        {
            queue = new Queue<Sweepstakes>();
        }

        public Sweepstakes GetSweepstakes()
        {
            currentSweepstakes = queue.Dequeue();
            return currentSweepstakes;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }
    }
}
