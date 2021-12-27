using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };

        foreach (int n in arr)
        {
            if (n % 3 == 0)
                Console.WriteLine(n);
        }

        Console.WriteLine("---");

        IEnumerable<int> e = arr.Where(n => n % 3 == 0);

        foreach (int n in e)
        {
            Console.WriteLine(n);
        }
    }
}