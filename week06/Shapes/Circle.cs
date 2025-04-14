namespace Shapes
{
    class Circle : Shape
    {
        private double _radius;

        public Circle(string color, double radius) : base(color)
        {
            _radius = radius;
        }

        public override float GetArea()
        {
            return (float)(Math.PI * Math.Pow(_radius, 2));
        }
    }
}
