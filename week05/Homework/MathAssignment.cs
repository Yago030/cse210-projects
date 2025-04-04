namespace Homework
{
    class MathAssignment : Assignment
    {
        private string _textBookSection;
        private string _problems;

        public MathAssignment(string textBookSection, string problems, string studentName, string topic) : base(studentName, topic)
        {
            _textBookSection = textBookSection;
            _problems = problems;
        }

        public string GetHomeWorkList()
        {
            return $"{_textBookSection}- {_problems}";
        }

    }
}
