using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static int Sum(int cnt)
    {
        int s = 0;
        for (int i = 0; i <= cnt; i++)
            s += i;
        return s;
    }

    public static void Foo(Task<int> t)
    {
        Console.WriteLine(t.Result);
    }

    public static void Main()
    {
        Task<int> t = Task.Run(() => Sum(1000));

        t.ContinueWith(Foo, TaskContinuationOptions.ExecuteSynchronously);   //이전 테스크와 같은 스레드에서 실행하는 함수

        Console.ReadLine();
    }
}
