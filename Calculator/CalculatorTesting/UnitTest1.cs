using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTesting
{
    [TestClass]
    public class UnitTest1
    {
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
    }
}
