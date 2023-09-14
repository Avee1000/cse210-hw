using System;

class Program
{
    static void Main(string[] args)
    {

        // Generate random number
        Random rand = new Random();
        int magicNum = rand.Next(1, 100);

        int conv = -1;

        while (!(conv == magicNum))
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            conv = int.Parse(guess);

            if (magicNum > conv)
            {
                Console.WriteLine("Higher");
            }

            else if (magicNum < conv)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("Correct.");
            }
        }
    }
}