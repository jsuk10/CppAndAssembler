using System;

// 비교 하는 메소드의 이름을 약속하자.
/*
// C# 1.0
// 인터페이스에 generic이 없었다.
interface IComparable
{
    int CompareTo(object other);
}
*/

/*
// C# 2.0 : generic interface
// generic 인터페이스 출현
interface IComparable<T>
{
    int CompareTo(T other);
}*/

struct Point : IComparable<Point>, IComparable
{
    private int x;
    private int y;
    public Point(int xPos, int yPos)
    {
        x = xPos;
        y = yPos;
    }

    public int CompareTo(Point pt)
    {
        if (x > pt.x) return 1;
        else if (x == pt.x) return 0;
        return -1;
    }

    public int CompareTo(object other)  //value 타입이 Ref타입으로 와서 Boxing이 일어난다.
    {
        //Point pt = other as Point;    //error Value 타입이기 때문에 안된다.

        Point pt = (Point)other;        //ref타입을 value타입으로 옮겨서 unBoxing이 일어난다.
        CompareTo(pt);
    }

}
class Program
{
    static void Main()
    {
        string s;
        Point p1 = new Point(1, 1);
        Point p2 = new Point(2, 2);

        Console.WriteLine(p1.CompareTo(p2));
    }
}

