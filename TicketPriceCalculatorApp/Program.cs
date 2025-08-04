using System;

namespace TicketPriceCalculatorApp
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age <= 12 || age >= 65)
                Console.WriteLine("Ticket Price: GHC7");
            else
                Console.WriteLine("Ticket Price: GHC10");

            Console.ReadLine(); // Keeps the window open
        }
    }
}
