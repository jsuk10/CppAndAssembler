using System;

class Program
{
    static void Main()
    {
        //ref Type
        int[] a1 = { 1, 2, 3 };
        object o1 = a1;
        a1[0] = 10;

        int[] a2 = (int[])o1;
        Console.WriteLine(a2[0]);           // 10

        //value Type
        int n1 = 1;
        object o2 = n1;
        n1 = 10;

        int n2 = (int)o2;
        Console.WriteLine($"{n1}, {n2}");   // 10, 1
    }
}
