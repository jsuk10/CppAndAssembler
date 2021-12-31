using System;

class Sentense
{
    private string[] words = null;

    public Sentense(string s) { words = s.Split(); }

    public string this[int idx] { get { return words[idx]; } } //indexer 문법
    // public string this[Index idx] { get { return words[idx]; } } //indexer 문법

    public int Length { get { return words.Length; } }
    // ^int 지원. (2번 방법)
}

class Program
{
    static void Main()
    {
        Sentense sen = new Sentense("C# PR Study");

        string s1 = sen[1];
        string s2 = sen[^1];    // 1. this[Index] 검색
                                // 2. sen[sen.Length - Value]
                                // 3. sen[sen.Count - Value]

        Console.WriteLine($"{s1}, {s2}");
    }
}