using System;

class Program
{
    static void Main(string[] args)
    {
        double a = 1.0;
        decimal b = 2.1m;
        Console.WriteLine(a + (double)b);
        Console.WriteLine((decimal)a + b);
    }
}