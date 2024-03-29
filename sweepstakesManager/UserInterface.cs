﻿using System;
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
                "Press 2 to Add contestants to Sweepstakes and Select Winner");
            input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    firm.GetStackOrQueue();
                    MainMenu(firm);
                    break;
                case "2":
                    if(firstTime)
                    {
                        Console.WriteLine("No sweepstakes present.  Please create new sweepstakes.");
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        MainMenu(firm);
                    }
                    else
                    {
                        firm.RegisterAndPickWinner();
                        MainMenu(firm);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid input.  Please try again.");
                    Console.Clear();
                    MainMenu(firm);
                    break;
            }
        }
        public static void GetSweepstakesName()
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
        public static void GetFirstName()
        {
            Console.Clear();
            Console.WriteLine("Contestant Information");
            Console.WriteLine("First name: ");
            input = Console.ReadLine();
        }
        public static void GetLastName()
        {
            Console.WriteLine("\nLast name: ");
            input = Console.ReadLine();
        }
        public static void GetEmail()
        {
            Console.WriteLine("\nEmail: ");
            input = Console.ReadLine();
        }
        public static void AskToRegisterMoreContestants()
        {
            Console.WriteLine("\nDo you want to register another contestant?");
            input = Console.ReadLine();
        }
    }
}
