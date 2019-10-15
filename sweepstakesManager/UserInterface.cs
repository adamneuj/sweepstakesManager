using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakesManager
{
    class UserInterface
    {
        public void MainMenu()
        {
            string select;
            Console.WriteLine("Sweepstakes Manager\n" +
                "Press 1 to Input Contestants\n" +
                "Press 2 to Select a Winner");
            select = Console.ReadLine();
            switch (select)
            {
                case "1":
                    // TODO: Input Contestant Process
                    break;
                case "2":
                    // TODO: build out selection process
                    break;
                default:
                    Console.WriteLine("Not valid input.  Please try again.");
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
