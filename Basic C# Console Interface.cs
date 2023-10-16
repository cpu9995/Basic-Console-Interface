using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear(); // Clear the console screen.

            Console.WriteLine("Welcome to My Console App");
            Console.WriteLine("1. Option 1");
            Console.WriteLine("2. Option 2");
            Console.WriteLine("3. Exit");

            Console.Write("Please enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("You selected Option 1. Press any key to continue...");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("You selected Option 2. Press any key to continue...");
                    Console.ReadKey();
                    break;
                case "3":
                    Console.WriteLine("Exiting the program. Press any key to exit...");
                    Console.ReadKey();
                    return;
                default:
                    Console.WriteLine("Invalid choice. Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}