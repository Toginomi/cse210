using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());

        char letter;
        string sign = "";

        if (grade >= 90)
        {
            letter = 'A';
        }
        else if (grade >= 80 && grade < 90)
        {
            letter = 'B';
        }
        else if (grade >= 70 && grade < 80)
        {
            letter = 'C';
        }
        else if (grade >= 60 && grade < 70)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }

        if (grade % 10 >= 7 && letter != 'A' && letter != 'F')
        {
            sign = "+";
        }
        else if (grade % 10 < 3 && letter != 'F')
        {
            sign = "-";
        }

        Console.WriteLine($"\nYour letter grade is {letter}{sign}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry for not passing the class. I am still rooting for you next time!");
        }
    }
}