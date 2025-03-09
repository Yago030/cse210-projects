using System;

class Program
{
    static void Main(string[] args)
    {
        int nota;
        string letter;
        string sign = "";

        Console.Write("Hello, enter the percentage of your grade: ");
        nota = int.Parse(Console.ReadLine());

        if (nota >= 90)
        {
            letter = "A";
        }
        else if (nota >= 80)
        {
            letter = "B";

        }
        else if (nota >= 70)
        {
            letter = "C";
        }
        else if (nota >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int ultimoDigito = nota % 10;

        if (letter != "A" && letter != "F")
        {
            if (ultimoDigito >= 7)
            {
                sign = "+";
            }
            else if (ultimoDigito < 3)
            {
                sign = "-";
            }
        }
        Console.WriteLine($"Your letter grade is: {letter}{sign}");
        if (nota >= 70)
        {
            Console.WriteLine("Congratulations, you have passed.");
        }
        else
        {
            Console.WriteLine("Failing is not the same as failure; it's an opportunity to try again.");
        }

        Console.ReadLine();
    }
}
