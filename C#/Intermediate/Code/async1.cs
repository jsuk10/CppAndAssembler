using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    public static int Sum(int first, int last)
    {
        int s = 0;
        for (int i = first; i <= last; i++)
        {
            s += i;
            Thread.Sleep(10);
        }
        return s;
    }

    public static Task<int> SumAsync(int first, int last)
    {
        Task<int> t = Task.Run(() =>
        {
            int s = 0;
            for (int i = first; i <= last; i++)
            {
                s += i;
                Thread.Sleep(10);
            }
            return s;
        });
        return t;
    }

    public static void Main()
    {
        int ret = Sum(1, 200);                           // 주 스레드 Blocking, 동기 함수
        Task<int> t = Task.Run(() => Sum(1, 200));          // 비동기 방법 1

        Task<int> retT = SumAsync(1, 200);
        Console.WriteLine("Main");

        Console.WriteLine($"{t.Result}");

        Console.WriteLine($"{retT.Result}");


        // Console.WriteLine("Main");
    }

}