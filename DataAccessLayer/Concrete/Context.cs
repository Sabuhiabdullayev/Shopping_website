using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ADMIN-ПК; Database=ShoppingDb; Integrated security=true;");
        }



        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Category2> Category2s { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }
        public DbSet<ProductComment> productComments { get; set; }
        public DbSet<OperatorContact> OperatorContacts { get; set; }
        public DbSet<Cart> Carts { get; set; } 
        public DbSet<ProductComplaint> productComplaints { get; set; } 
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Ads> Ads { get; set; }
        public DbSet<ProductLike> ProductLikes { get; set; }
        public DbSet<ProductView> ProductViews { get; set; }
        

    }
}
