using System;

class A { }
class B { }
class C { }

class Program
{
    static void Main()
    {
        A a1 = new A();
        B b1 = new B();
        C c1 = new C();

        Console.WriteLine(GC.GetGeneration(a1));    // 0 (����)
        GC.Collect(0);                              // 0 ���� GC
        b1 = null;

        Console.WriteLine(GC.GetGeneration(a1));    // 1 (����)
        GC.Collect(0);                              // 0 ���� GC

        Console.WriteLine(GC.GetGeneration(a1));    // 1 ����
                                                    // why) 0 ���븸 GC�� �� ��� 1����� GC�� ���� �°��� ���� �ʴ´�.
        GC.Collect(1);

        Console.WriteLine(GC.GetGeneration(a1));    // 2 ����
        A a2 = new A();
    }
}