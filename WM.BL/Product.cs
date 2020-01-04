using System;
using System.Collections.Generic;

namespace WM.BL
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }

        public Product Retrieve()
        {
            return new Product(); 
        }
        public List<Product> RetriveAll()
        {
            var products = new List<Product>();
            return products;
        }
    }

}
