using System;

public class Program
{
  public static void LogItems(int n)
  {
    for (int i = 0; i < n; i++)
    {
      Console.WriteLine(i);
    }
    for (int j = 0; j < n; j++)
    {
      Console.WriteLine(j);
    }
  }

}


Program.LogItems(10);

// NOTE: Run this via dotnet-script script.cs