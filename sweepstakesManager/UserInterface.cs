using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakesManager
{
    class UserInterface
    {
        public static string input;
        public static bool firstTime = true;
        public static void MainMenu(MarketingFirm firm)
        {
            Console.WriteLine("Sweepstakes Manager\n" +
                "Press 1 to Create New Sweepstakes\n" +
                "Press 2 to Add contestants to Sweepstakes\n" +
                "Press 3 to Select winner");
            input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    firm.GetStackOrQueue();
                    MainMenu(firm);
                    break;
                case "2":
                    // TODO: find sweepstakes for marketing firm
                    break;
                case "3":
                    // TODO: select winner
                    break;
                default:
                    Console.WriteLine("Not valid input.  Please try again.");
                    Console.Clear();
                    MainMenu(firm);
                    break;
            }
        }
        public static void AskForSweepstakesName()
        {
            Console.Clear();
            Console.WriteLine("What would you like for the name of the sweepstakes?");
            input = Console.ReadLine();
        }
        public static void AskStackOrQueue()
        {
            Console.WriteLine();
            Console.WriteLine("Press 1 to use stack to store your sweepstakes.\n" +
                "Press 2 to use queue to store your sweepstakes.");
            input = Console.ReadLine();
            firstTime = false;
        }
        public Contestant GetFirstName(Contestant contestant)
        {
            Console.Clear();
            Console.WriteLine("Contestant Information");
            Console.WriteLine("First name: ");
            contestant.firstName = Console.ReadLine();
            return contestant;
        }
        public Contestant GetLastName(Contestant contestant)
        {
            Console.WriteLine("Last name: ");
            contestant.lastName = Console.ReadLine();
            return contestant;
        }
        public Contestant GetEmail(Contestant contestant)
        {
            Console.WriteLine("Email: ");
            contestant.email = Console.ReadLine();
            return contestant;
        }
    }
}
