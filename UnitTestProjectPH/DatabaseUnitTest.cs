using DomainLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestProjectPH
{
    [TestClass]
    public class DatabaseUnitTest
    {
        [TestInitialize]
        public void SetUpTest()
        {

        }

        [TestMethod]
        public void CanGenerateGUIDKey()
        {
            string key;
            string key1;
            key = DatabaseLayer.KeyGenerator1.Instance.NextKey;
            key1 = DatabaseLayer.KeyGenerator1.Instance.NextKey;

            Assert.AreNotEqual(key, key1);

        }
        [TestMethod]
        public void CanGiveProductKey()
        {
            Product newProd = new Product("Hårbørste", 22, "Stålhåndtag", 26);
            newProd.ProductId = DatabaseLayer.KeyGenerator1.Instance.NextKey;
        }
    }
}
