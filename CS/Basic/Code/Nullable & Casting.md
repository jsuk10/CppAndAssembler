# 목차

1. [Nullable](#Nullable)

   1.1 [Nullable 연산](#Nullable-연산)

   1.2 [Elvis operator](#Elvis-operator)

2. [Casting](#Casting)

   2.1 [is, as Casting](#is,-as-Casting)

   2.2 [변환 연산자 explicit](#변환-연산자-explicit)

<br>

# Nullable

Reference Type은 null(nullptr)을 통해 객체가 없음을 나타낼 수 있다.

Value Type은 null을 사용하지 못한다.

Nullable<T> 를 통해 Value타입에 값이 없음을 나타낼 수 있다.

- T 타입에 Bool을 추가한 값이다.

- 특히 메서드에서 반환시에 실패를 표기할 수 있다.

  ```C#
  //public static int foo()
  public static Nullable<int> foo()
  {
      if (faild)
          return null;        //nullalbe을 사용할 경우 null을 리턴 할 수 있다.
      return 100;
  }
  ```

- 💡 단축 표기법 제공

  `int? n3 = null; // Nullable<int> n3 = null`

## Nullable 연산

1. Nullable<int> = int

   가능하다. Nullable이 인트의 모든 범위를 나타낼 수 있음

2. int = Nullable<int>

   불가능 하다. int 는 null을 표기하지 못한다.

   💡 Nullable<int> 은 int + bool 이다.

3. Nullable(vlaue) + Nullable(value)

   사칙 연산이 가능하다.

4. Nullable(null) + Nullable(vlaue)

   하지만 하나가 null일 경우 값도 null

```c#
using System;

class Program
{
    public static void Main()
    {
        int? n1 = 10;
        int a1 = 20;

        n1 = a1; // int? = int        // ok   int? 가 int의 값을 담을 수 있음
        //a1 = n1; // int = int?        // error int? 는 int + bool값이므로 안됨

        a1 = (int)n1;                 // ok int = int? 명시적 캐스팅 하면 가능

        n1 = null;
        //a1 = (int)n1;                 // error 명시적 캐스팅을 하더라도 int는 null값이 없음.

        Console.WriteLine(a1);

        int? n2 = 10;
        int? n3 = 20;
        int? n4 = n2 + n3;              // Nullable도 사칙연산 가능

        Console.WriteLine(n4);

        n2 = null;
        n4 = n2 + n3;                   // null의 연산은 null이 된다.

        Console.WriteLine(n4 == null);

    }
}
```

<br>

## Elvis operator

1. null조건부 연산자 (?. , ?[)

   Elvis operator (물음표가 엘비스 프레슬리 닮아서 붙여졌다고 합니다)

   좌변이 null이면 좌변을 수행하지 않고 null을 반환

```c#
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

```

<br>

## null접합 연산자

null접합 연산자

    - 우측 수식이 null일 경우 좌변의 식을 반환값으로줌

    - null일 경우 디폴트 값으로 변경할 떄 사용됨

    💡 null safety

# Casting

C#의 캐스팅 규칙

1. 데이터의 손실이 없는 경우

   암시적 캐스팅 해줌

2. 데이터의 손실이 있을 경우

   명시적 캐스팅 해야한다!

```C#
int    n = 3;
double d = 3.4;

d = n;          // ok       int => double. 데이타 손실 없음.
//n = d;        // error    double=> int.  데이타 손실 발생.
n = (int)d;     // 명시적 캐스팅
```

## is, as Casting

다운 캐스팅 시, 모든 부모 타입(Animal)을 다운 캐스팅 하게 되면 원하지 않는 객체또한 캐스팅이 될 우려가 있음

```C#
// Animal 참조 타입을 Dog 참조타입으로 명시적 캐스팅
Dog d = (Dog)a;
// but Dog가 아닐 경우 예외 처리
d.Cry();
```

1. is

   참조 변수가 가르키는 실제 타입을 조사할 때 사용

   ```C#
   if ( a is Dog )
       {
           Console.WriteLine("Dog 맞음");
           Dog d = (Dog)a;
           d.Cry();
       }
   ```

2. as

   명시적 캐스팅시 실패하면 예외 처리가 되나

   as는 실패시 null을 반환함

   ```C#
   //Dog d = (Dog)a; // 실패시 예외
   Dog d = a as Dog; // 실패시 null 반환
   if (d == null)
   {
       Console.WriteLine("null");
   }
   ```

값 타입에 as 사용할 경우 nullable를 사용해야 한다.

```C#
int n = 3;
object obj = n;
//int n1 = obj as int; // error

int? n1 = obj as int?; // ok
Console.WriteLine(n1);
```

## 변환 연산자 explicit

특정 객체를 다른 객체로 `명시적 캐스팅` 할때 사용한다.

자주 사용하지는 않음.

- 단 as로는 못한다. (as는 사용자가 만든 변환 연산자를 호출 할 수 없다.)

ex) Point <-> int로 변환할때

```C#

class Point
{

    ~~~

    public static explicit operator int(Point pt)
    {
        return pt.x;
    }

    public static explicit operator Point(int n)
    {
        return new Point(n, n);
    }
}

~~~

Point pt = new Point(1, 2);

int n2 = (int)pt;           // Point => int.. ok

Point pt2 = (Point)n2;      // int => Point
```
