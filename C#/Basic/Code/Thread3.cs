using System;
using System.Threading;

class Program
{
    public static void F1()
    {
        //�ڽ��� ������������ �� �� �ִ� ���
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

        //�������� ID�� ��´�.
        Console.WriteLine($"{t1.ManagedThreadId}");
        //�������� �켱������ ��´�
        Console.WriteLine($"{t1.Priority}");
        //�����尡 ������ Ǯ���� ������ ������
        Console.WriteLine($"{t1.IsThreadPoolThread}");
        //�����尡 ���� ��� �ִ��� �˾ƺ��� �Լ�
        Console.WriteLine($"{t1.IsAlive}");

        // ForeGround ������ : �� �����尡 ����Ǿ ��� �۾��Ѵ�.
        // BackGround ������ : �� �����尡 ����Ǹ� ���� �����Ѵ�..
        t1.IsBackground = true;

        //���� �����尡 ���� �Ǿ �� �����带 ��� �ش޶�� �ڵ�
        t1.Join();
    }
}