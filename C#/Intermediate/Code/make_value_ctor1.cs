using System;

struct SPoint
{
    public int x;
    public int y;
    public int cnt;

    public SPoint(int a, int b)
    {
        //this = new SPoint();  //이를 통해 모든 초기화를 자동으로 지원할 수 있음
        x = a;
        y = b;
        cnt = 0;                //이거 빼면 error됨.
    }
}
class Program
{
    public static void Main()
    {
        SPoint pt = new SPoint(1, 2);
    }
}







