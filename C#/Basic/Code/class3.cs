using System;
using static System.Console;

class Base
{
    public virtual void Foo() { WriteLine("Base foo"); }
}
class Derived : Base
{
    //이렇게 해야 해당 메서드가 나온다.
    // public override void Foo() { WriteLine("Derived foo"); } //가상 메서드 재정의


    //아래는 Base foo가 호출된다.
    // public void Foo() { WriteLine("Derived foo"); }          
    // public new void Foo() { WriteLine("Derived foo"); }      // 새로운 메서드를 만든것
    // public virtual void Foo() { WriteLine("Derived foo"); }  // 또다른 가상 메서드 생성함.
}

class Program
{
    static void Main()
    {
        Base b = new Derived();
        b.Foo();
    }
}
