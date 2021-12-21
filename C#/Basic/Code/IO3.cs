using System;
using static System.Console;

class Programs
{
    static void Main(string[] args)
    {
        string s1 = Console.ReadLine();             // 라인 입력 받기
        Console.WriteLine(s1);                      // 라인을 입력받아서 공백까지 입력받음

        string s2 = Console.ReadLine();
        int intValue = Convert.ToInt32(s2);         // 정수로 변환, 문자열 입력시 예외됨
        Console.WriteLine(intValue);                // 정수 출력

        string s3 = Console.ReadLine();
        double doubleValue = Convert.ToDouble(s3);  // 정수로 변환, 문자열 입력시 예외됨
        Console.WriteLine(doubleValue);             // 정수 출력

        int c1 = Console.Read();
        Console.WriteLine(c1);                      // 아스키 코드로 나온다.
        Console.WriteLine((char)c1);                // 케스팅함.
    }
}
