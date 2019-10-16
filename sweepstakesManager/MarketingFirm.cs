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
        SweepstakesStackManager sweepstakesStackManager;
        SweepstakesQueueManager sweepstakesQueueManager;

        public MarketingFirm()
        {

        }
        void CreateNewSweepstakes()
        {
            UserInterface.AskForSweepstakesName();
            Sweepstakes sweepstakes = new Sweepstakes(UserInterface.input);
            if (stack)
            {
                sweepstakesStackManager.InsertSweepstakes(sweepstakes);
                Console.Clear();
                UserInterface.MainMenu(this);
            }
            else
            {
                sweepstakesQueueManager.InsertSweepstakes(sweepstakes);
                Console.Clear();
                UserInterface.MainMenu(this);
            }
        }

        void CreateNewSweepStakesManager()
        {
            if (stack)
            {
                sweepstakesStackManager = new SweepstakesStackManager();
            }
            else
            {
                sweepstakesQueueManager = new SweepstakesQueueManager();
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
