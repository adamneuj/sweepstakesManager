using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakesManager
{
    class Sweepstakes
    {
        string name;
        Dictionary<Contestant, int> contestants = new Dictionary<Contestant, int>();

        public Sweepstakes(string name)
        {
            this.name = name;
        }

        void RegisterContestant(Contestant contestant)
        {
            //TODO: build out function for registering each contestant to the sweepstakes
        }

        Contestant PickWinner()
        {
            //TODO: build functionality to pick the winner
        }
        void PrintContestantInfo(Contestant contestant)
        {
            //TODO: functionality to print contestant info.  IE Name, Email, and registration number.
        }
    }
}
