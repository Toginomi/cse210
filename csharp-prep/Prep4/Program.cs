using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int newNumber;
        float sum = 0;
        float largest = 0;
        float smallestPositiveNumber = float.PositiveInfinity;
        List<float> numbers = new List<float>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            newNumber = int.Parse(Console.ReadLine());
            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
        } while (newNumber != 0);

        foreach (float number in numbers)
        {
            sum += number;

            if (number > largest)
            {
                largest = number;
            }

            if (number > 0 && number < smallestPositiveNumber)
            {
                smallestPositiveNumber = number;
            }

        }

        Console.WriteLine($"The sum is: {sum}");
        float average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");

        List<float> sortedNumbers = new List<float>(numbers);
        sortedNumbers.Sort();

        foreach (float number in sortedNumbers)
        {
            Console.WriteLine(number);
        }
    }
}