using Microsoft.EntityFrameworkCore;
using ReactSimple.WebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactSimple.WebApi.Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasMany(i => i.Products);
            modelBuilder.Entity<Product>().HasOne(i => i.Category).WithMany(i => i.Products).HasForeignKey(i => i.CategoryId);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
