using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation cal;
        public TestContext TestContext { get; set; }
        [TestInitialize]
        public void SetUp()
        {
            this.cal = new Calculation(10, 5);
        }
        [
      TestMethod]
        public void TestAddOperator()
        {
            Assert.AreEqual(cal.Execute("+"), 15);
        }
        [
      TestMethod]
        public void TestSubOperator()
        {
            Assert.AreEqual(cal.Execute("-"), 5);
        }
        [
      TestMethod]
        public void TestMulOperator()
        {
            Assert.AreEqual(cal.Execute("*"), 50);
        }
        [TestMethod]
        public void TestDivOperator()
        {
            Assert.AreEqual(cal.Execute("/"), 2);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivByZero()
        {
            Calculation c = new Calculation(2, 0);
            c.Execute("/");
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
@".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        public void TestWithDataSource()
        {
            Calculation c;
            int a, b, expected;
            string operation;
            a = int.Parse(TestContext.DataRow[0].ToString());
            b = int.Parse(TestContext.DataRow[1].ToString());
            operation = TestContext.DataRow[2].ToString();
            operation = operation.Remove(0, 1);
            expected = int.Parse(TestContext.DataRow[3].ToString());
            c = new Calculation(a, b);
            Assert.AreEqual(expected, c.Execute(operation));
        }

        //[TestMethod]
        //public void TestHamSoSanhHon()
        //{
        //    Calculation c;
        //    int a, b, expected;
        //    int actual;
        //    a = 2;
        //    b = 1;
        //    expected = 1;
        //    c = new Calculation(a, b);
        //    actual = c.SoSanh(a, b);
        //    Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void TestHamSoSanhBe()
        //{
        //    Calculation c;
        //    int a, b, expected;
        //    int actual;
        //    a = 1;
        //    b = 2;
        //    expected = -1;
        //    c = new Calculation(a, b);
        //    actual = c.SoSanh(a, b);
        //    Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void TestHamSoSanhBang()
        //{
        //    Calculation c;
        //    int a, b, expected;
        //    int actual;
        //    a = 1;
        //    b = 1;
        //    expected = 0;
        //    c = new Calculation(a, b);
        //    actual = c.SoSanh(a, b);
        //    Assert.AreEqual(expected, actual);
        //}

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
@".\Data\TestDataSoSanh.csv", "TestDataSoSanh#csv", DataAccessMethod.Sequential)]
        public void TestHamSoSanh()
        {
            Calculation c;
            int a, b, expected;
            int actual;
            a = int.Parse(TestContext.DataRow[0].ToString());
            b = int.Parse(TestContext.DataRow[1].ToString());
            expected = int.Parse(TestContext.DataRow[2].ToString());
            c = new Calculation(a, b);
            actual = c.SoSanh(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
