using Microsoft.EntityFrameworkCore;
using ShopApplication.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApplication.DataAccess.Concrete.EfCore
{
    //DbContext'i eklemek için nuget'tan entityframeworkcore paketini yükle sürümünün başta açtığına uygun olmasına dikkat et! (3.1.0)

    public class ShopContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ShopDb;integrated security=true;");
        }
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
