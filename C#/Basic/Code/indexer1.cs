using System;

class Sentence
{
    private string[] words = null;

    public Sentence(string s) { words = s.Split(); }    //공백은 구분자로 나눈 배열을 반환함

    //public string Name
    public string this[int idx]                         //프로퍼티와 유사함.
    {
        get { return words[idx]; }
        set { words[idx] = value; }
    }

    public override string ToString()
    {
        return string.Join(" ", words);                 //1번 인자를 구분자로 2번 인자의 모든 요소를 합칩
    }
}


class Program
{
    public static void Main()
    {
        Sentence s = new Sentence("Dog is Animal");

        s[0] = "Cat";                               // 원래는 안되는데 인덱서 사용하면 됨.
                                                    // why) 객체는 배열이 아니기 떄문

        Console.WriteLine(s[0]);                    // Cat
        Console.WriteLine(s);                       // Cat is Animal

        // s.ToString()
    }
}