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
        catch (System.ArgumentException e) { }  // 특정 예외를 처리한 뒤에
        catch (System.Exception e) { }          // 나머지 모든 예외 처리
    }
}