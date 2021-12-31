using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int n1 = arr[2];    // 3
        int n2 = arr[^2];   // 9

        Console.WriteLine($"{n1}, {n2}");
    }
}