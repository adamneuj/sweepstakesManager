using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakesManager
{
    class MarketingFirm
    {
        bool stack;

        public MarketingFirm()
        {

        }
        void CreateNewSweepstakes()
        {
            UserInterface.AskForSweepstakesName();
            Sweepstakes sweepstakes = new Sweepstakes(UserInterface.input);
        }

        void CreateNewSweepStakesManager()
        {
            if (stack)
            {
                SweepstakesStackManager sweepstakesManager = new SweepstakesStackManager();
            }
            else
            {
                SweepstakesQueueManager sweepstakesManager = new SweepstakesQueueManager();
            }
        }

        public void AddToStackOrQueue()
        {
            if (UserInterface.firstTime)
            {
                UserInterface.AskStackOrQueue();
                switch (UserInterface.input)
                {
                    case "1":
                        stack = true;
                        CreateNewSweepStakesManager();
                        CreateNewSweepstakes();
                        break;
                    case "2":
                        CreateNewSweepStakesManager();
                        CreateNewSweepstakes();
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        Console.Clear();
                        AddToStackOrQueue();
                        break;
                }
            }
            else
            {
                CreateNewSweepstakes();
            }
        }
    }
}
