using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    public static Task<int> SumAsync(int first, int last)
    {
        return Task.Run(() =>
        {
            int s = 0;
            for (int i = first; i <= last; i++)
            {
                s += i;
                Thread.Sleep(10);
            }
            return s;
        });
    }


    public static async void UpdateResult() //awit를 사용하기 위해 async사용
    {
        Console.WriteLine("UpdateResult");

        int ret = await SumAsync(1, 200); // await를 통해 비동기 함수를 동기 함수 처럼 사용

        Console.WriteLine($"{ret}");
    }

    public static void Main()
    {
        UpdateResult();

        Console.WriteLine("Main : Run Event Loop");
        Console.ReadLine();
    }
}