using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using webService_challenge.Controllers;

namespace webServiceTEST
{
    [TestClass]
    public class FibonacciControllerTest
    {
        [TestMethod]
        public void testGoodFibonacciValue1()
        {
            int fibonacciResult = FibonacciController.Fibonacci_Iterative(1);
            Assert.AreEqual(1, fibonacciResult);

        }

        [TestMethod]
        public void testGoodFibonacciValue2()
        {
            int fibonacciResult = FibonacciController.Fibonacci_Iterative(2);
            Assert.AreEqual(1, fibonacciResult);

        }
        [TestMethod]
        public void testGoodFibonacciValue3()
        {
            int fibonacciResult = FibonacciController.Fibonacci_Iterative(3);
            Assert.AreEqual(2, fibonacciResult);

        }
        [TestMethod]
        public void testGoodFibonacciValue4()
        {
            int fibonacciResult = FibonacciController.Fibonacci_Iterative(4);
            Assert.AreEqual(3, fibonacciResult);

        }
        [TestMethod]
        public void testGoodFibonacciValue5()
        {
            int fibonacciResult = FibonacciController.Fibonacci_Iterative(5);
            Assert.AreEqual(5, fibonacciResult);

        }
        [TestMethod]
        public void testGoodFibonacciValue6()
        {
            int fibonacciResult = FibonacciController.Fibonacci_Iterative(6);
            Assert.AreEqual(8, fibonacciResult);

        }
        [TestMethod]
        public void testBadFibonacciNegative101()
        {
            int fibonacciResult = FibonacciController.Fibonacci_Iterative(-101);
            Assert.AreEqual(-1, fibonacciResult);
        }

        [TestMethod]
        public void testBadFibonacci1000()
        {
            int fibonacciResult = FibonacciController.Fibonacci_Iterative(1000);
            Assert.AreEqual(-1, fibonacciResult);
        }
    }
}
