using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NgoHongThai_ASM.Models
{
    public class DbContextModel : DbContext
    {
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
        public DbContextModel(DbSet<ProductModel> products, DbSet<CategoryModel> categories)
        {
            Products = products;
            Categories = categories;
        }

        public DbContextModel() : base()
        {

        }
    }
}