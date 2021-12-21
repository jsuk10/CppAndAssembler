using System;

class Program
{
    public static void inc1(int n)          // Call By Value
    {
        ++n;
    }
    public static void inc2(ref int n)      // Call By Ref
    {
        ++n;
    }

    public static void Main()
    {
        int n1 = 10;
        inc1(n1);
        Console.WriteLine(n1);          // 10 (Call By Value)

        int n2 = 10;
        inc2(ref n2);
        Console.WriteLine(n2);          // 11 (Call By Ref)
    }
}