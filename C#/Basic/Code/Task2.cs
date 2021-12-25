using System;
using System.Threading;

class Program
{
    public static void F1()
    {
        Console.WriteLine($"Foo Start");
        Thread.Sleep(3000);
        Console.WriteLine($"Foo end");
    }

    static void Main()
    {
        Task t = Task.Run(F1);
        // Task t = Task.Run(()=> F1("hello"));
        // Task<int> t = Task.Run(() => F1("hello"));  //반환값이 있는 Task
        // Console.WriteLine($"{t.Result}");           //반환값
        // 근데 문제는 T가 안끝날 경우가 있을 수 있지 않냐?
        // Result로 꺼낼때, 동기 식으로 된다.


        Console.WriteLine($"{t.IsCompleted}");      //false
        t.Wait();
        Console.WriteLine($"{t.IsCompleted}");      //true
    }
}