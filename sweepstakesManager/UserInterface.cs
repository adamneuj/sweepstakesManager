using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakesManager
{
    class UserInterface
    {
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
