using System;

class Program
{
    public static void Main()
    {
        dynamic d = 10;

        int a = d;         //ok
        long b = d;         //ok
        string s = d;       //예외 발생
    }
}
