using System;
using System.Threading;

class Program
{
    public static void F1() { }
    public static void F2(object obj) { }
    public static void F3(string s1) { }
    public static void F4(string s1, int n) { }
    static void Main()
    {
        // 인자가 없는 경우
        Thread t1 = new Thread(F1);
        t1.Start();
        // 인자가 하나 있는 경우 (Obj)
        Thread t2 = new Thread(F2);
        t2.Start("hello");
        // 인자가 하나 있는 경우 (String)
        //Thread t3 = new Thread(F3); //error 
        //why? Thread Start 는 인자가 없거나 object이여야 한다.
        Thread t3 = new Thread(() => F3("Hello")); //OK

        //why? F3을 실행 하는 것이 아닌 람다 (인자가 없는 함수)를 실행시키는 케이스
        t3.Start();

        // 인자가 두개 있는 경우 (String, int)
        Thread t4 = new Thread(() => F4("Hello", 5));
        t4.Start();
    }
}