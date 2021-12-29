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

    public static void Main()
    {
        Task<int> t = Task.Run(() => Sum(1000));

        //아래 두줄은 주 스레드를 Block된다.
        t.Wait();
        int n = t.Result;
    }
}
