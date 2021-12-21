using System;

class Programs
{
    static void Main(string[] args)
    {
        int n = Console.Read();             // 입력 버퍼로부터 입력받아 엔터를 눌러야함.
        Console.WriteLine(n);               // 

        ConsoleKeyInfo cki1 = Console.ReadKey();        //화면에 보이는 입력
        Console.WriteLine(cki1.KeyChar);
        ConsoleKeyInfo cki2 = Console.ReadKey(true);    //화면에 보이지 않는 입력
        Console.WriteLine(cki2.KeyChar);
    }
}
