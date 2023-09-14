using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int conv = int.Parse(grade);

        string letter = "";

        if (conv >= 90)
        {
            letter = "A";
        }

        else if (conv >= 80)
        {
            letter = "B";
        }

        else if (conv >= 70)
        {
            letter = "C";
        }

        else if (conv >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (conv >= 70)
        {
            Console.WriteLine("Congratulations. You passed.");
        }

        else 
        {
            Console.WriteLine("There is always another chance.");
        }
    }
}