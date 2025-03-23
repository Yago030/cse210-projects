
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
