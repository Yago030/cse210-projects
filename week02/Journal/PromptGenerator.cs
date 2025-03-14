namespace Journal
{
    internal class PromptGenerator
    {
        public List<string> _prompts = new List<string>();

        public PromptGenerator()
        {
            _prompts = new List<string> {
                            "How was your day?",
                            "What spiritual thought did you have today?",
                            "What scripture verse was on your mind today?",
                            "Have you had any experience that strengthened your testimony today?",
                            "Do you have any special memory from today?"
                        };
        }


        public string GetRandomPrompt()
        {
            Random rand = new Random();
            int index = rand.Next(_prompts.Count);
            return _prompts[index];
        }

    }
}
