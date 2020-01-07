using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WM.BL.Repositories
{
    public class ProductRepository :IRepository<Product>
    {
        private List<Product> products;
        public Product RetrieveById(int id)
        {
            return products.SingleOrDefault(p => p.Id==id);
        }
        public List<Product> RetrieveAll()
        { 
            return products;
        }
        public void Add(Product product)
        {
            products.Add(product);
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
