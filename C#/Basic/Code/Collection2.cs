using System;
using System.Collections.Generic;
class Program
{

    public static void Main()
    {
        List<int> c1 = new List<int>();

        for (int i = 0; i < c1.Count; i++)
        {
            Console.WriteLine(c1[i]);
        }

        LinkedList<int> c2 = new LinkedList<int>();

        for (int i = 0; i < c2.Count; i++)
        {
            Console.WriteLine(c2[i]);   //error Inexer 제공하지 않음.
        }

    }
}