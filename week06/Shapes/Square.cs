namespace Shapes
{
    class Square : Shape
    {
        private double _side;

        public Square(double side, string color) : base(color)
        {
            _side = side;
        }


        public override float GetArea()
        {
            return (float)(_side * _side);
        }







    }



}
