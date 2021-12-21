# 목차

1. [C# 타입 변수와 특징](#C#-타입-변수와-특징)

   1-1. [C# 타입의 특징](#C#-타입의-특징)

2. [Object](#Object)

3. [ToString](#ToString)

<br>

# C# 타입 변수와 특징

1. 초기화 되지 않은 변수는 사용(Read)할 수 없다.

2. var

   - 우변의 표현식을 보고 좌변의 타입을 결정함.

   - C++ auto, 단 컴파일 타임 먹음

```C#
public static void Main()
{
    int n1;
    //Console.WriteLine(n1);     //error 초기값이 없는 지역 변수는 사용할 수 없다.
    n1 = 20;
    Console.WriteLine(n1);

    double n2 = 10;

    var n3 = n2;                 //우변의 표현식을 보고 좌변의 타입을 결정함.
                                 //C++ auto, 단 컴파일 타임 먹음
}
```

<br>

## 타입의 특징

1. C#은 모든것이 객체(Object)이다.

   - 10, 3.4, "AA", int도 모두 객체이다. (멤버를 가지고 있다.)

2. C#의 타입과 .net framework

   | int          | double        | char             | string        | object        |
   | ------------ | ------------- | ---------------- | ------------- | ------------- |
   | System.Int32 | System.Double | System.Character | System.String | System.Object |

```C#
public static void Main()
{
    // int : 타입
    // 10  : int 타입의 객체

    10.ToString();                  //10도 객체이기 때문에 함수 호출이 가능!
    //int.Parse();                  //int와 같은 타입도 객체
    //3.4.CompareTo

    int n1 = 10;                    // System.Int32
    Int32 n2 = 10;
    System.Int32 n3 = 10;           //n1, n2, n3 동일 코드

    string s1 = "AAA";
    String s2 = "AAA";
    System.String s3 = "AAA";       //s1, s2, s3셋다 동일한 코드임.
}

```

<br>

# Object

1. C#은 모든 타입이 System.Object로부터 파생된다.

   - 아무것도 상속받지 않아도 컴파일러에 의해 System.Object이 붙는다.

   - 모든 C#의 클래스는 공통의 특징(System.Object가 제공하는)을 가지고 있다.

2. System.Object

   - `{클래스명}.` 으로 스테틱 메서드 호출 가능

   - `{변수명}.`으로 가상, 일반 메서드 호출 가능

   ```C#
   public static bool Equals(Object objA, Object objB);
   public static bool ReferenceEquals(Object objA, Object objB);
   public virtual bool Equals(Object obj);
   public virtual int GetHashCode();
   public virtual string ToString();
   public Type GetType();
   protected Object MemberwiseClone();
   ```

```C#
using System;

class Car : //System.Object 이 생략되어 있음.
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
```

<br>

# ToString

객체를 문자열로 변경하는 메서드

1. System.Object의 기본 구현

   타입 이름을 문자열로 반환

2. 일반적으로 객체의 상태를 나타내도록 재정의

```C#
using System;

class Point
{
    private int xPos = 0;
    private int yPos = 0;

    public Point(int x, int y) { xPos = x; yPos = y; }

    public override string ToString() { return string.Format($"{xPos}, {yPos}"); } //해당 라인 주석시 Point로 나타남.
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 1);
        Point p2 = new Point(2, 2);
        Object p3 = p1;
        Console.WriteLine(p1.ToString());       //ovrride하지 않으면 class의 이름(Point)을 나타냄
        Console.WriteLine(p2.ToString());
    }
}
```
