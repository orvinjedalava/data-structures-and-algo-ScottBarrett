using System;
using System.Text.Json;

var linkedList = new LinkedListObject(7);
linkedList.Push(4);

linkedList.PrintList();

var linkedListPop = new LinkedListObject(7);
linkedListPop.Push(4);
linkedListPop.PrintList();

var popped = linkedListPop.Pop();
linkedListPop.PrintList();
Console.WriteLine($"Popped value: {popped.Value}");

popped = linkedListPop.Pop();
linkedListPop.PrintList();
Console.WriteLine($"Popped value: {popped.Value}");

Console.ReadLine();

public class LinkedListObject
{
  public LinkedListObject(int value)
  {
    var node = new Node(value);
    this.Head = node;
    this.Tail = this.Head;
    this.Length = 1;
  }

  public Node Head { get; set; }
  public Node Tail { get; set; }
  public int Length { get; private set; }

  public void PrintList()
  {
    Console.WriteLine(JsonSerializer.Serialize(this));
  }

  public LinkedListObject Push(int value)
  {
    var newNode = new Node(value);
    if (this.Head == null)
    {
      this.Head = newNode;
      this.Tail = newNode;
    }
    else
    {
      this.Tail.Next = newNode;
      this.Tail = newNode;
    }
    this.Length++;

    return this;
  }

  public Node Pop()
  {
    if (this.Head == null)
    {
      return null;
    }

    var temp = this.Head;
    var pre = this.Head;

    while (temp.Next != null)
    {
      pre = temp;
      temp = temp.Next;
    }
    this.Tail = pre;
    this.Tail.Next = null;
    this.Length--;

    if (this.Length == 0)
    {
      this.Head = null;
      this.Tail = null;
    }

    return temp;
  }



}

public class Node
{
  public Node(int value)
  {
    this.Value = value;
    this.Next = null;
  }

  public int Value { get; private set; }
  public Node Next { get; set; }
}

