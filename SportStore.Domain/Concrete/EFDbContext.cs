using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SportStore.Domain.Entities;
using System.Data.Entity;

namespace SportStore.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
