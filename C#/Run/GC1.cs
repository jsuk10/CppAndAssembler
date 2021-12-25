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

        Console.WriteLine(GC.GetGeneration(a1));    // 0 (세대)
        GC.Collect(0);                              // 0 세대 GC
        b1 = null;

        Console.WriteLine(GC.GetGeneration(a1));    // 1 (세대)
        GC.Collect(0);                              // 0 세대 GC

        Console.WriteLine(GC.GetGeneration(a1));    // 1 세대
                                                    // why) 0 세대만 GC를 할 경우 1세대는 GC나 세대 승격이 되지 않는다.
        GC.Collect(1);

        Console.WriteLine(GC.GetGeneration(a1));    // 2 세대
        A a2 = new A1();
    }
}