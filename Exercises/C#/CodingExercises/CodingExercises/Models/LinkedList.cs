using CodingExercises.Models;
using System;

public class LinkedList
{
    public Node Head { get; private set; }
    public Node Tail { get; private set; }
    public int Length { get; private set; }

    public LinkedList(int value)
    {
        var newNode = new Node(value);
        Head = newNode;
        Tail = Head;
        Length = 1;
    }

    public void PrintList()
    {
        var currentNode = Head;
        while (currentNode != null)
        {
            Console.WriteLine(currentNode.Value);
            currentNode = currentNode.Next;
        }
    }

    public LinkedList Push(int value)
    {
        var newNode = new Node(value);
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail.Next = newNode;
            Tail = newNode;
        }
        Length++;
        return this;
    }

    public Node Pop()
    {
        if (Head == null) return null;

        var temp = Head;
        var pre = Head;

        while (temp.Next != null)
        {
            pre = temp;
            temp = temp.Next;
        }
        Tail = pre;
        Tail.Next = null;
        Length--;
        if (Length == 0)
        {
            Head = null;
            Tail = null;
        }

        return temp;
    }

    public LinkedList Unshift(int value)
    {
        var newNode = new Node(value);
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            newNode.Next = Head;
            Head = newNode;
        }

        Length++;
        return this;
    }

    public Node Shift()
    {
        if (Head == null) return null;

        var temp = Head;
        Head = Head.Next;
        temp.Next = null; // Clear the next pointer of the removed node
        Length--;
        if (Length == 0)
        {
            Tail = null;
        }
        return temp;
    }

    public Node Get(int index)
    {
        if (index < 0 || index >= Length) return null;

        var temp = Head;
        for (int i = 0; i < index; i++)
        {
            temp = temp.Next;
        }

        return temp;
    }

    public bool Set(int index, int value)
    {
        var temp = Get(index);
        if (temp != null)
        {
            temp.Value = value;
            return true;
        }

        return false;
    }

    public bool Insert(int index, int value)
    {
        if (index < 0 || index > Length) return false;

        if (index == 0)
        {
            Unshift(value);
            return true;
        }
        if (index == Length)
        {
            Push(value);
            return true;
        }

        var newNode = new Node(value);
        var temp = Get(index - 1);
        newNode.Next = temp.Next;
        temp.Next = newNode;
        Length++;
        return true;
    }

    public Node Remove(int index)
    {
        if (index < 0 || index >= Length) return null;

        if (index == 0)
        {
            return Shift();
        }

        if (index == Length - 1)
        {
            return Pop();
        }

        var before = Get(index - 1);
        var temp = before.Next;
        before.Next = temp.Next;
        temp.Next = null;
        Length--;
        return temp;
    }

    public LinkedList Reverse()
    {
        var temp = Head;
        Head = Tail;
        Tail = temp;

        Node next = temp.Next;
        Node prev = null;

        for (int i = 0; i < Length; i++)
        {
            next = temp.Next;
            temp.Next = prev;

            prev = temp;
            temp = next;
        }

        return this;
    }
}