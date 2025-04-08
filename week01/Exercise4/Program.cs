using System; 
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbersList = new List<int>();

        int numberInput = -1;
        while (numberInput != 0)
        {
            Console.Write("Enter a number (type 0 to quit): ");

            string userAnswer = Console.ReadLine();
            numberInput = int.Parse(userAnswer);

            if (numberInput != 0)
            {
                numbersList.Add(numberInput);
            }
        }

        // Sum
        int sum = 0;
        foreach (int number in numbersList)
        {
            sum += number;
        }
        Console.WriteLine($"Sum is: {sum}");

        // Average
        float average = ((float)sum)/numbersList.Count;
        Console.WriteLine($"Average is: {average}");

        // Max
        int max = numbersList[0];

        foreach (int number in numbersList)
        {
            if (number > max)
            {
                max = numberInput;
            }
        }
        
        Console.WriteLine($"Max is: {max}");
    }
}