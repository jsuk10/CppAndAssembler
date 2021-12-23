using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Collections.Concurrent;
class Program
{
    public static void Main()
    {
        ArrayList c1 = new ArrayList();                 //Object로 저장한다.

        StringCollection c2 = new StringCollection();

        List<int> c3 = new ArrayList();

        ConcurrentStack<int> c4 = new ConcurrentStack<int>();

    }
}