using System;

class Point
{
    public int x;
    public int y;
    public Point(int a, int b) { x = a; y = b; }

    public void Deconstruct(out int a, out int b)
    {
        a = x;
        b = y;
    }
}
class Program
{
    public static void Main()
    {
        Point point = new Point(1, 2);

        int a = point.x;
        int b = point.y;

        var (a1, b1) = point;

        point.Deconstruct(out int a2, out int b2);

        Console.WriteLine($"{a1}, {b1}");
    }
}