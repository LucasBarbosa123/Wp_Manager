using Microsoft.EntityFrameworkCore;
using WP_Manager.Models;

namespace Models
{
    public class WpManagerDbContext : DbContext
    {
        public WpManagerDbContext(DbContextOptions<WpManagerDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}