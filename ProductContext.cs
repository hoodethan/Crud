using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProductRelationships.Models
{
    public class ProductContext: DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
           : base(options)
        {

        }
        public DbSet<Product> Products { get; set; } //table
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
