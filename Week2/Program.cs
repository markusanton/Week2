using System;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greeting the user and asking for their name
            Console.WriteLine("Hello! What's your name?");
            string name = Console.ReadLine();

            // Asking the user when they were born
            Console.WriteLine("Hello, " + name + "!");
            Console.WriteLine("How old are you?");
            string dobUserInput = Console.ReadLine();

            // Converting user input into an int
            int dobInt;
            dobInt = Int32.Parse(dobUserInput);

            // Calculations
            int dobCalculated = 2020 - dobInt;

            // Printing out the users age
            Console.WriteLine("You were born in " + dobCalculated + ".");
        }
    }
}
