using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WM.BL;
namespace WMTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void Retrieve_Product_Test()
        {
            //arr
            var productRepository = new ProductRepository();
            var expected = new Product()
            {
                Id = 1,
                ProductName = "Milk"
            
            };
            //act
            var actual = productRepository.Retrieve();
            //
            Assert.AreEqual(expected.Id, actual.Id);
            Assert.AreEqual(expected.ProductName, actual.ProductName);

        }
    }
}
