//Author: Santiago Bergerat
// This program allows users to write journal entries based on random prompts, save them to a CSV file, and load them later. 
// To exceed the basic requirements, additional improvements were made, including structured file handling with CSV formatting, 
// ensuring data is stored in an organized manner. The program also incorporates error validation for file handling, preventing 
// crashes due to missing or incorrectly formatted files. Additionally, when loading a journal file, the entries are automatically 
// displayed to enhance usability. Input validation was added to the menu to ensure users enter valid options, making the program 
// more robust and user-friendly. These enhancements improve both functionality and user experience.


namespace Journal
{
    class Journal
    {
        public List<Entry> _entries = new List<Entry>();


        public Journal()
        {

        }

        public void AddEntry()
        {
            PromptGenerator prompt = new PromptGenerator();

            string question = prompt.GetRandomPrompt();
            Console.WriteLine(question);
            string answer = Console.ReadLine();

            Entry entrie = new Entry();
            entrie._question = question;
            entrie._answer = answer;

            _entries.Add(entrie);

        }

        public void DisplayEntries()
        {
            foreach (Entry entrie in _entries)
            {
                entrie.Display();
            }

        }
        public void SaveToFile()
        {
            Console.WriteLine("\nPlease enter the file name.\n");

            string nameFile = Console.ReadLine();

            if (!nameFile.EndsWith(".csv"))
            {
                nameFile += ".csv";
            }

            using (StreamWriter writer = new StreamWriter(nameFile))
            {
                foreach (Entry entrie in _entries)
                {

                    writer.WriteLine($"{entrie._date} | {entrie._question} | {entrie._answer} ");
                }
            }

        }

        public void LoadFromFile()
        {
            Console.WriteLine("\nWhat is the name of the file you want to search for?\n");
            string nameFile = Console.ReadLine();

            if (!nameFile.EndsWith(".csv"))
            {
                nameFile += ".csv";
            }

            if (!File.Exists(nameFile))
            {
                Console.WriteLine("\nSorry, the file you are looking for was not found in the system.\n");
                return;
            }

            _entries.Clear();

            using (StreamReader reader = new StreamReader(nameFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] partes = line.Split('|');

                    if (partes.Length == 3)
                    {
                        Entry newEntry = new Entry();
                        newEntry._date = partes[0].Trim();
                        newEntry._question = partes[1].Trim();
                        newEntry._answer = partes[2].Trim();

                        _entries.Add(newEntry);
                    }
                    else
                    {
                        Console.WriteLine("\nWarning: Incorrect file format, skipping line.\n");
                    }
                }
            }

            Console.WriteLine("\nEntries loaded successfully!\n");

            DisplayEntries();
        }


    }
}
