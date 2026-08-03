using System;
using System.Collections.Generic;

namespace ConjectureGoldbach
{
  internal class Program
  {
    static void Main()
    {
      int n = 98;//int.Parse(Console.ReadLine());
      if (n <= 2 )
      {
        n = 4;
      }

      if (n % 2 != 0)
      {
        n++;
      }

      List<Tuple<int, int>> pairs = new List<Tuple<int, int>>();
      for (int i = 2; i <= n / 2; i++)
      {
        if (IsPrime(i) && IsPrime(n - i))
        {
          pairs.Add(new Tuple<int, int>(i, n - i));
        }
      }

      Console.WriteLine($"Goldbach's conjecture for {n}:");
      foreach (var pair in pairs)
      {
        Console.WriteLine($"{pair.Item1} + {pair.Item2} = {n}");
      }

      Console.WriteLine("Press any key to exit...");
      Console.ReadKey();
    }

    private static bool IsPrime(int i)
    {
      if (i <= 1) return false;
      int sqrt = (int)Math.Sqrt(i);
      for (int j = 2; j <= sqrt; j++)
      {
        if (i % j == 0) return false;
      }

      return true;
    }
  }
}
