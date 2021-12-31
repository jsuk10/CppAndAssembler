using System;

class Program
{
    static void Main()
    {
        string s = "ABCDEFGHI";

        int idx1 = 2;

        Index idx2 = new Index(2);
        Index idx3 = new Index(2, fromEnd: true);

        char c1 = s[idx1];
        char c2 = s[idx2];
        char c3 = s[idx3];

        Console.WriteLine($"{c1}, {c2}, {c3}"); //c c h
    }
}

