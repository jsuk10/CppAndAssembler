using System;

class Shape { }
class Circle : Shape { }

class Rectangle : Shape
{
    public double width = 100;
    public double height = 100;
}

class Program
{
    public static void Draw(Shape s)
    {
        switch (s)
        {
            // 값을 조사 한다.
            // const pattern matching
            case null:
                break;

            // 해당 타입을 조사한다
            // 캐스팅 까지 수행
            // type pattern matching
            case Circle c:
                break;

            //when을 통해 조건을 추가함.
            case Rectangle r when r.width == r.height:
                break;

            // 해당 라인이 위의 case위에 있을 경우 위의 case는 실행이 안됨
            // 일반적인 조건이 아래에 있어야함.
            case Rectangle r:
                break;

            default:
                break;
        }
    }

    public static void Main()
    {
        Draw(new Rectangle());

        //# 전통적인 switch 문의 구조

        int n = 1;
        switch (n)
        {
            case 1:
                break;
            case 2:
                break;
            default:
                break;
        }
    }
}
