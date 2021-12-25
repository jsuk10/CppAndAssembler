using System;
using System.IO;

class Program
{
    static void Main()
    {
        int[] arr = new int[5] { 1, 2, 3, 4, 5 };

        FileStream fs = new FileStream("a.txt",
                                        FileMode.CreateNew,
                                        FileAccess.ReadWrite,
                                        FileShare.None);
        //.
        fs.Dispose();
    }
}