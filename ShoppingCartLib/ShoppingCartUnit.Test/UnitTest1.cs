using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartLib.Model;

namespace ShoppingCartUnit.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ProductMethod()
        {
            Product p = new Product(101,"Laptop",500,.50f);
            Assert.AreEqual<int>(p.Id, 101);
            Assert.AreEqual<string>(p.Name, "Laptop");
            Assert.AreEqual<double>(p.Price, 500);
            Assert.AreEqual<float>(p.Discount, .50f);
        }
    }

    
}
