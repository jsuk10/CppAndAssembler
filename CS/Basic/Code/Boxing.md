# 목차

<br>

# Boxing/UnBoxing

Boxing

- 스택에 있는 객체를 힙에 복사본을 만드는 행위를 Boxing이라고 한다.

- value Type을 Ref Type로 가르키게 되면 복사본을 만들어서 Heap에 저장하고 가르킨다.

unBoxing

- 힙에 있는 객체를 스택에 복사하는 행위

- Ref Type을 Value타입으로 가르키게 되면 복사본을 만들어서 Stack에 저장한다.

# 객체 크기를 비교하는 방법

1. 관계 연산자( < )

   retrun 으로 bool값이 나옴

   String타입은 비교할 수 없음

   - 수치 관련 타입 비교할 경우 사용

2. CompareTo()

   return 으로 int값이 나옴 (-1, 0, 1)

   String타입을 비교할 수 있음

   - 크기 비교 가능한 대부분의 타입 지원

   ```c#
   Console.WriteLine(10.CompareTo(20)); // -1
   Console.WriteLine(10.CompareTo(10)); // 0
   Console.WriteLine(10.CompareTo(5));  // 1

   Console.WriteLine("AAA".CompareTo("BBB")); // -1
   ```

# CompareTo 구현

CompareTo

| A > B     | A == B | A < B     |
| --------- | ------ | --------- |
| 양수 반환 | 0반환  | 음수 반환 |

```C#
public int CompareTo(object other)
{
    Point pt = other as Point;

    if (x > pt.x) return 1;
    else if (x == pt.x) return 0;
    return -1;
}
```

인터페이스로 만드는 것이 다른 사용자들이 이해하기 편하고 일관성 있는데 인터페이스로 System.IComparable 이 있다.

- 💡 비교 가능한 타입은 IComparable상속 해야 한다.

`void foo(IComparable c) { }`와 같이 크기 비교가 가능한 함수에 인자로 보낼 수 있다.

C#은 메서드의 규칙을 담는 인터페이스를 제공하므로 해당 인터페이스를 상속하는 것이 좋다.

## CompareTo Boxing / UnBoxing (Generic)

struct 즉 Value Type에서 IComparable의 CompareTo 를 구현하면 Boxing와 unBoxing이 일어나서 성능 저하가 된다.

```C#
//value 타입이 Ref타입으로 와서 Boxing이 일어난다.
public int CompareTo(object other)
{
    //error Value 타입이기 때문에 안된다.
    //Point pt = other as Point;

    //ref타입을 value타입으로 옮겨서 unBoxing이 일어난다.
    Point pt = (Point)other;

    if (x > pt.x) return 1;
    else if (x == pt.x) return 0;
    return -1;
}
```

Generic이 등장하며 동일한 타입으로 인자를 받을 수 있다.

```C#
struct Point : IComparable<Point>
{
    private int x;
    private int y;
    public Point(int xPos, int yPos)
    {
        x = xPos;
        y = yPos;
    }

    //같은 타입이므로 Boxing / UnBoxing이 일어나지 않음
    public int CompareTo(Point pt)
    {
        if (x > pt.x) return 1;
        else if (x == pt.x) return 0;
        return -1;
    }
}

```

| ICompareable                  | ICompareable<T>                      |
| ----------------------------- | ------------------------------------ |
| C# 1.0의 인터페이스           | C# 2.0에 새로 나온 인터페이스        |
| 메소드 인자로 Objcet를 사용   | Generic 사용                         |
| Boxing / UnBoxing이 일어난다. | Boxing / UnBoxing이 일어나지 않는다. |

둘다 구현하는 것을 권장한다.

ex) System.String, System.int

```C#
using System;

struct Point : IComparable<Point>, IComparable
{
    private int x;
    private int y;
    public Point(int xPos, int yPos)
    {
        x = xPos;
        y = yPos;
    }

    public int CompareTo(Point pt)
    {
        if (x > pt.x) return 1;
        else if (x == pt.x) return 0;
        return -1;
    }

    public int CompareTo(object other)
    //value 타입이 Ref타입으로 와서 Boxing이 일어난다.
    {
        //error Value 타입이기 때문에 안된다.
        //Point pt = other as Point;
        //ref타입을 value타입으로 옮겨서 unBoxing이 일어난다.
        Point pt = (Point)other;
        CompareTo(pt);
    }
}
class Program
{
    static void Main()
    {
        string s;
        Point p1 = new Point(1, 1);
        Point p2 = new Point(2, 2);

        Console.WriteLine(p1.CompareTo(p2));
    }
}
```

# Equals Boxing / UnBoxing

Equals도 마찬가지로 struct (Value)이면 Boxing UnBoxing 이 일어나 성능 저하의 원인이 된다.

C#에서 해당 문제를 해결하기 위해 IEquatable<T>의 인터페이스를 제공한다.

```C#
struct Point : IEquatable<Point>
{
    private int x;
    private int y;
    public Point(int xPos, int yPos)
    {
        x = xPos;
        y = yPos;
    }
    public bool Equals(Point pt)
    {
        Console.WriteLine("Point");
        return x == pt.x && y == pt.y;
    }
    public override bool Equals(object obj)
    {
        Console.WriteLine("object");
        Point pt = (Point)obj;
        return Equals(pt);
    }
}
```

| Equals                                               | CompareTo                                     |
| ---------------------------------------------------- | --------------------------------------------- |
| Object 클래스가 제공 = 모든 타입 존재                | IComparable 인터페이스를 구현한 타입에만 존재 |
| 인터페이스가 1개 존재함(T), Object는 자체적으로 제공 | 인터페이스가 2개(object, T) 존재함            |
| Object는 Equals()이 존재 하기 떄문                   | Object는 CompareTo()를 가지고 있지 않기 때문  |
