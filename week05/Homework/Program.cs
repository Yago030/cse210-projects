using Homework;

class Program
{
    static void Main(string[] args)
    {
        Assignment newAsing = new Assignment("Pablo", "Matematicas");
        MathAssignment matiAsing = new MathAssignment("7.3", "Problemas 8-19", "Sancho Panza", "Fracciones");
        WritingAssignment writi = new WritingAssignment("Santiago Bergerat", "Historia", "La Segunda Guerra Mundial");

        Console.WriteLine(newAsing.GetSumary());

        Console.WriteLine(matiAsing.GetSumary());
        Console.WriteLine(matiAsing.GetHomeWorkList());

        Console.WriteLine(writi.GetSumary());
        Console.WriteLine(writi.GetWritingInformation());
    }
}
