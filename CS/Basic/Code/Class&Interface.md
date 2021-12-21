# 목차

1. [C# vs C++ vs Java](#C#-vs-C++-vs-Java)
2. [메서드의 종류](#메서드의-종류)

   2-1. [일반 메서드](#일반-메서드)

   2-2. [가상 메서드](#가상-메서드)

3. [Interface](#Interface)

<br>

# C# vs C++ vs Java

1. 모든 맴버에 접근 지정자를 붙여줌

   1. c++

   ```c++
   private:
       int x = 0;
       int y = 6;
   ```

   2. c#, Java

   ```cs
    private int x = 0;
    private int y = 6;
   ```

2. 상속은 : 연산자를 사용한다.

   | C++                           | C#                     | java                         |
   | ----------------------------- | ---------------------- | ---------------------------- |
   | `class Derived : public Base` | `class Derived : Base` | `class Derived extends Base` |
   | :와 접근 변경자 붙여야함      | :만 적음               | extends붙여야 한다.          |

3. 객체를 생성

   | C++                          | C# java                          |
   | ---------------------------- | -------------------------------- |
   | `Derived *p = new Derived; ` | `Derived p = new Derived();`     |
   | 디폴트 생성자에 괄호가 없다. | 디폴트 생성자에 괄호가 들어간다. |
   | 포인터가 들어간다.           | 포인터가 없음.                   |

- 상속시 동일한 이름의 멤버 변수를 선언해 줄 수 있다.

  - override한 멤버를 출력하면 상속된 멤버가 나온다.

    - 가리게 되면 경고가 뜨는데 숨기기 위해 new를 붙여서 가능하다.

  - Base클래스의 멤버의 값을 가지고 싶으면 캐스팅 하면 된다.

  ```cs
  using System;
  using static System.Console;

  class Base
  {
      public int data1 = 10;
      public int data2 = 10;
  }

  class Derived : Base
  {
      public new int data1 = 40;            // 부모 클래스의 멤버를 가릴 경우 new를 붙이지 않았을 때 경고가 생긴다.
  }

  class Program
  {
      static void Main(string[] args)
      {
          Derived d = new Derived();
          Console.WriteLine(d.data1);         //상속 받은 클래스가 우선이다,
          Console.WriteLine(((Base)d).data1); //캐스팅시 기반 클래스의 변수가 나옴
      }
  }
  ```

<br>

# 메서드의 종류

## 일반 메서드

| C++ , C#                         | java                                      |
| -------------------------------- | ----------------------------------------- |
| 가상 함수도 있고 아닌 것도 있다. | 모든 메서드(멤버 함수)가 가상 메서드이다. |

- C++, C#은 가상 함수에 virtual을 붙여준다.

  - 일반 메서드(가상이 아닌 함수)를 override할 경우 경고가 생기는데 new로 없앨 수 있다.

```cs
using System;

class Base
{
    public void Foo() { Console.WriteLine("Base foo"); }
}
class Derived : Base
{
    public new void2 Foo() { Console.WriteLine("Derived foo"); }        //이 또한 new를 붙이지 않으면 경고난다.
}
class Program
{
    static void Main()
    {
        Base b1 = new Base();
        b1.Foo();                   // Base Foo

        Derived d1 = new Derived();
        d1.Foo();                   // Derived Foo

        Base b2 = new Derived();
        b2.Foo();                   // wht Foo ?
                                    // Derived Foo (java)
                                    // Base Foo(C#, C++)
    }
}

```

## 가상 메서드

| Ovrride                    | new                  | virtual                 |
| -------------------------- | -------------------- | ----------------------- |
| 가상 메서드를 재정의 한다. | 새로운 매소드를 생성 | 새로운 가상 메서드 선언 |

```cs
using System;
using static System.Console;

class Base
{
    public virtual void Foo() { WriteLine("Base foo"); }
}
class Derived : Base
{
    //이렇게 해야 해당 메서드가 나온다.
    public override void Foo() { WriteLine("Derived foo"); } //가상 메서드 재정의


    //아래는 Base foo가 호출된다.
    // public void Foo() { WriteLine("Derived foo"); }
    // public new void Foo() { WriteLine("Derived foo"); }      // 새로운 메서드를 만든것
    // public virtual void Foo() { WriteLine("Derived foo"); }  // 또다른 가상 메서드 생성함.
}

class Program
{
    static void Main()
    {
        Base b = new Derived();
        b.Foo();
    }
}

```

# Interface

클래스를 만드는 사람과 사용하는 사람 사이의 규칙(메서드 이름)을 정의 하는 것.

- 여러 클래스에서 같은 기능(함수)를 가지게 강제해 준다.

  ex) Stack, Queue는 Add,Pop등의 함수를 구현해야 한다.

- 구현을 하지 않을 경우 컴파일단계에서 에러가 난다.

```c#
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
    public void Clear() { Console.WriteLine("Queue"); }
    //인터페이스 구현시 해당 함수를 구현하지 않으면 컴파일 에러남.
}
class Program
{
    static void Main()
    {
        Stack s = new Stack();
        s.Clear();
    }
}

```

💡 C#의 핵심

1. 다양한 인터페이스를 먼저 설계(제공)한다.

2. 대부분의 클래스는 특정 인터페이스를 구현하는 방식으로 메서드를 제공

인터페이스 생성법

    - 접근 제한자를 표기하지 않았으나 C# 8.0이상에서는 접근 제한자 지원.

    - 메서드 구현시 ovrride를 표기하지 않는다.

    - 가상 메서드, 일반 메서드로 구현할 수 있다.

```c#
using System;

interface ICamera
{
    void Take();
}

class MP3
{
    public virtual void Play() { }
}

class SmartPhone : MP3, ICamera
{
    public override void Play() { }     //가상 함수를 재정의함.

    //public ovrride void Take() { }    //error 인터페이스는 구현이 없기 때문에 ovrride를 하지 않는다.
    //public void Take() { }            //이렇게 해도 됨.
    public virtual void Take() { }      //가상으로 만들거나 일반 함수로 만들어도 됨.
}

class Program
{
    static void Main()
    {

    }
}

```
