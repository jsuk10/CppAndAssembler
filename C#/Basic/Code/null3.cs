using System;

class Car
{
    public int color = 10;
    public void Go() { Console.WriteLine("Go"); }
}

class Program
{
    public static Car CreateCar(int speed)
    {
        if (speed > 200) return null;

        return new Car();
    }
    public static void Main()
    {

        Car c1 = CreateCar(100);
        c1.Go();

        Car c = CreateCar(300);     // 실패해서 null

        c?.Go();                    // if(c) c.Go(); 와 동일함. null체크를 하고 비지 않으면 실행

        int n = c.color;            // ok but c가 null이라면??

        //int n = c?.color;         // error int는 null을 받지 못함.

        int? n = c?.color;          // 맞는 표현

        //------------------
        int[] arr = { 1, 2, 3 };

        int n2 = arr[0];
        int[] arr2 = null;          // { 1, 2, 3 };

        //int n3 = arr[0];          // error
        int? n2 = arr?[0];          // ok
    }
}
