namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points) : base(name, description, points)
        {
        }

        public override void RecordEvent()
        {
            Console.WriteLine($"Registered! You won!\r\n {_points} points.");
        }

        public override bool IsComplete() => false;

        public override string GetStringRepresentation() => "";
    }
}
