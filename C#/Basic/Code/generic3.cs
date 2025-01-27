﻿using System;

class Program
{
    public static int Max(int a, int b)
    {
        return a < b ? b : a;       //구현부가 다르므로 CompareTo로 바꾼 뒤에 제네릭으로 변환
    }
    public static string Max(string a, string b)
    {
        return a.CompareTo(b) < 0 ? b : a;
    }

    static void Main()
    {
        Console.WriteLine(Max(10, 20));
        Console.WriteLine(Max("A", "B"));
        //Console.WriteLine(Max(1.2, 2.1));
    }
}
