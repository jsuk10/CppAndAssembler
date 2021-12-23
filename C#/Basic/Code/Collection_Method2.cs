using System;
using System.Collections.Generic;

class MyCompare : IComparer<int>
{
    public int Compare(int x, int y)
    {
        return x < y ? 1 : -1;
    }
}

class Program
{
    public static bool Divide3(int n) { return n % 3 == 0; }
    public static void Main()
    {
        List<int> c1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //기본 구현 (오름차순 정리)
        //c1.Sort(); 


        //델리게이트 (메서드 전달)
        c1.Sort((a, b) => { return a < b ? 1 : -1; });

        // 인터페이스 (비교정책을 담은 객체 전달)
        // c1.Sort(IComparable<TimeoutException>) == Interface
        // c1.Sort( IComparable을 상속 받은 객체 )

        c1.Sort(new MyCompare());

        foreach (var n in c1)
            Console.WriteLine(n);
    }
}