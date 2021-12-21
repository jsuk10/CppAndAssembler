# 목차



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


# Cast