# 목차

1. [VlauType](#VlauType)
2. [which one Vlaue Type](#which-one-Vlaue-Type)
3. [Check Value vs Reference](#Check-Value-vs-Reference)

# VlauType

1. 메모리 구조와 객체의 위치

   1. Stack

      지역변수가 해당 위치에 들어감

      `Point a;` stack에 객체 생성

   2. Heap

      메모리를 할당하여 객체를 생성 할 경우

      `new Point();` heap에 객체 생성, 받을때는 주소로.

2. C# struct vs Class

| Struct              | class              |
| ------------------- | ------------------ |
| 객체가 stack에 생성 | 객체가 heap에 생성 |
| value Type          | Reference Type     |
|                     | 참조 변수          |

- 타입을 만드는 사람이 메모리의 위치를 결정한다.
- 포인터의 개념이 없음

💡 C/C++은 객체의 메모리 위치를 타입을 사용하는 사람이 결정

```C#
using System;

struct SPoint
{
    public int x;
    public int y;
    public SPoint(int xPos, int yPos)
    {
        x = xPos;
        y = yPos;
    }
}
// 구조체

class CPoint
{
    public int x;
    public int y;
    public CPoint(int xPos, int yPos)
    {
        x = xPos;
        y = yPos;
    }
}
// 클래스

class Program
{
    public static void Main()
    {
        SPoint sp1 = new SPoint(1, 1);  // new를 하여도 stack에 할당됨
        CPoint cp1 = new CPoint(1, 2);  // new를 하면 힙에 할당

        SPoint sp2 = sp1;               // 객체를 복사하여 가짐 (객체 2개)
        CPoint cp2 = cp1;               // 동일한 객체를 가르킴 (객체 1개)

        sp2.x = 10;
        Console.WriteLine(sp1.x);       // 1

        cp2.x = 10;
        Console.WriteLine(cp1.x);       // 10
    }
}
```

# which one Vlaue Type

C# 에서 객체를 만들때 new를 해서 만들어 줘야한다.

하지만 기본 타입은 그냥 대입하면 생성되는데 어떤 것이 value이고 어떤것이 ref인가?

1.  int

    `int a = 1`으로 선언한다.

    int = struct를 상속 즉 value Type

2.  Array

    array는 `int[] arr = {1,2,3}`으로 선언 한다.

    array는 System.Array(class)로 부터 파생된다, 즉 ref type

3.  String

    String은 `string s1 = "hello"`로 선언한다.

    String는 class로 형성되어 있다, 즉 ref type

    ⚠️ 하지만 `s1 = "World"`는 `s1 = new String("World")`가 되므로 새로운 객체가 생성된다.

        why) String은 상태를 변경할 수 없는 Immutable Class(불변 객체)이기 떄문

| Value            | Reference      |
| ---------------- | -------------- |
| 크기가 작은 것들 | 크기가 큰 것들 |
| struct           | class          |
| enum             | interface      |
|                  | delegate       |

```C#
using System;

class Program
{
    public static void Main()
    {
        // int n = new int();
        // 1. int
        int n1 = 1;
        int n2 = n1;
        n2 = 10;
        Console.WriteLine(n1);          // 1 = value Type

        // 2. array
        //System.Array a;               //Array의 원본 객체
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = arr1;
        arr2[0] = 10;
        Console.WriteLine(arr1[0]);     // 10   =   ref Type

        // 3. string
        string s1 = "Hello";
        string s2 = s1;
        Console.WriteLine(s1 == s2);     // true
        s2 = "world";                    // s2 = new string("world")
        Console.WriteLine(s1 == s2);    // false
        Console.WriteLine(s1);          // "world"
    }
}
```

<br>

# Check Value vs Reference

GetType를 이용해서 Value인지 Ref인지 볼 수 있다.

```C#
int[] arr = { 1, 2, 3 };
Type t = arr.GetType();
Console.WriteLine(t.IsValueType);
```

해당 Type을 통해 클래스의 타입과 같은 여러 정보들을 알 수 있다.
