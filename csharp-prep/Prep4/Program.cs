using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        //codes of line 10 - 31 for adding the sum of numbers in a List
        int response = -1;

        while (!(response == 0))
        {
            Console.Write("Enter a number: ");
            string num = Console.ReadLine();
            response = int.Parse(num);
             
        // int.TryParse(response, out int number); (Alternate form to convert)


            if (response != 0)
            {
                numbers.Add(response);
            }
        }    

        int total = 0;

        //{ALTERNATIVE - BELOW ⬇⬇⬇⬇⬇}
        // foreach (int number in numbers)
        // {
        //     total += number;
        // }

        foreach (int number in numbers)
        {
            total = total + number;
        }
        Console.WriteLine($"The sum is: {total}");


        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The Average is: {average}");


        // Find the max number
        int highest = -1; // or (int highest = numbers[0];)
        int lowest = 999999; //or (lowest = numbers[0];)
        foreach (int number in numbers)
        {
            if (number > highest)
            {
                highest = number;
            }

            if (number < lowest)
            {
                lowest = number;
            }
        }
        Console.WriteLine($"The highest number is: {highest}");
        Console.WriteLine($"The lowest number is: {lowest}");

    }

}