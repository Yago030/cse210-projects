namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;

        public ChecklistGoal(string name, string description, int points, int target, int bonus)
            : base(name, description, points)
        {
            _target = target;
            _bonus = bonus;
            _amountCompleted = 0;
        }

        public int GetBonus()
        {
            return _bonus;
        }

        public override void RecordEvent()
        {
            _amountCompleted++;

            if (IsComplete())
            {
                Console.WriteLine($"Goal completed! You earned {_points + _bonus} points (including bonus).");
            }
            else
            {
                Console.WriteLine($"Event recorded! You earned {_points} points. ({_amountCompleted}/{_target})");
            }
        }

        public override bool IsComplete() => _amountCompleted >= _target;

        public override string GetDetailsString()
        {
            return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description}) -- Completed {_amountCompleted}/{_target}";
        }

        public override string GetStringRepresentation() => "";
    }
}
