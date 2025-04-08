using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;

class Program
{
    static void Main()
    {
        while (true)
        {
            // Menu
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Select an option from the menu: ");
           
            string choice = Console.ReadLine();

            // What is going to happen if the user choose 4 (finish the program)
            if (choice == "4") break;

            // What is going to happen if the user choose from 1 to 3
            Activity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectingActivity(),
                "3" => new ListingActivity(),
                _ => null
            };

            // What is going to happen if the user choose a number bigger than 4
            if (activity != null)
                activity.Run();
            else
            {
                Console.WriteLine("Invalid choice. Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}