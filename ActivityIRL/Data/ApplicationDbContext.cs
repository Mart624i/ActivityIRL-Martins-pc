
using ActivityIRL.Models;
using Microsoft.EntityFrameworkCore;

namespace ActivityIRL.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {

        }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=YourServer; Database=YourDb; " +
                    "Integrated Security=true; MultipleActiveResultSets=true; " +
                    "Trusted_Connection=True");
            }
        }*/

        public DbSet<User>? UserItems { get; set; } = null;

        public DbSet<Event>? EventItems { get; set; } = null;

        public DbSet<Comment>? CommentItems { get; set; } = null;

    }
}
