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
        Contestant winningContestant;
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
            winningContestant = contestants[winner];
            return winningContestant;
        }
        void PrintContestantInfo(Contestant contestant)
        {
            Console.Clear();
            Console.WriteLine(this.name + " WINNER");
            Console.WriteLine("Registration Number: " + contestant.registrationNumber);
            Console.WriteLine("Name: " + contestant.firstName + " " + contestant.lastName);
            Console.WriteLine("Email: " + contestant.email);
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        public void Register()
        {
            Contestant contestant = new Contestant();
            RegisterContestant(contestant);
        }
        public void ChooseAndPrintWinner()
        {
            PickWinner();
            PrintContestantInfo(winningContestant);
        }
    }
}
