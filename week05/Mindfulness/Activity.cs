namespace Mindfulness
{
    class Activity
    {
        private string _name;
        private string _description;
        private int _duration;

        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }


        public void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"Starting {_name} Activity");
            Console.WriteLine(_description);
            Console.Write("Enter duration in seconds: ");
            _duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Prepare to begin...");
            ShowSpinner(3);
        }

        public void DisplayEndingMessage()
        {
            Console.WriteLine("\nWell done!");
            ShowSpinner(2);
            Console.WriteLine($"You completed {_duration} seconds of the {_name} activity.");
            ShowSpinner(3);
        }

        public void ShowSpinner(int seconds)
        {
            List<string> spinner = new List<string>() { "|", "/", "--", "\\" };
            DateTime end = DateTime.Now.AddSeconds(seconds);
            int i = 0;

            while (DateTime.Now < end)
            {
                Console.Write(spinner[i % spinner.Count]);
                Thread.Sleep(300);
                Console.Write("\b \b");
                i++;
            }
        }

        public void ShowCountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        public int GetDuration()
        {
            return _duration;
        }


    }
}
