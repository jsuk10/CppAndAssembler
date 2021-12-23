using System;
using System.Net;

class Program
{
    static void Main()
    {
        WebClient wc = new WebClient();

        //아래 코드에서 3가지 오류가 날 수 있다.
        //try catch문을 통해 잡을 수 있음.
        string s = wc.DownloadString("http://www.naver.com");


        Console.WriteLine(s);
    }

}