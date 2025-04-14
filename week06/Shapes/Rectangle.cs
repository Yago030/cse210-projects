namespace Shapes
{
    class Rectangle : Shape
    {
        private double _length;
        private double _width;

        public Rectangle(string color, double length, double width) : base(color)
        {
            _length = length;
            _width = width;
        }

        public override float GetArea()
        {
            return (float)(_length * _width);
        }
    }
}
