using System;

class Base
{
    public void Foo() { }
    public virtual void Goo() { }
}

class Derived : Base
{
    public new void Foo() { }
    public override void Goo() { }
    public static void Hoo() { }
}

class Program
{
    public static void Main()
    {
        Base b = new Derived();
        b.Foo();                    // 비가상  call     IL : VirtualCall    null일수도 있어서
        b?.Foo();                   // call             IL : Call           null이 아님을 보장.
        b.Goo();                    // 가상 callvirt    IL : VirtualCall

        dynamic d = new Derived();
        d.Foo();                    // 비가상 call      IL : VirtualCall
        d.Goo();                    // 가상 call        IL : VirtualCall
    }
}