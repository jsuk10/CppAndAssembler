using System;

interface ICamera
{
    void takePicture();

    void uploadSNS()
    {
        Console.WriteLine("Uplod SNS");
    }
}

class Camera : ICamera
{
    public void takePicture()
    {
        Console.WriteLine("Take Picture With Camera");
    }
}

class Program
{
    public static void Main()
    {
        Camera c = new Camera();
        c.takePicture();
        // c.uploadSNS();   //상속된 타입으로 호출 불가능

        ICamera ic = c;
        ic.uploadSNS();     //인터페이스로는 호출 가능
    }
}
