using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FiboTest
{
    [TestClass]
    public class FiboUnitTest
    {
        FiboSvc.FSvc mySvc = new FiboSvc.FSvc();

        [TestMethod]
        public void FiboTestTestMethod1()
        {
            Assert.AreEqual(mySvc.Fibonacci(10), 55);
        }

        [TestMethod]
        public void FiboTestTestMethod2()
        {
            Assert.AreEqual(mySvc.Fibonacci(0), -1);
        }

        [TestMethod]
        public void FiboTestTestMethod3()
        {
            Assert.AreEqual(mySvc.Fibonacci(1), 1);
        }

        [TestMethod]
        public void FiboTestTestMethod4()
        {
            Assert.AreEqual(mySvc.FibonacciJSON(10), "55");
        }

        [TestMethod]
        public void FiboTestTestMethod5()
        {
            Assert.AreEqual(mySvc.FibonacciJSON(0), "-1");
        }

        [TestMethod]
        public void FiboTestTestMethod6()
        {
            Assert.AreEqual(mySvc.FibonacciJSON(1), "1");
        }
    }
}
