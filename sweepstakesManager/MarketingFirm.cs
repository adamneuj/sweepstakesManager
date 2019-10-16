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
        ISweepstakesManager sweepstakesManager;
        SweepstakesManagerFactory sweepstakesManagerFactory;

        public MarketingFirm()
        {
            sweepstakesManagerFactory = new SweepstakesManagerFactory();
        }
        void CreateNewSweepstakes()
        {
            UserInterface.AskForSweepstakesName();
            Sweepstakes sweepstakes = new Sweepstakes(UserInterface.input);
            if (stack)
            {
                sweepstakesManager.InsertSweepstakes(sweepstakes);
                Console.Clear();
                UserInterface.MainMenu(this);
            }
            else
            {
                sweepstakesManager.InsertSweepstakes(sweepstakes);
                Console.Clear();
                UserInterface.MainMenu(this);
            }
        }
        public void GetStackOrQueue()
        {
            if (UserInterface.firstTime)
            {
                UserInterface.AskStackOrQueue();
                sweepstakesManager = sweepstakesManagerFactory.GetStackOrQueue(this);
                CreateNewSweepstakes();
            }
            else
            {
                CreateNewSweepstakes();
            }
        }
    }
}
