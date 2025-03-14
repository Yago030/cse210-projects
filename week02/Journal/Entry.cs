namespace Journal
{
    class Entry
    {
        public string _date;
        public string _question;
        public string _answer;


        public Entry()
        {
            _date = DateTime.Now.ToShortDateString();

        }

        public void Display()
        {
            Console.WriteLine($"Date : {_date} - Prompt: {_question} ");
            Console.WriteLine(_answer);
            Console.WriteLine();
        }

    }
}
