using System;
using System.IO;

class Program
{
    public static void Foo()
    {
        FileStream fs1 = new FileStream("a.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);

        fs1.Dispose();
    }
    static void Main()
    {
        Foo();
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("Main");

        FileStream fs2 = new FileStream("a.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);

    }
}