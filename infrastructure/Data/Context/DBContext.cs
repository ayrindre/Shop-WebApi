using System;
using Microsoft.EntityFrameworkCore;
using infrastructure.Data.Entities;

namespace infrastructure.Data.Context
{
    public class Context : DbContext
    {
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Color> colors { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<MoreImage> MoreImages { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder db)
        {
            db.UseSqlServer("Data source =. ; initial Catalog = Shop ; integrated Security = true ;");
        }
        
    }
}