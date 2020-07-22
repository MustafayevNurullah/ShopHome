

using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using ShopHome.Entity;

namespace ShopHome.Repository.Concrete.EntityFramework
{
    public class ShopHomeContext : DbContext
    {
        public ShopHomeContext(DbContextOptions<ShopHomeContext> options) 
            : base(options)
        {
        }

        public DbSet<Product> Products{get;set;}
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Sliders> Sliders { get; set; }
        public DbSet<discount_of_the_day> Discount_Of_The_Days { get; set; }
        public DbSet<Fixed_photo> Fixed_Photos { get; set; }
        public DbSet<last_15_sold> Last_15_Solds { get; set; }
        public DbSet<Offers> Offers { get; set; }
        public DbSet<Slider> Slider { get; set; }
        public DbSet<Today_is_offer> Today_Is_Offers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }
    }
}
