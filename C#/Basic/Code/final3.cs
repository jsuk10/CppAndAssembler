using System;
using System.IO;

class Program
{
    static void Main()
    {
        using (FileStream fs = new FileStream("a.txt", FileMode.CreateNew))
        {
            try
            {
                //...
            }
            catch (Exception e)
            {

            }
        }
        // FileStream fs = null;

        // try
        // {
        //     fs = new FileStream("a.txt", FileMode.CreateNew);
        // }
        // finally
        // {
        //     if (fs != null)
        //         fs.Dispose();
        // }

    }

}