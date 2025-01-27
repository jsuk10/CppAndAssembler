﻿using System;

class Program
{
    static void Main()
    {
        int[] arr1; // 참조변수만.
        int[] arr2 = new int[5];
        int[] arr3 = new int[5] { 1, 2, 3, 4, 5 };
        int[] arr4 = new int[] { 1, 2, 3, 4, 5 };
        int[] arr5 = { 1, 2, 3, 4, 5 };

        Type t = arr5.GetType();
        Console.WriteLine(t.FullName);                  //배열의 타입 출력
        Console.WriteLine(t.BaseType.FullName);         //배열의 부모 타입 출력
        Console.WriteLine(t.BaseType.BaseType.FullName);//최상위는 오브젝트.
        System.Array a;

        Console.WriteLine(arr5.Length);         // 5
        Console.WriteLine(arr5.GetLength(0));   // 5
        Console.WriteLine(arr5.GetValue(3));    // arr5[3]
        Console.WriteLine(arr5.GetLowerBound(0));//0
        Console.WriteLine(arr5.GetUpperBound(0));//4


        int[] arr6 = { 1, 2, 3, 4, 5 };         // 배열 생성
        int[] arr7 = arr6;                      // arr6을 가르킴
        // arr6의 복사본을 생성, return 이 Object라서 캐스팅 해야함
        int[] arr8 = (int[])arr6.Clone();

        Console.WriteLine(arr6 == arr7);   // true            
        Console.WriteLine(arr6 == arr8);   // false
    }
}






// 1. 배열의 기본 모양