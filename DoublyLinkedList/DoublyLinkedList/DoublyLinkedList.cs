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
            tail = newNode;  // era el último, actualizar tail

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

    public void PrintBackward()
    {
        DoubleNode<T> current = tail;
        while (current != null)
        {
            Console.Write(current.Data + " <-> ");
            current = current.Prev;
        }
        Console.WriteLine("null");
    }

    public void SortDescending()
    {
        if (head == null || head == tail) return;

        DoubleNode<T> current = head;
        DoubleNode<T> temp = null;

        while (current != null)
        {
            temp = current.Next;
            current.Next = current.Prev;
            current.Prev = temp;
            current = temp;
        }

        //intercambiar head y tail
        temp = head;
        head = tail;
        tail = temp;
    }

    public void ShowMode()
    {
        if (head == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        Dictionary<T, int> conteo = new Dictionary<T, int>();
        DoubleNode<T> current = head;

        while (current != null)
        {
            if (conteo.ContainsKey(current.Data))
                conteo[current.Data]++;
            else
                conteo[current.Data] = 1;

            current = current.Next;
        }

        int max = 0;
        foreach (var par in conteo)
            if (par.Value > max)
                max = par.Value;
        Console.Write("Moda(s): ");
        foreach (var par in conteo)
            if(par.Value == max)
                Console.Write(par.Key + ", ");

        Console.WriteLine($"\n(Se repite(n) {max} veces)");
    }

    public void ShowGraph()
    {
        if (head == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        Dictionary<T, int> conteo = new Dictionary<T, int>();
        DoubleNode<T> current = head;

        while (current != null)
        {
            if (conteo.ContainsKey(current.Data))
                conteo[current.Data]++;
            else
                conteo[current.Data] = 1;
            current = current.Next;
        }

        foreach (var par in conteo)
        {
            Console.Write(par.Key + "\t");
            for (int i = 0; i < par.Value; i++)
                Console.Write("*");
            Console.WriteLine();
        }
    }

    public bool Exists(T data)
    {
        DoubleNode<T> current = head;

        while (current != null)
        {
            if (current.Data.Equals(data))
                return true;
            current = current.Next;
        }
        return false;
    }
}
        

       

