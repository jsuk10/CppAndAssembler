using System;

class Program
{
    public static void Main()
    {

        int n1;
        //Console.WriteLine(n1);    //error 초기값이 없는 지역 변수는 사용할 수 없다.
        n1 = 20;
        Console.WriteLine(n1);

        double n2 = 10;

        var n3 = n2; //우변의 표현식을 보고 좌변의 타입을 결정함. C++ auto, 단 컴파일 타임 먹음

    }
}