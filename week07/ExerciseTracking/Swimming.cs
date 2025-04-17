namespace ExerciseTracking
{
    class Swimming : Activity
    {
        private int _laps;
        private const double MetersPerMile = 1609.34;

        public Swimming(string date, int length, int laps) : base(date, length)
        {
            _laps = laps;
        }

        public override double GetDistance()
        {
            return (_laps * 50.0) / MetersPerMile;
        }

        public override double GetSpeed()
        {
            return (GetDistance() / GetLength()) * 60;
        }

        public override double GetPace()
        {
            return GetLength() / GetDistance();
        }
    }
}
