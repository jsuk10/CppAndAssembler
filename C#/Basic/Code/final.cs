using System;

class Program
{
    static void Main()
    {
        try
        {
            throw new Exception();      // finally 실행
            return;                     // finally 실행
        }
        finally
        {
            Console.WriteLine("finally");
        }

    }

}