using System;
using System.Net;

class Program
{
    static void Main()
    {
        WebClient wc = new WebClient();
        try
        {
            string s = wc.DownloadString("http://www.naver.com");
        }
        catch (WebException e)
        {
            if (e.Status == WebExceptionStatus.NameResolutionFailure)
            {
                Console.WriteLine("URL이 잘못 되었습니다.");
            }
            else if (e.Status == WebExceptionStatus.Timeout)
            {
                Console.WriteLine("URL이 잘못 되었습니다.");
            }
            else
            {
                Console.WriteLine("다른 문제");
            }
        }
        catch (Exception e)
        {

        }
        wc.Dispose();
    }

}