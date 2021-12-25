using System;
using System.Threading;

class Program
{
    public static void F1()
    {
        //자신의 스레드참조를 알 수 있는 방법
        Thread t1 = Thread.CurrentThread;
        Console.WriteLine($"F1 = {t1.ManagedThreadId}");


        Console.WriteLine("F1 Start");
        Thread.Sleep(1000);
        Console.WriteLine("F1 End");
    }
    static void Main()
    {
        Thread t1 = new Thread(F1);
        t1.Start();

        //스레드의 ID를 얻는다.
        Console.WriteLine($"{t1.ManagedThreadId}");
        //스레드의 우선순위를 얻는다
        Console.WriteLine($"{t1.Priority}");
        //스레드가 스레드 풀에서 나온지 조사함
        Console.WriteLine($"{t1.IsThreadPoolThread}");
        //스레드가 현재 살아 있는지 알아보는 함수
        Console.WriteLine($"{t1.IsAlive}");

        // ForeGround 스레드 : 주 스레드가 종료되어도 계속 작업한다.
        // BackGround 스레드 : 주 스레드가 종료되면 강제 종료한다..
        t1.IsBackground = true;

        //현재 스레드가 종료 되어도 이 스레드를 대기 해달라는 코드
        t1.Join();
    }
}