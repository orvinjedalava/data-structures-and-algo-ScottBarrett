// implement a doubly node here
public class DoublyNode(int value)
{
  public int Value { get; set; } = value;
  public DoublyNode? Next { get; set; } = null;
  public DoublyNode? Prev { get; set; } = null;
}