using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        List<string> wrd = new List<string>(); 
        string phrase = "The quick brown fox jumps over the lazy dog.";
        string[] words = phrase.Split(' ');

        foreach (var word in words)
        {
            wrd.Add(word);
            Console.WriteLine(word);
        }
        Console.WriteLine(string.Join(' ', wrd));

        Console.Write("Choose an option:");
        string option = Console.ReadLine();
        int num = int.Parse(option);

        int hiddenCount = 0;

        while (hiddenCount < 3)
        {
            var randomIndex = random.Next(wrd.Count);
            var wor = wrd[randomIndex];
            Console.WriteLine(randomIndex);
            Console.WriteLine(wor);
        }   
    }
}