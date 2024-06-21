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
        public DbSet<Applelicious_Ventures.Models.Apple> Apple { get; set; } = default!;
    }
}
