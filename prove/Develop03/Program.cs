// Added prompt for number of words to be removed each time, for creativity.

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, text);


        Console.WriteLine("Welcome to Scripture Memorizer!\n");
        Console.WriteLine(scripture.GetDisplayText());
        Console.Write("\nHow many words do you want to remove each time? ");
        int wordsToRemove = int.Parse(Console.ReadLine());

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.Write("\nPress the ENTER key to hide words, or type 'quit' to exit. ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(wordsToRemove);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine("All words are hidden.");
                break;
            }
        }
    }
}