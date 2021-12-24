using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        foreach (int n in arr)
            Console.WriteLine(n);


        Console.WriteLine("----");
        IEnumerable<int> col = arr;

        foreach (int n in col)
            Console.WriteLine(n);
    }
}