using System;

class CPoint
{
    public int x;
    public int y;
}
struct SPoint
{
    public int x;
    public int y;
}

class Program
{
    public static void Main()
    {
        CPoint cp1;                 //# 객체 생성 아님. 참조 변수 생성
        CPoint cp2 = new CPoint();  //# 객체 생성.

        SPoint sp1;                 //# 객체 생성, 영역만 확보
        SPoint sp2 = new SPoint();  //# 객체 생성, 모든 맴버 0으로 초기화(initobj)

        // sp1.x = 10;              //넣어주면 아래 코드 가능
        // sp2.x = 10;

        Console.WriteLine($"{sp1.x}");  //초기화 되지 않은 값을 읽을 수 없음
        Console.WriteLine($"{sp2.x}");  //초기화 된 값읽는건 가능.



    }
}







