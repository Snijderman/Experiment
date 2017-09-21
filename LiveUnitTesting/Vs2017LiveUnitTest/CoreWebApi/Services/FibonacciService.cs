using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Services
{
   public class FibonacciService
   {
      public int Calculate(int n)
      {
         if (n < 0)
            throw new ArgumentException("Less negativity please!", nameof(n));

         #region C# 7 
         //return Fib(n).current;

         //(int current, int previous) Fib(int i)
         //{
         //   if (i == 0) return (1, 0);
         //   var (p, pp) = Fib(i - 1);
         //   return (p + pp, p);
         //}
         #endregion

         var fibonacci = new int[n + 1];
         fibonacci[0] = 0;
         fibonacci[1] = 1;

         for (var i = 2; i <= n; i++)
         {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
         }

         return fibonacci[n];
      }
   }
}
