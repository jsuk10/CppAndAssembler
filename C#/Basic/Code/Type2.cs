using System;

class Program
{
    public static void Main()
    {
        // int : 타입
        // 10  : int 타입의 객체
        10.ToString();                  //10도 객체이기 때문에 함수 호출이 가능!
        //int.Parse();                  //int와 같은 타입도 객체

        //3.4.CompareTo

        int n1 = 10;                     // System.Int32
        Int32 n2 = 10;
        System.Int32 n3 = 10;           //n1, n2, n3 동일 코드

        string s1 = "AAA";
        String s2 = "AAA";
        System.String s3 = "AAA";       //s1, s2, s3셋다 동일한 코드임.

    }
}
