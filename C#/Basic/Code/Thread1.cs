using System;
using System.Threading;

class Program
{
    public static void Foo()
    {
        Console.WriteLine("Foo Start");
        Thread.Sleep(2000);
        Console.WriteLine("Foo End");
    }
    static void Main()
    {
        //Foo();          //�� �����尡 ȣ��

        Thread t = new Thread(Program.Foo);     //���ο� �����带 ����� �ش�
        t.Start();                              //���ο� �����忡 �۾� �Ҵ�

        Console.WriteLine("Main Start");
        Thread.Sleep(2000);
        Console.WriteLine("Main End");
    }
}