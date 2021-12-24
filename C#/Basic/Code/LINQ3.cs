using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    public static bool IsQdd(int n)
    {
        return n % 2 == 1;
    }
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };

        IEnumerable<int> e = arr.Select(n => n * 10);

        foreach (int n in e)
        {
            Console.WriteLine(n);
        }

    }
}