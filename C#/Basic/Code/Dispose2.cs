using System;
using System.IO;

class Car
{
    public void Go() { Console.WriteLine("Car Go"); }

    ~Car() { Console.WriteLine("~Car"); }
}

class Program
{
    static void Main()
    {
        Car c1 = new Car();
        Car c2 = new Car();

        c2 = null;

        GC.Collect();   //GC강제 수집
        GC.WaitForPendingFinalizers();
        c1.Go();
    }
}