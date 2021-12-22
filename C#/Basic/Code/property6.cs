using System;

class Point
{
    public int X { get; set; } = 0;
    public int Y { get; set; } = 0;
}

class Program
{
    static void Main()
    {
        Point p1 = new Point();                     // 일반 생성
        Point p2 = new Point() { X = 10, Y = 20 };  // 생성과 초기화 동시에
        Point p3 = new Point { X = 10, Y = 20 };    // 괄호 생략
        Point p4 = new Point { Y = 20 };            // 일부 속성만 초기화


        // 무명 타입
        var p = new { Name = "kim", Age = 20 };

        Console.WriteLine(p.Name); // "kim"
        //p.Name = "lee"; // error

        Type t = p.GetType();
        Console.WriteLine(t.FullName);
    }
}






