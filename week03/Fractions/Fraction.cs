namespace Fractions
{
    class Fraction
    {
        private int _top;
        private int _bottom;

        public Fraction()
        {
            _top = 1;
            _bottom = 1;
        }

        public Fraction(int number)
        {
            _top = number;
            _bottom = 1;
        }

        public Fraction(int number1, int number2)
        {
            _top = number1;
            _bottom = number2;
        }



        public int GetTop()
        {
            return _top;
        }

        public void SetTop(int topNumber)
        {
            _top = topNumber;
        }

        public int GetBottom()
        {
            return _bottom;
        }

        public void SetBottom(int bottomNumber)
        {
            _bottom = bottomNumber;
        }



        public string GetFractionString()
        {

            return $"{_top}/{_bottom}";
        }

        public double GetDecimalValue()
        {
            return (double)_top / _bottom;
        }

    }
}
