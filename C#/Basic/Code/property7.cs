using System;

// 인터페이스, 추상 클래스, property
interface Animal
{
    void cry();
    int Age { set; get; }
}

class Dog : Animal
{
    public void cry();
}

class Program
{
    static void Main()
    {
    }
}






