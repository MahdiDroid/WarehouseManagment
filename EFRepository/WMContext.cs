using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMBLib;

using System.Data.Entity;

namespace EFRepository
{
     internal class WMContext :DbContext 
    {
        public DbSet<Product> Products { get; set; }
    }
}
