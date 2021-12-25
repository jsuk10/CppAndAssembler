using System;
using System.Threading;

class Program
{
    public static void F1()
    {
        Console.WriteLine($"Foo Start");
        Thread.Sleep(3000);
        Console.WriteLine($"Foo end");
    }

    static void Main()
    {
        Task t = Task.Run(F1);
        // Task t = Task.Run(()=> F1("hello"));
        // Task<int> t = Task.Run(() => F1("hello"));  //��ȯ���� �ִ� Task
        // Console.WriteLine($"{t.Result}");           //��ȯ��
        // �ٵ� ������ T�� �ȳ��� ��찡 ���� �� ���� �ʳ�?
        // Result�� ������, ���� ������ �ȴ�.


        Console.WriteLine($"{t.IsCompleted}");      //false
        t.Wait();
        Console.WriteLine($"{t.IsCompleted}");      //true
    }
}