using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] arr = { "kim", "lee", "park", "choi", "robert" };

        // // Fluent Syntax 확장 메서드를 부르는 방법
        // var e = arr.Where(s => s.Contains("o"))
        //                         .OrderBy(s => s.Length)
        //                         .Select(S => S.ToUpper());

        //SQL Query와 비슷함.
        var e = from s in arr
                where s.Contains("o")
                orderby s.Length
                select s.ToUpper();

        foreach (var n in e)
        {
            Console.WriteLine(n);
        }

    }
}