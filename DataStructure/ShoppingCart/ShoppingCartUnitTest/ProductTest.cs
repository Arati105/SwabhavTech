using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartLib.Model;
using System;

namespace ShoppingCartLibTest
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Product p = new Product(101, "Laptop", 200, 0.5f);
            Assert.AreEqual<int>(p.Id, 101);
            Assert.AreEqual<string>(p.Name, "Laptop");
            Assert.AreEqual<double>(p.Price, 200);
            Assert.AreEqual<float>(p.Discount, 0.5f);
        }
    }
}