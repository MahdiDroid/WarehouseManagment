using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMBLib;

namespace EFRepository.Repositories
{
    class ProductRepository : WMBLib.Repositories.IProductRepository
    {
        public void Add(Product entity)
        {
            using (var context = new WMContext())
            {              
                context.Products.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (var context = new WMContext())
            {
                context.Products.(entity);
                context.SaveChanges();
            }

        }

        public List<Product> RetrieveAll()
        {
            throw new NotImplementedException();
        }

        public Product RetrieveById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
