using System;

delegate void HANDLER();


class Button
{
    public event HANDLER handler = null;

    public void press()
    {
        // ?.   ?[
        //handler?();
        handler?.Invoke();
    }
}

/*
class Button
{
    private HANDLER handler = null;

    public void add_handler(HANDLER f) { handler += f; }
    public void remove_handler(HANDLER f) { handler -= f; }
    public void press()
    {
        //handler();           //null 체크 해야함.
        // ?은. ?.이나 ?[]만 된다 
        handler?.Invoke();      //?을 사용하기 위함
    }
}
*/
class Program
{
    static void Main()
    {
        Button btn = new Button();

        //btn.handler = F1;  // A라는 사람이 등록
        //btn.handler += F2; // B의 의도
        //btn.handler = F2; // B의 실수

        btn.handler += F1; // btn.add_handler(F1)
        btn.handler += F2; // btn.add_handler(F2)
        //btn.handler = F1;

        btn.press();
    }
    public static void F1() { Console.WriteLine("F1"); }
    public static void F2() { Console.WriteLine("F2"); }
}

