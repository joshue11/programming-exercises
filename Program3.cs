using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int magicNumber = random.Next(1, 101);
        int guess = -1;
        int attempts = 0;

        Console.WriteLine("Guess My Number Game!");
        
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            attempts++;

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You guessed it! It took you {attempts} tries.");
            }
        }

        Console.WriteLine("Thanks for playing!");
    }
}
