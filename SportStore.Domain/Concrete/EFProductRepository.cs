using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SportStore.Domain.Abstract;
using SportStore.Domain.Entities;

namespace SportStore.Domain.Concrete
{
 
        public class EFProductRepository : IProductRepository
        {
            private EFDbContext context = new EFDbContext();
            public IQueryable<Product> Products
            {
                get { return context.Products; }
            }
        }
    
}
