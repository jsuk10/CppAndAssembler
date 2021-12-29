using System;
using System.Threading;

class Program
{
    public static void Foo1(int n) { Console.Write($"{n} "); }
    public static void Main()
    {
        for (int i = 0; i < 20; i++)
        {
            // Thread t1 = new Thread(() => { Foo1(i); });
            // t1.Start();

            int temp = i;
            Thread t1 = new Thread(() => { Foo1(temp); });
            t1.Start();

        }
    }
}
