using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(10 < 20); // true

        Console.WriteLine(10.CompareTo(20)); // -1
        Console.WriteLine(10.CompareTo(10)); // 0
        Console.WriteLine(10.CompareTo(5));  // 1

        //Console.WriteLine("AAA" < "BBB"); // error
        Console.WriteLine("AAA".CompareTo("BBB")); // -1


    }
}
