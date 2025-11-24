using System;

namespace CodingExercises.Models
{
  public class Stack<T>
  {
    private T[] _items;
    private int _top;
    private const int DefaultCapacity = 10;

    public Stack() : this(DefaultCapacity)
    {
    }

    public Stack(int capacity)
    {
      if (capacity < 0)
        throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity cannot be negative");

      _items = new T[capacity];
      _top = -1;
    }

    public int Count => _top + 1;

    public bool IsEmpty => _top == -1;

    public void Push(T item)
    {
      if (_top == _items.Length - 1)
      {
        Resize();
      }

      _items[++_top] = item;
    }

    public T Pop()
    {
      if (IsEmpty)
        throw new InvalidOperationException("Stack is empty");

      T item = _items[_top];
      _items[_top--] = default(T)!;
      return item;
    }

    public T Peek()
    {
      if (IsEmpty)
        throw new InvalidOperationException("Stack is empty");

      return _items[_top];
    }

    public void Clear()
    {
      Array.Clear(_items, 0, _items.Length);
      _top = -1;
    }

    private void Resize()
    {
      int newCapacity = _items.Length * 2;
      T[] newArray = new T[newCapacity];
      Array.Copy(_items, newArray, _items.Length);
      _items = newArray;
    }
  }
}