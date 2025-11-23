// implement a doubly linked list here
using System;
public class DoublyLinkedList
{
  public DoublyNode? Head { get; set; }
  public DoublyNode? Tail { get; set; }
  public int Length { get; set; }

  public DoublyLinkedList()
  {
    Head = null;
    Tail = null;
    Length = 0;
  }

  public DoublyLinkedList(int value)
  {
    var newNode = new DoublyNode(value);
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

  public DoublyLinkedList Push(int value)
  {
    var newNode = new DoublyNode(value);
    if (Head == null)
    {
      Head = newNode;
      Tail = newNode;
    }
    else
    {
      Tail!.Next = newNode;
      newNode.Prev = Tail;
      Tail = newNode;
    }
    Length++;
    return this;
  }
  public DoublyNode? Pop()
  {
    if (Head == null) return null;

    var temp = Tail;

    if (Length == 1)
    {
      Head = null;
      Tail = null;
    }
    else
    {
      Tail = Tail!.Prev;
      Tail!.Next = null;
      temp!.Prev = null;
    }

    Length--;
    return temp;
  }
}