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
            // ������ ������ ���� ����
            Thread t1 = new Thread(F1);
            t1.Start();

            //Ǯ�� ���� ��Ȳ�� �°� ��������.
            //Task t = Task.Run(F1);
        }

        Console.ReadKey();
    }
}