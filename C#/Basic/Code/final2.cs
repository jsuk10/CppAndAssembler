using System;
using System.IO;

class Program
{
    static void Main()
    {
        FileStream fs = null;

        try
        {
            fs = new FileStream("a.txt", FileMode.CreateNew);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            fs.Dispose();
        }

    }

}