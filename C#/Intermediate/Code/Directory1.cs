using System;
using System.IO;

class Program
{

    public static void PrintExeName(string path)
    {
        string[] names = Directory.GetFiles(path, "*.exe"); //path의 모든 exe파일을 얻는다.
        foreach (var name in names)
        {
            //File.Delete(name);
            // Console.WriteLine(name);
            Path.GetFileName(name);     //전체 경로에서 실행 파일 이름과 확장명 얻는다.
        }
        string[] dirs = Directory.GetDirectories(path);

        foreach (var dir in dirs)
            PrintExeName(dir);
    }
    public static void Main()
    {
        PrintExeName("B:\\CSHARP");
    }
}