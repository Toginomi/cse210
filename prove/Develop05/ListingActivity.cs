public class ListingActivity : Activity
{
    private readonly string[] _prompts = {
        "List people you appreciate.",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }

    public override void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Length)];
        Console.WriteLine(prompt);
        Console.WriteLine($"\n\nList as many responses as you can to the following prompt: \n --- {prompt} ---\n");
        Console.Write("You may begin in: ");
        ShowCountDown(9);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        int countAnswers = 0;
        while (DateTime.Now != futureTime)
        {
            if (DateTime.Now >= futureTime)
            {
                break;
            }
            Console.Write(" > ");
            Console.ReadLine();
            countAnswers++;
        }

        Console.WriteLine($"\nYou listed {countAnswers} items!");

        DisplayEndingMessage();
    }
}