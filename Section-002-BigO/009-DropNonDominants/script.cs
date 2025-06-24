using System;

// Drop Non-Dominants is a simple way to simplify Big O notation 
// by removing the less significant terms in a function's time complexity.

// instead of O(n^2 + n), we can simplify it to O(n^2)
void LogItems(int n)
{
  for (int i = 0; i < n; i++)
  {
    for (int j = 0; j < n; j++)
    {
      Console.WriteLine($"{i} {j}");
    }
  }

  // we can drop this loop in the notation since this is a non-dominant term
  for (int k = 0; k < n; k++)
  {
    Console.WriteLine(k);
  }
}

LogItems(10);