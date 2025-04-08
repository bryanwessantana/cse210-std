using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        Console.WriteLine("Welcome to Magic Number Game!");
        Console.WriteLine("Guess a number from 1 to 100...");
        int magicNumber = randomGenerator.Next(1, 100);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You did it!");
            }

            // STRETCH CHALLENGES 1 - 3 = SEE WORDLE GAME.PY (W7 & w8)
        }
    }
}