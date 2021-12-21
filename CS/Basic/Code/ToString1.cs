using System;

class Point
{
    private int xPos = 0;
    private int yPos = 0;

    public Point(int x, int y) { xPos = x; yPos = y; }

    public override string ToString() { return string.Format($"{xPos}, {yPos}"); } //해당 라인 주석시 Point로 나타남.

}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 1);
        Point p2 = new Point(2, 2);
        Object p3 = p1;
        Console.WriteLine(p1.ToString());       //ovrride하지 않으면 class의 이름(Point)을 나타냄 
        Console.WriteLine(p2.ToString());
    }
}
