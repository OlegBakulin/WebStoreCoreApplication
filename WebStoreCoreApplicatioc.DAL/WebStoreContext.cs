using System;
using Microsoft.EntityFrameworkCore;
using WebStoreCoreApplication.Domain.Entities;

namespace WebStoreCoreApplicatioc.DAL
{
    public class WebStoreContext : DbContext
    {
        public WebStoreContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
