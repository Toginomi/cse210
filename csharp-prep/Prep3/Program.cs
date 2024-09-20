using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        int guess;
        
        do
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);

            int numberOfGuesses = 0;

            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                numberOfGuesses += 1;

                if (number > guess)
                {
                    Console.Write("Higher\n");
                }
                else if (number < guess)
                {
                    Console.Write("Lower\n");
                }
                else
                {
                    Console.Write("You guessed it!\n");
                    Console.WriteLine($"Number of guesses: {numberOfGuesses}\n");
                }
            } while (number != guess);

            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine();
        } while (playAgain == "yes");
    }
}