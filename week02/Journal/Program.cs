//Author: Santiago Bergerat
// This program allows users to write journal entries based on random prompts, save them to a CSV file, and load them later. 
// To exceed the basic requirements, additional improvements were made, including structured file handling with CSV formatting, 
// ensuring data is stored in an organized manner. The program also incorporates error validation for file handling, preventing 
// crashes due to missing or incorrectly formatted files. Additionally, when loading a journal file, the entries are automatically 
// displayed to enhance usability. Input validation was added to the menu to ensure users enter valid options, making the program 
// more robust and user-friendly. These enhancements improve both functionality and user experience.



class Program
{
    static void Main(string[] args)
    {

        Journal.Journal myJournal = new Journal.Journal();

        Console.WriteLine("Welcome to the Journal Program !!.");

        while (true)
        {
            Console.WriteLine("\nPlease Select one of thee following choices: ?: ");
            Console.WriteLine("1 - Write");
            Console.WriteLine("2 - Display");
            Console.WriteLine("3 - Load");
            Console.WriteLine("4 - Save ");
            Console.WriteLine("5 - QUIT");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        myJournal.AddEntry();
                        break;
                    case 2:
                        myJournal.DisplayEntries();
                        break;
                    case 3:
                        myJournal.LoadFromFile();
                        break;
                    case 4:
                        myJournal.SaveToFile();
                        break;
                    case 5:
                        Console.WriteLine("Thank you, have a beautiful day, see you tomorrow.");
                        Thread.Sleep(3000);
                        return;
                    default:
                        Console.WriteLine("Please enter a valid option.");
                        break;
                }


            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }


        }
    }
}