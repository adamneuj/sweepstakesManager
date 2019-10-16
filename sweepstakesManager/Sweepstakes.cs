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
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();

        public Sweepstakes(string name)
        {
            this.name = name;
        }

        void RegisterContestant(Contestant contestant)
        {
            //TODO: build out function for registering each contestant to the sweepstakes
        }

        //Contestant PickWinner()
        //{
        //    int winner = RandomNumber.GetRandomNumber(1, contestants.Count);
        //    //TO DO: find winner;
        //}
        void PrintContestantInfo(Contestant contestant)
        {
            //TODO: functionality to print contestant info.  IE Name, Email, and registration number.
        }
    }
}
