using System;

class Program
{
    public void f1(int a = 0, int b = 0, int c = 0) { }       //ok
    public void f2(int a, int b = 0, int c = 0) { }     //ok

    // f3, f4는 error
    public void f3(int a, int b = 0, int c) { }             //error
    public void f4(int a = 0, int b, int c = 0) { }         //error


    public void f5(DateTime dt = DateTime.Now) { }          // error 컴파일 타임에 못잡음
    public void f6(DateTime dt = new DateTime()) { }        // ok 컴파일에 알 수 있음
    public void f7(DateTime dt = default(DateTime)) { }     // ok 컴파일에 알 수 있음

    public static void Main()
    {
        f3(1, 2);
    }
}
