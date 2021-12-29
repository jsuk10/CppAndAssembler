using System;

class Program
{
    static void Main()
    {
        string s1 = "ABCDEFGHIJ";

        char c = s1[2];             //C

        string s2 = s1[2..7];       //Range(C# 8.0) 표기법 CDEFG
        string s3 = s1[2..^3];      //CDEFG

        Console.WriteLine($"{c} {s2}, {s3}");
    }
}