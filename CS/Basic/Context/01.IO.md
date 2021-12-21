1. [📌 C# 기본 코드](#-C#-기본-코드)
2. [📌 C# 표준 입출력](#-표준-입출력)

   2-1. [C# String](##-C#-String)

3. [📌 C# 표준 입력](#-표준-입력)

   3-1. [버퍼 사용시](#버퍼-사용)

   3-2. [버퍼를 사용하지 않는 경우](#버퍼를-사용하지-않는-경우)

# 📌 C# 기본 코드

특징

1. Main 함수도 클래스의 멤버이다.

   Static method로 작성

2. Main 함수의 모양

   1. void Main()
   2. void Main(string[] args)
   3. int Main()
   4. int Main(string[] args)

3. 용어

   멤버함수 => 메소드

   멤버 데이터 => 필드

<br>

# 📌 표준 입출력

```c#
System.Console.WriteLine("Hello World!");
```

| namespcae name | class name | statoc method | Parm           |
| -------------- | ---------- | ------------- | -------------- |
| Ststem         | Console    | WriteLine     | "Hello World!" |

- using

  using 키워드를 통해 namespace를 생략 할 수 있다.

  - static class또한 마찬가지로 가능

    ```c#
    using System;
    using static System.Console;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");  //System 생략
            WriteLine("Hello World!");          //System.Console 생략
        }
    }
    ```

# 📌 변수 출력

1. 변수만 출력하는 경우
   ```cs
   Console.WriteLine(n);
   ```
2. 서식에 맞게 출력 하는 경우

   1. 위치에 맞게 출력

      ```cs
      Console.WriteLine("n = {0} d = {1} n = {0}", n, d);
      ```

   2. 보간 문자열 사용

      ```cs
      Console.WriteLine($"n = {n} d = {d}");
      ```

3. 특수 문자 출력

   1. 특정 문자만 제거
      ```cs
      Console.WriteLine("C:\\AAA\\BBB\\a.text");
      ```
   2. 모든 특수 문자열을 그대로 출력

      ```cs
      Console.WriteLine(@"C:\\AAA\\BBB\\a.text");
      ```

## C# String

1. regular string : `"Hello"`
   일반적 스트링

2. interpolated String (보간 문자열) : `$"n = {n}"`

   문자열에 변수를 넣어 출력한다.

3. verbatim String : `@"C:\"`

   특수 문자를 그대로 출력한다.

<br>

# 📌 표준 입력

## 버퍼 사용

1. 한줄 입력 받기 `Console.ReadLine()`

2. 정수, 실수 입력 받기

   문자열로 입력 받은 이후에 변환해서 사용한다.

   1. `Conver.ToInt32(string)`

   2. `int.Parse(string)`

   3. `int.TryParse()`

   double도 마찬가지.

3. 문자 한개 입력 `Console.Reda()`

   반환값이 int임.

   -> char타입으로 캐스팅 해야 한다.

   ```cs
   int c1 = Console.Read();
   Console.WriteLine(c1);                      // 아스키 코드로 나온다.
   Console.WriteLine((char)c1);                // 케스팅함.
   ```

입력을 하기 위해(버퍼에 넣기 위해) Enter을 사용해야 한다는 단점이 있음.

## 버퍼를 사용하지 않는 경우

- `Console.ReadKey`를 사용한다.

  - 특징

  1.  인자로 bool을 줄 수 있는데 true를 줄 경우 화면에 출력되지 않는다.

  2.  return 타입을 ConsoleKeyInfo로 받는다.

      출력하기 위해서는 ConsoleKeyInfo.KeyChar 이나 ConsoleKeyInfo.Key로 출력해야한다.

```cs
using System;
using static System.Console;

class Programs
{
    static void Main(string[] args)
    {
        ConsoleKeyInfo cki1 = Console.ReadKey();        //화면에 보이는 입력
        Console.WriteLine(cki1.KeyChar);
        ConsoleKeyInfo cki2 = Console.ReadKey(true);    //화면에 보이지 않는 입력
        Console.WriteLine(cki2.KeyChar);
    }
}

```
