using System;

public static class FileManager
{
    public static int CopyFile(string srcFileName, string dstFileName)
    {
        ///...
        return 100;     //하지만 파일 생성이나 접근에서 에러가 뜬다면??
    }
}

class Program
{
    static void Main()
    {
        FileManager.CopyFile("C://a.txt", "D://b.txt");
    }

}