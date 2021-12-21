using System;

class Program
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3 };
        Type t = arr.GetType();
        Console.WriteLine(t.IsValueType);           //False Array is RefType

        int n = 1;
        Type t1 = n.GetType();
        Console.WriteLine(t1.IsValueType);          //true int32 is ValueType

        string s = "hello";
        Type t2 = s.GetType();
        Console.WriteLine(t2.IsValueType);          //False String is RefType
    }
}


