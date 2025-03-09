using System;

class Program
{
    static void Main(string[] args)
    {
        
     
        DisplayWelcome();

        string nameUser = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squareNumberUser = SquareNumber(favoriteNumber);

        DisplayResult(nameUser, squareNumberUser);

        Console.ReadLine();
    }


    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string nameUser = Console.ReadLine();
        return nameUser;
    }


    static int PromptUserNumber()
    {
        Console.Write("Please enter your Number Favorite: ");
        int numberUser = int.Parse(Console.ReadLine());
        return numberUser;
    }


    static int SquareNumber(int number)
    {
        int numberNew = number * number;
        return numberNew;
    }

    
    static void DisplayResult(string nameUser, int squaredNumber)
    {
        Console.WriteLine($"Brother {nameUser}, the square of your number is {squaredNumber}.");
    }


}