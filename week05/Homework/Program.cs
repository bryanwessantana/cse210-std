using System;

class Program
{
    static void Main(string[] args)
    {
        //
        Console.WriteLine("Welcome to your Homework Math Program!\n");

        // 
        Assignment a1 = new Assignment("Bryan Santana", "Divison");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine("");

        // 
        MathAssignment a2 = new MathAssignment("Jacob Smith", "Addiction", "5.2", "3-14");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeWorkList());
        Console.WriteLine("");

        //
        WritingAssignment a3 = new WritingAssignment("Luke Newman", "European History", "The causes of World War II,");
        Console.WriteLine(a3.GetSummary());        
        Console.WriteLine(a3.GetWritingInformation());
        Console.WriteLine("");
    }
}