using System;

class Car //: System.Object 이 생략되어 있음.
{

}

class Program
{
    static void Main(string[] args)
    {
        Car c = new Car();

        c.ToString();               //Car에는 ToString를 선언하지 않았음에도 있다.
                                    //Equals, GetHashCode, ToString, GetType 호출 가능
                                    //Car.Equals(null, null);   //Equals, ReferenceEquals호출 가능

    }
}
