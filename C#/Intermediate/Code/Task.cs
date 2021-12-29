using System;
using System.Threading;

class Program
{
    public static void Foo(object arg)
    {
        Console.WriteLine("Foo");
    }

    public static void Maind()
    {
        Thread t1 = new Thread(Foo);
        t1.Start("Hello");
        t1.Join();

        ThreadPool.QueueUserWorkItem(Foo, "Hello");
    }

}
