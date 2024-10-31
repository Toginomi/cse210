// For creativity, when the user finally chooses "4", the program displays how many times each activity was performed in a session.

public class Program
{
    public static void Main()
    {
        int countBreathingActivity = 0;
        int countReflectingActivity = 0;
        int countListingActivity = 0;
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");

            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    new BreathingActivity().Run();
                    countBreathingActivity++;
                    break;
                case 2:
                    new ReflectingActivity().Run();
                    countReflectingActivity++;
                    break;
                case 3:
                    new ListingActivity().Run();
                    countListingActivity++;
                    break;
                case 4:
                    Console.WriteLine("\nThank you!");
                    Console.WriteLine("\nYou have done: ");
                    Console.WriteLine($"Breathing Activity - {countBreathingActivity}");
                    Console.WriteLine($"Reflecting Activity - {countReflectingActivity}");
                    Console.WriteLine($"Listing Activity - {countListingActivity}");
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}