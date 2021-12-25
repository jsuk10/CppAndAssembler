using System;
using System.Threading;

class Program
{
    public static void F1()
    {
        Console.WriteLine($"Foo {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(3000);
    }

    static void Main()
    {
        for (int i = 0; i < 20; i++)
        {
            // 무조건 스레드 만들어서 실행
            Thread t1 = new Thread(F1);
            t1.Start();

            //풀을 통해 상황에 맞게 실행해줌.
            //Task t = Task.Run(F1);
        }

        Console.ReadKey();
    }
}