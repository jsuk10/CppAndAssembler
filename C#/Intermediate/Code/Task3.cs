using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void F1() { Console.WriteLine("F1"); }
    static void F2(object obj) { Console.WriteLine("F2"); }
    static int F3(object obj) { Console.WriteLine("F3"); return 200; }

    public static void Maind()
    {
        Task t1 = new Task(F1); t1.Start();

        Task t2 = new Task(F2, "Hi"); t2.Start();

        Task<int> t3 = new Task<int>(F3, "hi"); t3.Start();

        Task t4 = Task.Run(F1);
        Task t5 = Task.Run(() => F2("hi"));
        Task<int> t6 = Task.Run(() => F3("hi"));
    }

}
