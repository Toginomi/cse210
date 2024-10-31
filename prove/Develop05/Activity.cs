public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()

    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"{_description}\n");

        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.Write("Get ready... ");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        Console.Write($"\nYou have completed another {_duration} seconds of the {_name}. ");
        ShowSpinner(5);
        Console.Clear();
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");

            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("—");

            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");

            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("|");

            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public virtual void Run()
    {

    }
}