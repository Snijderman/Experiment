using System;

namespace CoreWebApi.Services
{
   public class FibonacciService
   {
      public int Calculate(int n)
      {
         if (n < 0)
            throw new ArgumentException("Less negativity please!", nameof(n));

         //throw new NotImplementedException();
   
         return Fib(n).current;

         (int current, int previous) Fib(int i)
         {
           if (i == 0) 
            return (1, 0);

           var (p, pp) = Fib(i - 1);
           return (p + pp, p);
         }
      }
   }
}
