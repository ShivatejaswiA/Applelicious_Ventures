//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;
//using Applelicious_Ventures.Models;

//namespace Applelicious_Ventures.Data
//{
//  public class ApplicationDbContext : IdentityDbContext
//{
//  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
//    : base(options)
//{
//}
//public DbSet<Applelicious_Ventures.Models.Apple> Apple { get; set; } = default!;
//}
//}
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Applelicious_Ventures.Models;

namespace Applelicious_Ventures.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Apple> Apple { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the Price property of the Apple entity
            modelBuilder.Entity<Apple>()
                .Property(a => a.Price)
                .HasColumnType("decimal(18, 4)"); // Specify the desired precision and scale
        }
    }
}
