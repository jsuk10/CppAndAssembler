using System;
using System.Threading;

class Program
{

    public static void Count(CancellationToken token, int cnt)
    {
        for (int i = 0; i < cnt; i++)
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Cancle");
                break;
            }
            Console.WriteLine(i);
            Thread.Sleep(200);
        }
        if (token.IsCancellationRequested)
            Console.WriteLine("Cancled!!");
        else
            Console.WriteLine("Finish Count");
    }
    public static void Main()
    {
        CancellationTokenSource cts = new CancellationTokenSource();

        CancellationTokenRegistration m1 = cts.Token.Register(() => { Console.WriteLine("cancelled 1"); });
        cts.Token.Register(() => { Console.WriteLine("cancelled 2"); });

        m1.Dispose();   //등록된 함수 제거하기.
                        //1은 불리지 않음.

        Thread t = new Thread(o => Count(cts.Token, 1000));
        t.Start();

        Console.ReadLine();
        cts.Cancel();
    }
}