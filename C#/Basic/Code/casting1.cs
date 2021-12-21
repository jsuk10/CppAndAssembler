using System;

class Program
{
    static void Main()
    {
        int    n = 3;
        double d = 3.4;

        d = n;          // ok       int => double. 데이타 손실 없음.
        //n = d;        // error    double=> int.  데이타 손실 발생.
        n = (int)d;     // 명시적 캐스팅
    }
}

