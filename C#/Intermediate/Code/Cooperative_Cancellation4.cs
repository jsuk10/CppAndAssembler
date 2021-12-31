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
        cts.Token.Register(() => { Console.WriteLine("cancelled 1"); });
        CancellationTokenSource cts2 = new CancellationTokenSource();
        cts2.Token.Register(() => { Console.WriteLine("cancelled 2"); });

        CancellationTokenSource totalcts = CancellationTokenSource.CreateLinkedTokenSource(cts.Token, cts2.Token);


        Thread t = new Thread(o => Count(totalcts.Token, 1000));
        t.Start();

        Console.ReadLine();
        cts.Cancel();
    }
}