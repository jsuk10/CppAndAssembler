using System;
using System.IO;
using System.IO.Compression;
using System.Net;

class Program
{
    public static void Main()
    {
        byte[] buff = new byte[1024 * 1024]; // 1M

        FileStream fs = new FileStream("d:\\a.dat", FileMode.Create);

        //Decorator
        GZipStream gs = new GZipStream(fs, CompressionLevel.Fastest);

        //Decorator에 Decorator추가
        BufferedStream bs = new BufferedStream(gs);


        //fs.Write(buff, 0, buff.Length);
        bs.Write(buff, 0, buff.Length);
        bs.Close();
        gs.Close();
        fs.Close();
    }
}