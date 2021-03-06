using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class IrshhadDbContext : IdentityDbContext<User>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
           
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=IrshhadDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<ParentCategory> ParentCategories { get; set; }
        public DbSet<SecondParentCategory> SecondParentCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPicture> ProductPictures { get; set; }
        public DbSet<Comment> Comments { get; set; } 
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>().ToTable("Users");
            builder.Entity<IdentityRole>().ToTable("Roles");
        }


    }
}
