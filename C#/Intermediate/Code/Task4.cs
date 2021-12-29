using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void F1()
    {
        Console.WriteLine(Thread.CurrentThread.IsThreadPoolThread);
        Console.WriteLine(Thread.CurrentThread.IsBackground);
    }

    public static void Maind()
    {
        // Task t1 = new Task(F1);
        Task t1 = new Task(F1, TaskCreationOptions.LongRunning);    //해당 옵션을 주게 되면 pooling하지 않고 새로 만들어 쓴다.

        t1.Start();

        Task t2 = Task.Run(F1);
    }
}
