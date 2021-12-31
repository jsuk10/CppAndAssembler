using System;

class Program
{
    static void Main()
    {
        Index idx = ^3;         //값 3, 뒤에서 부터

        int n = idx.Value;          //값을 보관하는 Getter
        bool b = idx.IsFromEnd;     //방향을 보관하는 Getter

        Console.WriteLine($"{n}, {b}");
    }
}