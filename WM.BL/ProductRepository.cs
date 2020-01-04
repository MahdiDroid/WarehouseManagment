using System;
using System.Collections.Generic;
using System.Text;

namespace WM.BL
{
    public class ProductRepository
    {
        public Product Retrieve()
        {
            var product = new Product()
            {
                Id = 1,
                ProductName = "Milk"
            };

            return product;
        }
        public List<Product> RetriveAll()
        {
            var products = new List<Product>();
            return products;
        }
    }
}
