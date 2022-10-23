using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculation cal = new Calculation(10, 5);
            Assert.AreEqual(15, cal.Execute("+"));
            Assert.AreEqual(5, cal.Execute("-"));
            Assert.AreEqual(50, cal.Execute("*"));
            Assert.AreEqual(2, cal.Execute("/"));
        }
    }
}
