using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        double average = (double)sum / numbers.Count;

        int maxNumber = numbers[0];
        foreach (int num in numbers)
        {
            if (num > maxNumber)
            {
                maxNumber = num;
            }
        }

        int smallestPositive = int.MaxValue;
        foreach (int num in numbers)
        {
            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
            }
        }

        numbers.Sort();

        Console.WriteLine($"The sum is: {sum}");


        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The largest number is: {maxNumber}");

        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        Console.WriteLine("The sorted list is:");


        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("Press Enter to exit...XD");
        Console.ReadLine();

    }
}
