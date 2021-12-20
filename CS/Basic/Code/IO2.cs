using System;
using static System.Console;

class Programs
{
    static void Main(string[] args)
    {
        int n = 10;
        double d = 3.4;

        Console.WriteLine(n);
        Console.WriteLine("n = {0} d = {1} n = {0}", n, d);
        Console.WriteLine($"n = {n} d = {d}");
        Console.WriteLine("C:\\AAA\\BBB\\a.text");
        Console.WriteLine(@"C:\\AAA\\BBB\\a.text");
    }
}
