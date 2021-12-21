using System;
using System.Collections;


interface IList
{
    void Clear();
}

// 모든 컬렉션은 반드시 IList 를 구현해야 한다.
// 또한 System.Collections에서 해당 인터페이스를 제공한다.
// ex) Add , Pop, Copy등등~
class Stack : IList
{
    public void Clear() { Console.WriteLine("Stack"); }
}
class Queue : IList
{
    //public void Clear() { Console.WriteLine("Queue"); }       //인터페이스 구현시 해당 함수를 구현하지 않으면 컴파일 에러남.
}
class Program
{
    static void Main()
    {
        Stack s = new Stack();
        s.Clear();
    }
}
