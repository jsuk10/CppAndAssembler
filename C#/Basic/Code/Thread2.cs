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
        // ���ڰ� ���� ���
        Thread t1 = new Thread(F1);
        t1.Start();
        // ���ڰ� �ϳ� �ִ� ��� (Obj)
        Thread t2 = new Thread(F2);
        t2.Start("hello");
        // ���ڰ� �ϳ� �ִ� ��� (String)
        //Thread t3 = new Thread(F3); //error 
        //why? Thread Start �� ���ڰ� ���ų� object�̿��� �Ѵ�.
        Thread t3 = new Thread(() => F3("Hello")); //OK

        //why? F3�� ���� �ϴ� ���� �ƴ� ���� (���ڰ� ���� �Լ�)�� �����Ű�� ���̽�
        t3.Start();

        // ���ڰ� �ΰ� �ִ� ��� (String, int)
        Thread t4 = new Thread(() => F4("Hello", 5));
        t4.Start();
    }
}