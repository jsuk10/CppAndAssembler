using System;

class Program
{
    static void Main()
    {
        //index 객체 만들기 1.new사용
        Index i1 = new Index(2);
        Index i2 = new Index(2, fromEnd: true);

        //index 객체 만들기 2. 정적 메서드 사용
        Index i3 = Index.FromStart(3);
        Index i4 = Index.FromEnd(3);

        //index 객체 만들기 3. 단축 표기법 사용
        Index i5 = 3;
        Index i6 = ^3;

    }
}