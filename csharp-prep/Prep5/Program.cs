using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquaredNumber(number);
        DisplayResult(name, squared);
    
    }

    static void DisplayWelcome ()
    {
        Console.WriteLine("Welcome to the program");
    }

    static string PromptUserName ()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber ()
    {
        Console.Write("Please enter your favourite number: ");
        string userNumber = Console.ReadLine();
        int conv = int.Parse(userNumber);
        return conv;
    }

    static int SquaredNumber (int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult (string name, int square)
    {
        Console.WriteLine($"Brother/Sister {name}, the square of your favourite number is: {square}");
    }
}