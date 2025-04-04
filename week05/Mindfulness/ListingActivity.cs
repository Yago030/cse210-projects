namespace Mindfulness
{
    class ListingActivity : Activity
    {
        private int _count;
        private List<string> _prompts;

        public ListingActivity()
            : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
            _prompts = new List<string>()
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who have you helped this week?",
                "When have you felt the Holy Spirit this month?",
                "Who are some of your personal heroes?"
            };
        }

        public void Run()
        {
            int duration = GetDuration();

            Random rand = new Random();

            string prompt = _prompts[rand.Next(_prompts.Count)];

            Console.WriteLine("List as many responses as you can to the following prompt:");
            Console.WriteLine($"--- {prompt} ---");
            Console.Write("You may begin in: ");


            ShowCountDown(5);

            DateTime startTime = DateTime.Now;


            DateTime endTime = startTime.AddSeconds(duration);

            _count = 0;

            while (DateTime.Now < endTime)
            {
                Console.Write(" > ");

                string input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    _count++;
                }
            }

            Console.WriteLine($"\nYou listed {_count} items!");
        }

    }
}
