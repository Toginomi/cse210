// For showing creativity and exceeding requirements, I added "Statistics" option to help the user count the number of journal entries they have in a given file.

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        String fileName;

        while (true)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Statistics");
            Console.WriteLine("0. Exit");
            Console.Write("What would you like to do? ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Entry newEntry = new Entry();

                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToShortDateString();
                    newEntry._date = dateText;

                    newEntry._promptText = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(newEntry._promptText);

                    Console.Write("> ");
                    newEntry._entryText = Console.ReadLine();

                    journal.AddEntry(newEntry);
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("What is the file name? ");
                    fileName = Console.ReadLine();
                    journal.SaveToFile(fileName);
                    break;

                case "4":
                    Console.Write("What is the file name? ");
                    fileName = Console.ReadLine();

                    if (File.Exists(fileName))
                    {
                        journal.LoadFromFile(fileName);
                    }
                    else
                    {
                        Console.WriteLine($"{fileName} is not found.");
                    }
                    break;

                case "5":
                    journal.DisplayStatistics();
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}