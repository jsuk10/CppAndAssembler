using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void F1() { Console.WriteLine("F1"); }
    static void F2(object obj) { Console.WriteLine("F2"); }
    static int F3() { Console.WriteLine("F3"); return 100; }
    static int F4(object obj) { Console.WriteLine("F4"); Thread.Sleep(3000); return 200; }

    public static void Maind()
    {
        Task t1 = new Task(F1);
        t1.Start();

        Task t2 = new Task(F2, "Hi");
        t2.Start();

        Task<int> t3 = new Task<int>(F3);
        t3.Start();


        Task<int> t4 = new Task<int>(F4, "Hello");
        t4.Start();

        t4.Wait();      //join()과 동일

        Console.WriteLine($"{t4.Result}");
    }

}
