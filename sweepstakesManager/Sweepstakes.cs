using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakesManager
{
    public class Sweepstakes
    {
        public string name;
        Contestant winner;
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();

        public Sweepstakes(string name)
        {
            this.name = name;
        }

        void RegisterContestant(Contestant contestant)
        {
            UserInterface.GetFirstName();
            contestant.firstName = UserInterface.input;
            UserInterface.GetLastName();
            contestant.lastName = UserInterface.input;
            UserInterface.GetEmail();
            contestant.email = UserInterface.input;
            contestant.registrationNumber = contestants.Count + 1;
            contestants.Add(contestant.registrationNumber, contestant);
        }

        Contestant PickWinner()
        {
            int winner = RandomNumber.GetRandomNumber(1, contestants.Count);
            //TO DO: find winner;
        }
        void PrintContestantInfo(Contestant contestant)
        {
            //TODO: functionality to print contestant info.  IE Name, Email, and registration number.
        }
    }
}
