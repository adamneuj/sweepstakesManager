using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakesManager
{
    public class SweepstakesManagerFactory: IGetStackOrQueue
    {
        public ISweepstakesManager GetStackOrQueue(MarketingFirm firm)
        {
            switch (UserInterface.input)
            {
                case "1": // STACK
                    firm.stack = true;
                    return new SweepstakesStackManager();
                case "2": // QUEUE
                    return new SweepstakesQueueManager();
                default:
                    Console.WriteLine("Invalid input.  Please try again.");
                    GetStackOrQueue(firm);
                    throw new ApplicationException(string.Format("Invalid Input"));
            }
        }
    }
}
