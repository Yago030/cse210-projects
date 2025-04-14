using Shapes;

class Program
{
    static void Main(string[] args)
    {
        Square squareOne = new Square(4, "red");
        Rectangle rectangleOne = new Rectangle("blue", 5, 3);
        Circle circleOne = new Circle("green", 2);



        Console.WriteLine(squareOne.GetColor() + ": " + squareOne.GetArea());

        Console.WriteLine(rectangleOne.GetColor() + ": " + rectangleOne.GetArea());

        Console.WriteLine(circleOne.GetColor() + ": " + circleOne.GetArea());



        List<Shape> shapes = new List<Shape> { squareOne, rectangleOne, circleOne };

        Console.WriteLine("\nLista de formas:");



        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetColor()} shape area: {shape.GetArea()}");
        }


    }
}
