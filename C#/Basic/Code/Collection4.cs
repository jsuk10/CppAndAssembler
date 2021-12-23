using System;
using System.Collections.Generic;
class Program
{

    public static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        List<int> c1 = new List<int>(array);

        foreach (int n in c1)
        {
            Console.WriteLine(n);
        }

        for (IEnumerable<int> p = c1.GetEnumerator(); p.MoveNext();)
        {
            int n = p.Current;
            Console.WriteLine(n);
        }

    }
}