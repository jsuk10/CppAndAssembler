using System;

class Sentence
{
    public int this[int idx] { get { return 0; } }
    public int this[string idx] { get { return 0; } }       // 정수 이외의 타입도 가능
    public int this[int idx, int idx2] { get { return 0; } }    //두개의 인자를 받을 수 있음.
    public int this[int idx, string idx2] { get { return 0; } }
}

class Program
{
    public static void Main()
    {
        Sentence s = new Sentence();

        int n1 = s["A"];
        int n2 = s[0, 1];
        int n3 = s[0, "A"];
    }
}