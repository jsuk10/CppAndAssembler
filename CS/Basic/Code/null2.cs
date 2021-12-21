using System;

class Program
{
    public static void Main()
    {
        int? n1 = 10;
        int a1 = 20;

        n1 = a1; // int? = int        // ok   int? 가 int의 값을 담을 수 있음
        //a1 = n1; // int = int?        // error int? 는 int + bool값이므로 안됨

        a1 = (int)n1;                 // ok int = int? 명시적 캐스팅 하면 가능  

        n1 = null;
        //a1 = (int)n1;                 // error 명시적 캐스팅을 하더라도 int는 null값이 없음.  

        Console.WriteLine(a1);

        int? n2 = 10;
        int? n3 = 20;
        int? n4 = n2 + n3;              // Nullable도 사칙연산 가능

        Console.WriteLine(n4);

        n2 = null;
        n4 = n2 + n3;                   // null의 연산은 null이 된다.

        Console.WriteLine(n4 == null);

    }
}