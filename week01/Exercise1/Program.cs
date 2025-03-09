using System;

class Program
{
    static void Main(string[] args)
    {
        string name;
        string lastName;

        Console.Write("What is your first Name: ? ");
        name = Console.ReadLine();

        Console.Write("What is your Last Name: ? ");
        lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {name} {lastName}. ");


        Console.ReadLine();

    }
}