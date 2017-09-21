using CoreWebApi.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CoreWebApiTests
{
   [TestClass]
   public class FibonacciServiceTest
   {
      [TestMethod]
      public void Calculate1()
      {
         var fibonacciService = new FibonacciService();
         Assert.AreEqual(1, fibonacciService.Calculate(1));
      }

      [TestMethod]
      [ExpectedException(typeof(ArgumentException))]
      public void Calculate2()
      {
         var fibonacciService = new FibonacciService();
         fibonacciService.Calculate(-3);
      }

      [TestMethod]
      public void Calculate8()
      {
         var fibonacciService = new FibonacciService();
         Assert.AreEqual(21, fibonacciService.Calculate(8));
      }
   }
}
