using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakesManager
{
    public class MarketingFirm
    {
        public bool stack;
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
    }
}
