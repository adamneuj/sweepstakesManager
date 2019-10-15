using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakesManager
{
    class Program
    {
        static void Main(string[] args)
        {
            MarketingFirm firm = new MarketingFirm();
            UserInterface.MainMenu(firm);
        }
    }
}
