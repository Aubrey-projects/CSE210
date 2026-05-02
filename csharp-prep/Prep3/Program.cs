using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string magicNumberString = Console.ReadLine();
        // int magicNumber = int.Parse(magicNumberString);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess;
        int guessCounter = 0;

        do {
            Console.Write("What is your guess? ");
            string guessString = Console.ReadLine();
            guess = int.Parse(guessString);
            guessCounter++;

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
                Console.WriteLine("You guessed it!");
            }
        } while (guess != magicNumber);

        Console.WriteLine($"It took you {guessCounter} guesses to win.");
    }
}