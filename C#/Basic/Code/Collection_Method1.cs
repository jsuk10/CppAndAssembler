using System;
using System.Collections.Generic;

class Program
{
    public static bool Divide3(int n) { return n % 3 == 0; }
    public static void Main()
    {
        List<int> c1 = new List<int>() { 1, 2, 3, 1, 2, 3, 1, 2, 3, 9 };

        //값 검색, 찾는값이 제일 앞에
        Console.WriteLine(c1.IndexOf(3));                   //2     3을 찾은 위치
        Console.WriteLine(c1.IndexOf(3, 5));                //5     5번째 부터 3을 찾는 위치 = 5 
        Console.WriteLine(c1.IndexOf(3, 6, 2));             //-1    6번부터 2개만 찾기 = -1(못찾음)

        //조건 검색, 조건을 뒤로
        Console.WriteLine(c1.FindIndex(Divide3));           //2     3의 배수가 있는 인덱스 (델리게이트)
        Console.WriteLine(c1.FindIndex(n => n % 3 == 0));   //2     3의 배수가 있는 인덱스 (Lambda)

        //조건을 만족하는 모든 요소 찾기
        List<int> ret = c1.FindAll(n => n % 3 == 0);

        foreach (var n in ret)
            Console.WriteLine(n);
    }
}