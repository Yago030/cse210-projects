using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            Random random = new Random();

            int magicNumber = random.Next(1, 101);
            int guess = 0;
            int attempts = 0;

            Console.WriteLine("Welcome to 'Guess My Number'!");


            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                attempts++;

                if (guess > magicNumber)
                {

                    Console.WriteLine("Lower");

                }
                else if (guess < magicNumber)
                {

                    Console.WriteLine("Higher");

                }
                else
                {
                    Console.WriteLine($"You guessed it! It took you {attempts} attempts.");
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");

            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}
