namespace Mindfulness
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Mindfulness Program");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflecting Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Quit");
                Console.Write("Choose an option (1-4): ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.DisplayStartingMessage();
                    breathing.Run();
                    breathing.DisplayEndingMessage();
                }
                else if (choice == "2")
                {
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.DisplayStartingMessage();
                    reflecting.Run();
                    reflecting.DisplayEndingMessage();
                }
                else if (choice == "3")
                {
                    ListingActivity listing = new ListingActivity();
                    listing.DisplayStartingMessage();
                    listing.Run();
                    listing.DisplayEndingMessage();
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Press Enter to try again.");
                    Console.ReadLine();
                }

                Console.WriteLine("\nPress Enter to return to the menu...");
                Console.ReadLine();
            }
        }
    }
}
