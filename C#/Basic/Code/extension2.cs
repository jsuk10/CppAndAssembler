using System;

//1. 반환값을 사용해서 전달
public static class FileManager
{
    public static int CopyFile(string srcFileName, string dstFileName)
    {
        ///...
        //if(Faild)
        return -1;
    }
}

class Program
{
    static void Main()
    {
        int ret = FileManager.CopyFile("C://a.txt", "D://b.txt");

        if (ret < 0)
        {
            //에러 처리
            //강제성이 없음.
        }
    }

}