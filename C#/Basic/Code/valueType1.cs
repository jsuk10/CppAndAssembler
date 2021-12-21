using System;

struct SPoint
{
    public int x;
    public int y;
    public SPoint(int xPos, int yPos)
    {
        x = xPos;
        y = yPos;
    }
}
// 구조체

class CPoint
{
    public int x;
    public int y;
    public CPoint(int xPos, int yPos)
    {
        x = xPos;
        y = yPos;
    }
}
// 클래스

class Program
{
    public static void Main()
    {
        SPoint sp1 = new SPoint(1, 1);  // new를 하여도 stack에 할당됨
        CPoint cp1 = new CPoint(1, 2);  // new를 하면 힙에 할당

        SPoint sp2 = sp1;               // 객체를 복사하여 가짐 (객체 2개)
        CPoint cp2 = cp1;               // 동일한 객체를 가르킴 (객체 1개)

        sp2.x = 10;
        Console.WriteLine(sp1.x);       // 1

        cp2.x = 10;
        Console.WriteLine(cp1.x);       // 10
    }
}