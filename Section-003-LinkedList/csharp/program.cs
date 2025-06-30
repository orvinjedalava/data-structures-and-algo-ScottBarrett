using System;
using System.Text.Json;

var linkedList = new LinkedListObject(7);
linkedList.Push(4);
Console.WriteLine(JsonSerializer.Serialize(linkedList));

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
    Console.WriteLine(this);
    Node currentNode = this.Head;
    while (currentNode != null)
    {
      Console.WriteLine(currentNode.Value);
      currentNode = currentNode.Next;
    }
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

    return this;
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

