using System;
using System.Threading;

class Program
{
    public static void Foo1() { Console.Write("1"); }
    public static void Foo2(object? obj) { Console.Write($"foo2 : {obj.ToString()}"); }
    public static void Foo3(object obj) { Console.Write($"foo3 : {obj.ToString()}"); }
    public static void Foo4(string msg) { Console.Write(msg); }
    public static void Foo5(int a, int b) { Console.Write($"{a}, {b}"); }
    public static void Main()
    {
        Thread t1 = new Thread(Foo1); t1.Start();
        Thread t2 = new Thread(Foo2); t2.Start("Hello");
        Thread t3 = new Thread(Foo3); t3.Start("Hello");

        // Thread t4 = new Thread(Foo4); t1.Start("Hello");    //error
        Thread t4 = new Thread(() => Foo4("Hello")); t4.Start();
        Thread t5 = new Thread((arg) => Foo4((string)arg));
        t5.Start("Hello");
        Thread t6 = new Thread(() => Foo5(1, 2));
        
        t6.Start("Hello");

    }
}