using System;
using System.Collections;
using System.Collections.Generic;


class Node
{
    public int data;
    public Node next;

    public Node(int d, Node n) { data = d; next = n; }

}

class IntLinkedListEnumerator : IEnumerator
{
    public Node head = null;
    public Node current = null;
    public IntLinkedListEnumerator(Node n) { head = n; }

    public object Current => current.data;
    public bool MoveNext()
    {
        if (current == null)
        {
            current = head;
        }
        else
        {
            current = current.next;
        }
        return current != null;
    }

    public void Reset()
    {
        current = null;
    }

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
        return new IntLinkedListEnumerator(head);
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