using System;
using System.Net;

class Program
{
    static void Main()
    {

        try
        {
            WebClient wc = new WebClient();
            string s = wc.DownloadString("http://www.naver.com");
            Console.WriteLine(s);
        }
        catch (System.Exception e) { }      //모든 예외 처리
    }

}