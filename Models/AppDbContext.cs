using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PoshFoods.Models;

namespace PoshFoods.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Branch> Branch { get; set; }
        public DbSet<Employee> Emoloyee { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<PoshFoods.Models.ContactUs> ContactUs { get; set; }

    }

}
