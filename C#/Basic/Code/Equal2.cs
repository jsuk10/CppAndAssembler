using System;

struct Point
{
    public int x;
    public int y;
    public Point(int xPos, int yPos)
    {
        x = xPos;
        y = yPos;
    }

    // x만 비교할 경우 ovrride를 통해 재정의한다.
    public override bool Equals(object obj)
    {
        Point pt = (Point)obj;
        return x == pt.x;
    }
}

class Program
{
    static void Main()
    {
        Point p1 = new Point(1, 1);
        Point p2 = p1;
        p2.y = 2;

        // 방법 1. == 연산자 사용
        // Console.WriteLine(p1 == p2);         //error - 연산자 재정의 하면 error X

        // 방법 2. Equals() 가상함수 사용
        // 메모리 전체 내용을 서로 비교한다.
        Console.WriteLine(p1.Equals(p2));       // 재정의시 x 값만 비교하므로 true
    }
}




