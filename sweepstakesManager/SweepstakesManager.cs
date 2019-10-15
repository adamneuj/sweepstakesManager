using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakesManager
{
    class SweepstakesManager
    {
        public SweepstakesManager()
        {
            MarketingFirm marketingFirm = new MarketingFirm();
        }
        public void RunManager()
        {
            UserInterface.MainMenu();
        }
    }
}
