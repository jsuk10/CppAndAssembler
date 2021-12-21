using System;
using static System.Console;

class Base
{
    public int data1 = 10;
    public int data2 = 10;
}

class Derived : Base
{
    public new int data1 = 40;
}

class Program
{
    static void Main(string[] args)
    {
        Derived d = new Derived();
        Console.WriteLine(d.data1);         //상속 받은 클래스가 우선이다, 상위 클래스 가려서 경고 나옴.
        Console.WriteLine(((Base)d).data1); //캐스팅시 기반 클래스의 변수가 나옴
    }
}