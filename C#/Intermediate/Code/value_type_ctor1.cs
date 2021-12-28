using System;

class CPoint
{
    public int x;
    public int y;
    public CPoint(int a, int b) { x = a; y = b; }
}
struct SPoint
{
    public int x;
    public int y;
    //public SPoint() { }       //만들면 error
    public SPoint(int a, int b) { x = a; y = b; }
}
class Program
{
    public static void Main()
    {
        CPoint cp1 = new CPoint(1, 2);  // ok
        //CPoint cp2 = new CPoint();     // error 인자 없는 생성자가 없음.
        SPoint sp1 = new SPoint(1, 2);  //ok
        SPoint sp2 = new SPoint();      //ok? ok
    }
}