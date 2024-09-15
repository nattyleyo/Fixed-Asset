using Microsoft.EntityFrameworkCore;
using FixedAsset.Models;

namespace FixedAsset.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Define DbSet for your Users entity
        public DbSet<Users> Users { get; set; }
    }
}
