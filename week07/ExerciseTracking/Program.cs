namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            var running = new Running("03 Nov 2022", 30, 3.0);
            var cycling = new Cycling("03 Nov 2022", 45, 15.0);
            var swimming = new Swimming("03 Nov 2022", 40, 30);

            List<Activity> activities = new List<Activity>
            {
                running,
                cycling,
                swimming
            };

            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
