using System;
using System.IO;

class Program
{
    public static void Main()
    {
        bool b1 = File.Exists("c:\\windows\\System32\\calc.exe");
        DateTime tm = File.GetCreationTime("c:\\windows\\System32\\calc.exe");

        Console.WriteLine(b1);
        Console.WriteLine(tm);

        File.Copy("c:\\windows\\System32\\calc.exe", "d:\\a.exe");
        File.Delete("d:\\a.exe");

        FileInfo fi = new FileInfo("c:\\windows\\System32\\calc.exe");

        bool b2 = fi.Exists;
        DateTime tm2 = fi.CreationTime;

        fi.CopyTo("d:\\a.exe");


    }
}