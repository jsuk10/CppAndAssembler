using System;
using System.Collections.Generic;
class Program
{

    public static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        List<int> c1 = new List<int>(array);
        LinkedList<int> c2 = new LinkedList<int>(array);

        IEnumerator<int> e1 = c1.GetEnumerator();
        var e2 = c2.GetEnumerator();
        //최초 호출 = 초기화, 이동 불가시 false
        while (e1.MoveNext())
        {
            Console.WriteLine(e1.Current);  // 1, 2, 3, 4, 5
        }

        e1.Reset();                 //최초상태 초기화
    }
}