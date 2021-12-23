using System;
using System.Net;

class Server
{
    public void Connect()
    {
        throw new TimeoutException();
    }
}

class Program
{
    static void Foo()
    {
        Server wc = new Server();
        try
        {
            wc.Connect();
        }
        catch (Exception e) when (Logging(e))
        {
            Console.WriteLine("Foo");
        }
    }
    static bool Logging(Exception e)
    {
        Console.WriteLine($"Log : {e.Message}");
        return false;
    }

    static void Main()
    {
        try
        {
            Foo();
        }
        catch (Exception e)
        {
            Console.WriteLine("예외");
        }
    }
}