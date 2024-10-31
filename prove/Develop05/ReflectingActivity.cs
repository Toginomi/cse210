public class ReflectingActivity : Activity
{
    private readonly string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private readonly string[] _questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {

    }

    public override void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Length)];
        Console.WriteLine($"\n\nConsider the following prompt: \n --- {prompt} ---\n");
        Console.Write("When you have something in mind, press enter to continue. ");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.\n");
        Console.Write("You may begin in: ");
        ShowCountDown(9);

        Console.Clear();


        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now != futureTime)
        {
            if (DateTime.Now >= futureTime)
            {
                break;
            }

            string question = _questions[random.Next(_questions.Length)];
            Console.Write($"\n > {question} ");

            ShowSpinner(15);
        }

        DisplayEndingMessage();
    }
}