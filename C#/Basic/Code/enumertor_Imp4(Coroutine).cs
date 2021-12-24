using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    //Subroutine -  일반적 함수
    public static int Foo()
    {
        Console.WriteLine("1"); return 10;
        //일반적으로 이 아래는 실행이 안됨.
        Console.WriteLine("2"); return 20;
        Console.WriteLine("3"); return 30;
        Console.WriteLine("4"); return 40;
        Console.WriteLine("5"); return 50;
    }

    //Coroutine - 열거자 인터페이스로 반환
    public static IEnumerator<int> Goo()
    {
        Console.WriteLine("1"); yield return 10;
        Console.WriteLine("2"); yield return 20;
        Console.WriteLine("3"); yield return 30;
        Console.WriteLine("4"); yield return 40;
        Console.WriteLine("5"); yield return 50;
    }

    //Coroutine - 컬렉션 인터페이스로 반환
    public static IEnumerable<int> Hoo()
    {
        Console.WriteLine("1"); yield return 10;
        Console.WriteLine("2"); yield return 20;
        Console.WriteLine("3"); yield return 30;
        Console.WriteLine("4"); yield return 40;
        Console.WriteLine("5"); yield return 50;
    }

    public static void Main()
    {
        int n1 = Foo();
        IEnumerator<int> e = Goo();
        IEnumerable<int> c = Hoo();
        IEnumerator<int> e2 = c.GetEnumerator();
        e.MoveNext();
        e2.MoveNext();
        Console.WriteLine($"SubRoutine {n1}, Coroutine Enumerator : {e.Current}, Collection : {e2.Current}");
        e.MoveNext();
        e2.MoveNext();
        Console.WriteLine($"SubRoutine {n1}, Coroutine Enumerator : {e.Current}, Collection : {e2.Current}");
        e.MoveNext();
        e2.MoveNext();
        Console.WriteLine($"SubRoutine {n1}, Coroutine Enumerator : {e.Current}, Collection : {e2.Current}");
    }
}