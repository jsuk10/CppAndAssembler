using System;

class XFileStream
{
    private IntPtr handle;

    public XFileStream(string pahth)
    {
        //CreateFile()
    }

    ~XFileStream()
    {
        //CloseFile()
    }

}

class Program
{
    static void Main()
    {
        XFileStream xfs = new XFileStream("a.txt"); // ��Ʈ�� ����
        xfs = null;
    }
}