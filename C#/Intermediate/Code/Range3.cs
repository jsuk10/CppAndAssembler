using System;

class Program
{
    static void Main()
    {
        int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Range r1 = new Range();                                          //빈값 출력
        // Range r1 = new Range(new Index(2), new Index(2, fromEnd: true)); //정석적 사용법
        // Range r1 = new Range(2, ^2);                                     //자주 쓰는 사용법
        Range r1 = 2..^2;                                                   //단축 표기법

        int[] arr2 = arr1[r1];

        foreach (var n in arr2)
            Console.WriteLine(n);
    }
}