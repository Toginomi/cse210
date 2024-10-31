public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public override void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now != futureTime)
        {
            Console.Write("\n\nBreathe in... ");
            ShowCountDown(4);

            if (DateTime.Now >= futureTime)
            {
                break;
            }

            Console.Write("Now breathe out... ");
            ShowCountDown(6);

            if (DateTime.Now >= futureTime)
            {
                break;
            }
        }

        DisplayEndingMessage();
    }
}