using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakesManager
{
    class UserInterface
    {
        public static void MainMenu()
        {
            Console.WriteLine("Sweepstakes Manager\n" +
                "Press 1 to Create New Sweepstakes\n" +
                "Press 2 to Add contestants to Sweepstakes\n" +
                "Press 3 to Select winner");
            string select = Console.ReadLine();
            switch (select)
            {
                case "1":
                    // TODO: create new sweepstakes
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
                    MainMenu();
                    break;
            }
        }
        public Contestant GetFirstName(Contestant contestant)
        {
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
