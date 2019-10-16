using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakesManager
{
    public interface IGetStackOrQueue
    {
        ISweepstakesManager GetStackOrQueue(MarketingFirm firm);
    }
}
