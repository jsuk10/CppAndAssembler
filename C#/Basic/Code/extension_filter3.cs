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
        int retryCount = 0;
        bool bSuccess = false;
        Server wc = new Server();
        while (bSuccess == false)
        {
            try
            {
                wc.Connect();
                bSuccess = true;
            }
            // catch (Exception e) when (++retryCount < 4)
            // {
            //     //if (++retryCount < 4) 
            //     Console.WriteLine("One More Try");
            //     //else
            //     //    throw
            // }
            //아래와 같으나 catch를 들어가서 성능 저하가 있음
            catch (Exception e) when (++retryCount < 4)
            {
                Console.WriteLine("One More Try");
            }
        }
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