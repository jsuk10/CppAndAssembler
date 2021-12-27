using System;
using System.Linq;
using System.Collections.Generic;

public static class MyLinq
{
    // 확장 메서드 문법(Extension method)문법,Delegate(Func)와 람다 표현식
    public static IEnumerable<int> MySelect(this Array arr, Func<int, int> predicateMethed)
    {
        foreach (int n in arr)
        {
            Console.WriteLine("Select");
            yield return predicateMethed(n);        //Coroutine 의 개념
        }
    }
}


class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };

        IEnumerable<int> e = arr.MySelect(n => n * 10);

        arr[0] = 0;

        Console.WriteLine("1");

        // foreach (int n in e)
        //     Console.WriteLine(n);

        //위의 foreach와 동일
        IEnumerator<int> p = e.GetEnumerator();

        while (p.MoveNext())
        {
            Console.WriteLine("2");
            Console.WriteLine(p.Current);
        }

    }
}