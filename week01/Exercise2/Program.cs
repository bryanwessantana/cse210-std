using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string number = Console.ReadLine();
        int grade = int.Parse(number);

        string letter = "";
        string symbol = "";

        //Message saying what is the User Grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >=80)
        {
            letter = "B"; 
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // STRETCH CHALLENGES 1 - 3

        if (grade%10 >= 7)
        {
            symbol = "+";
        }
        else if (grade%10 < 3)
        {
            symbol = "-";
        }
        else
        {
            symbol = " ";
        }

        if (grade >= 93)
        {
            symbol = " ";
        }
        else if (grade <60)
        {
            symbol = " ";
        }

        Console.WriteLine($"Your grade is {letter}{symbol}.");

        // Message saying if he passed the class
        if (grade >= 70)
        {
            Console.WriteLine("Congrats! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't passed the class. Better luck next time.");
        }
    }
}