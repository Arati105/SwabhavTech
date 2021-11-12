using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BasicMathTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AddMethod1()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Add(10, 10);
            Assert.AreEqual(res, 20);
        }
        [TestMethod]
        public void Test_Substract()
        {
            BasicMaths bm = new BasicMaths();
            double ews = bm.Substract(10, 10);
            Assert.AreEqual(ews, 0);

        }
        [TestMethod]
        public void Test_DivideMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.divide(10, 5);
            Assert.AreEqual(res, 0);
        }
        [TestMethod]
        public void Test_MultiplyMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.multiply(10, 10);
            Assert.AreEqual(res, 10);
        }

        private class BasicMaths
        {
            internal double Add(int v1, int v2)
            {
                throw new NotImplementedException();
            }

            internal double divide(int v1, int v2)
            {
                throw new NotImplementedException();
            }

            internal double multiply(int v1, int v2)
            {
                throw new NotImplementedException();
            }

            internal double Substract(int v1, int v2)
            {
                throw new NotImplementedException();
            }
        }
    }

    internal class BasicMath
    {
    }
}
