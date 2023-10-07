using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> animatedStrings = new List<string>();
        animatedStrings.Add("|");
        animatedStrings.Add("/");
        animatedStrings.Add("_");
        animatedStrings.Add("\\");
        animatedStrings.Add("|");
        animatedStrings.Add("/");
        animatedStrings.Add("_");
        animatedStrings.Add("\\");

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(20);
        do
        {
            DateTime CurrentTime = DateTime.Now;
            foreach (string i in animatedStrings)
            {
                if (CurrentTime < end)
                {
                    Console.Write(i);
                    Thread.Sleep(500);
                    Console.Write("\b \b");
                }
            }
        } while (DateTime.Now < end);        
    }
}