using System;
using System.Threading;

class Program
{
    private static void Foo(object arg)
    {
        Console.WriteLine($"Foo : {arg}, {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(1000);
    }

    public static void Main()
    {
        // Thread t = new Thread(Foo);
        // t.Start("Hello");

        ThreadPool.QueueUserWorkItem(Foo, "Hello"); //Thread Pool에 넣음
        // ThreadPool.QueueUserWorkItem(Foo);          //arg = null

        Console.ReadLine();
    }
}