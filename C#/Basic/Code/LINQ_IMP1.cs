using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };

        IEnumerable<int> e = arr.Select(n => n * 10);

        arr[0] = 0;

        foreach (int n in e)
            Console.WriteLine(n);
    }
}