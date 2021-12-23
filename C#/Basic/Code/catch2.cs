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
        //각각의 예외 처리
        catch (System.ArgumentException e) { }
        catch (System.Net.WebException e) { }
        catch (System.NotSupportedException e) { }


    }

}