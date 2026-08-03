using System;
using System.Collections.Generic;

namespace ConjectureGoldbach
{
  internal class Program
  {
    static void Main()
    {
      var result = new Dictionary<int, List<Tuple<int, int>>>();
      //int n = 4;
      for (int n = 4; n <= 10_000; n += 2)
      {
        var pairs = new List<Tuple<int, int>>();
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

        result[n] = pairs;
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
