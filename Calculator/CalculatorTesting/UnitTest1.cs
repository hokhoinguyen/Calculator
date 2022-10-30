using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTesting
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        public void TestCong()
        {
            Cal cal = new Cal(10 , 5);
            Assert.AreEqual(15, cal.Execute("+"));
        }//

        [TestMethod]
        public void TestTru()
        {
            Cal cal = new Cal(10, 5);
            Assert.AreEqual(5, cal.Execute("-"));
        }

        [TestMethod]
        public void TestNhan()
        {
            Cal cal = new Cal(10, 5);
            Assert.AreEqual(50, cal.Execute("*"));
        }

        [TestMethod]
        public void TestChia()
        {
            Cal cal = new Cal(10, 5);
            Assert.AreEqual(2, cal.Execute("/"));
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivByZero()
        {
            Cal cal = new Cal(2, 0);
            cal.Execute("/");
        }
        [DataSource ("Microsoft.VisualStudio.TestTools.DataSource.CSV", 
                     @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSource()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            string operation = TestContext.DataRow[2].ToString();
            operation = operation.Remove(0, 1);
            int expected = int.Parse(TestContext.DataRow[3].ToString());
            Cal c = new Cal(a, b);
            Assert.AreEqual(expected, c.Execute(operation));
        }
        [TestMethod]
        public void TestHamSoSanh()
        {
            Cal c;
            int actual;
            int a, b, expected;
            a = 3;
            b = 2;
            expected = 1;
            c = new Cal(a, b);
            actual = c.SoSanh(a, b);
            Assert.AreEqual(expected, actual);
        }
    }

}
