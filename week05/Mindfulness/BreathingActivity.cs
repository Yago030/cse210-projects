namespace Mindfulness
{
    class BreathingActivity : Activity
    {
        public BreathingActivity()
            : base("Breathing", "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath.")
        {
        }

        public void Run()
        {
            int duration = GetDuration();
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(duration);

            while (DateTime.Now < endTime)
            {
                Console.WriteLine("\nInhale...");
                ShowCountDown(3);

                Console.WriteLine("Exhale...");
                ShowCountDown(3);
            }
        }
    }
}
