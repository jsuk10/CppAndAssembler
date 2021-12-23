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
        catch (WebException e) when (e.Status == WebExceptionStatus.NameResolutionFailure)
        {
            Console.WriteLine("URL이 잘못 되었습니다.");
        }
        catch (WebException e) when (e.Status == WebExceptionStatus.Timeout)
        {
            Console.WriteLine("URL이 잘못 되었습니다.");
        }
        catch (Exception e)
        {
        }
        wc.Dispose();
    }

}