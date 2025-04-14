namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> _goals = new List<Goal>();
        private int _score = 0;

        public void Start()
        {
            string input = "";
            while (input != "6")
            {
                Console.Clear();
                DisplayPlayerInfo();
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Create new goal");
                Console.WriteLine("2. List goals");
                Console.WriteLine("3. Record event");
                Console.WriteLine("4. Save goals (not implemented)");
                Console.WriteLine("5. Load goals (not implemented)");
                Console.WriteLine("6. Quit");
                Console.Write("Select an option: ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1": CreateGoal(); break;
                    case "2": ListGoalDetails(); break;
                    case "3": RecordEvent(); break;
                    case "4": Console.WriteLine("Feature not implemented yet."); break;
                    case "5": Console.WriteLine("Feature not implemented yet."); break;
                    case "6": Console.WriteLine("Goodbye!"); break;
                    default: Console.WriteLine("Invalid option."); break;
                }

                if (input != "6")
                {
                    Console.WriteLine("\nPress Enter to continue...");
                    Console.ReadLine();
                }
            }
        }

        private void DisplayPlayerInfo()
        {
            Console.WriteLine($"Current score: {_score}");
        }

        private void ListGoalDetails()
        {
            Console.WriteLine("\nRegistered goals:");
            int index = 1;
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"{index}. {goal.GetDetailsString()}");
                index++;
            }
        }

        private void CreateGoal()
        {
            Console.WriteLine("\nGoal types:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Select type: ");
            string type = Console.ReadLine();

            Console.Write("Short name: ");
            string name = Console.ReadLine();

            Console.Write("Description: ");
            string description = Console.ReadLine();

            Console.Write("Points per completion: ");
            int points = int.Parse(Console.ReadLine());

            Goal newGoal = null;

            if (type == "1")
                newGoal = new SimpleGoal(name, description, points);
            else if (type == "2")
                newGoal = new EternalGoal(name, description, points);
            else if (type == "3")
            {
                Console.Write("How many times to complete it?: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Bonus points for completing: ");
                int bonus = int.Parse(Console.ReadLine());

                newGoal = new ChecklistGoal(name, description, points, target, bonus);
            }

            if (newGoal != null)
                _goals.Add(newGoal);
        }

        private void RecordEvent()
        {
            Console.WriteLine("\nSelect the number of the goal you accomplished:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }

            Console.Write("Number: ");
            int index = int.Parse(Console.ReadLine()) - 1;

            if (index >= 0 && index < _goals.Count)
            {
                _goals[index].RecordEvent();

                if (_goals[index] is ChecklistGoal checklist && checklist.IsComplete())
                    _score += checklist.GetPoints() + checklist.GetBonus();
                else
                    _score += _goals[index].GetPoints();
            }
            else
            {
                Console.WriteLine("Invalid goal number.");
            }
        }
    }
}
