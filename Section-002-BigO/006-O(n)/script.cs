using System;

void LogItems(int n)
{
  for (int i = 0; i < n; i++)
  {
    Console.WriteLine(i);
  }
}

LogItems(10);

// NOTE: Run this via dotnet-script script.cs