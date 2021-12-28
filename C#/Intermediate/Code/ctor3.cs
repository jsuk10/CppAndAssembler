using System;
using static System.Console;

class Base
{
    // public Base() { WriteLine("Base()"); }
    public Base(int n) { WriteLine("Base(int)"); }
}
class Derived : Base
{
    public Derived() : base(0) { WriteLine("Derived()"); }
    // 아래 두줄 코드는 기능이 동일하다.
    // public Derived(int n) { WriteLine("Derived(int)"); }
    // public Derived(int n) : base(){ WriteLine("Derived(int)"); }
    // 기반 클래스에도 인자를 넣고 싶으면 아래와 같이 하면된다.
    public Derived(int n) : base(n) { WriteLine("Derived(int)"); }
}
class Program
{
    public static void Main()
    {
        Derived d = new Derived(0);
    }
}