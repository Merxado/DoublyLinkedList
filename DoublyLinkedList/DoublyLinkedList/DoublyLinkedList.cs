using System;
using System.Security.Cryptography.X509Certificates;

public class DoublyLinkedList<T> where T : IComparable<T>
{
    private DoubleNode<T> head;
    private DoubleNode<T> tail;

    public DoublyLinkedList()
    {
        head = null;
        tail = null;
    }

    public void Insert(T data)
    {
        DoubleNode<T> newNode = new DoubleNode<T>(data);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
            return;
        }

        if (data.CompareTo(head.Data) <= 0)
        {
            newNode.Next = head;
            head.Prev = newNode;
            head = newNode;
            return;
        }

        DoubleNode<T> current = head;
        while (current.Next != null && current.Next.Data.CompareTo(data) <= 0)
        {
            current = current.Next;
        }

        newNode.Next = current.Next;
        newNode.Prev = current;

        if (current.Next != null)
            current.Next.Prev = newNode; // hay nodo después
        else
            tail = newNode;              // era el último, actualizar tail

        current.Next = newNode;

    }
    public void PrintForward()
    {
        DoubleNode<T> current = head;
        while (current != null)
        {
            Console.Write(current.Data + " <-> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
}

