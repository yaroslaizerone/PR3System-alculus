using Microsoft.VisualStudio.TestTools.UnitTesting;
using PR3SystemСalculus;
using System;

namespace UnitTestSystemCalculs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculus c = new Calculus();

            Assert.AreEqual("7E7", c.Calc(16, "2023"));
            Assert.AreEqual("3747", c.Calc(8, "2023"));
            Assert.AreEqual("11111100111", c.Calc(2, "2023"));
        }
    }
}
