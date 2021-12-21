using System;

class Point
{
    public int x = 0;
    public int y = 0;
    public Point(int a, int b) { x = a; y = b; }
}

class Program
{
    public static void f1(Point p)      // Point p = p1
    {
        p.x = 2;                        // p1의 x는 2로 바뀜
        p = new Point(5, 5);            // p가 가르키는 객체는 5가 되었으나 p1이 가르키는 곳은 그대로임
    }
    public static void Main()
    {
        Point p1 = new Point(1, 1);
        f1(p1);
        Console.WriteLine(p1.x);        //out 2
        f2(ref p1);
        Console.WriteLine(p1.x);        //out 5
    }

    public static void f2(ref Point p)  // ref Point p = refp1
    {
        p.x = 2;
        p = new Point(5, 5);
    }

}