using System;

class Node
{
    public int data;
    public Node next;

    public Node(int d, Node n) { data d, next = n; }

}

class IntLinkedList : IEnumerable
{
    public Node head = null;

    public void AddFirst(int data)
    {
        head = new Node(data, head);
    }

    // public IEnumerator GetEnumerator()
    // {
    //     //열거자를 반환한다.
    //     return new 열거자;
    // }
}

class Program
{
    public static void Main()
    {
        IntLinkedList st = new IntLinkedList();

        st.AddFirst(10);
        st.AddFirst(20);
        st.AddFirst(30);
        st.AddFirst(40);
        st.AddFirst(50);

        IEnumerator e = st.GetEnumerator();

        while (e.MoveNext())
        {
            Console.WriteLine(e.Current);
        }
    }
}