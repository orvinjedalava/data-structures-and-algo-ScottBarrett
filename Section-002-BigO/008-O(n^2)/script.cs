using System;

void LogItems(int n)
{
  for (int i = 0; i < n; i++)
  {
    for (int j = 0; j < n; j++)
    {
      Console.WriteLine($"{i} {j}");
    }
  }
}

LogItems(10);