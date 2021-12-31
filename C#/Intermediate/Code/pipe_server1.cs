using System;
using System.IO;
using System.IO.Pipes;
using System.Text;

class Program
{
    public static void RunServer()
    {
        NamedPipeServerStream ps = new NamedPipeServerStream("MyPipe",              // 이름.
                                                   PipeDirection.InOut,             // 양방향
                                                   1,                               // 동일 이름의 파이프의 갯수
                                                   PipeTransmissionMode.Message);   // 데이터 주고 받을 경우 방식 TCP : Stream, UDP :Message
        while (true)
        {
            Console.WriteLine("Wait Client...");
            ps.WaitForConnection();     // Client 접속 대기
            Console.WriteLine("Client Connected...");

            // 문자열 주고 받을 경우 어답터를 통하여 사용하면 편리하다.
            // Stream Adapter
            var sr = new StreamReader(ps);
            var sw = new StreamWriter(ps);

            //자동 flush
            sw.AutoFlush = true;

            //ECHO Sever
            string data = sr.ReadLine();

            Console.WriteLine($"SERVER RECEIVED : {data}");

            sw.WriteLine(data);
            // 버퍼에 있는 데이터를 모두 처리하는 함수
            //sw.Flush();

            ps.Disconnect();
        }
    }

    public static void Main()
    {
        RunServer();
        Console.WriteLine("Main");
        Console.ReadLine();
    }
}