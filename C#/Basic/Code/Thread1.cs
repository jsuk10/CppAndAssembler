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
        //Foo();          //주 스레드가 호출

        Thread t = new Thread(Program.Foo);     //새로운 스레드를 만들어 준다
        t.Start();                              //새로운 스레드에 작업 할당

        Console.WriteLine("Main Start");
        Thread.Sleep(2000);
        Console.WriteLine("Main End");
    }
}