using System;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

class Program
{
    static int Sum(int cnt)
    {
        return 100;
    }

    public static void Main()
    {
        Task<int> t = Task.Run(() => Sum(1000));

        t.ContinueWith(task => Console.WriteLine($"{task.Result}"));

        TaskAwaiter<int> awaiter = t.GetAwaiter();
        awaiter.OnCompleted(() => Console.WriteLine($"{awaiter.GetResult()}"));

        Console.ReadLine();
    }
}
