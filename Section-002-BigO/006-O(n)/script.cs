using System;

public class Program
{
  public static void LogItems(int n)
  {
    for (int i = 0; i < n; i++)
    {
      Console.WriteLine(i);
    }
  }

}


Program.LogItems(10);

// NOTE: Run this via dotnet-script script.cs