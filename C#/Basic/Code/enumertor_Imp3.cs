using System;
using System.Collections;
using System.Collections.Generic;


class Node
{
    public int data;
    public Node next;

    public Node(int d, Node n) { data = d; next = n; }

}

class IntLinkedList : IEnumerable
{
    public Node head = null;

    public void AddFirst(int data)
    {
        head = new Node(data, head);
    }

    public IEnumerator GetEnumerator()
    {
        //return new 열거자
        Node current = head;

        while (current != null)
        {
            yield return current.data;

            current = current.next;
        }
    }
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