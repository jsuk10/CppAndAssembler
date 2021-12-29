using System;

class Sentense
{
    private string[] words = null;

    public Sentense(string s) { words = s.Split(); }

    // public string this[int idx] { get { return words[idx]; } } //indexer 문법
    public string this[Index idx] { get { return words[idx]; } } //indexer 문법
}

class Program
{
    static void Main()
    {
        Sentense sen = new Sentense("C# PR Study");

        string s1 = sen[1];     // 인덱서 지원하므로 가능
        string s2 = sen[^1];    // 정의 안했기 때문에 불가능

        Console.WriteLine($"{s1}, {s2}");
    }
}