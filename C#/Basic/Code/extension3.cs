using System;

//3. Exception(예외)사용

public static class FileManager
{
    //반환값이 2가지의미로 쓰임. => 반환값과 오류를 분리한다.
    public static bool CopyFile(string srcFileName, string dstFileName)
    {
        ///...

        if (true)       //실패 했다는 가정
        {
            throw new Exception("파일 접근 권한 없음");
        }

        return false;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            FileManager.CopyFile("C://a.txt", "D://b.txt");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }

}