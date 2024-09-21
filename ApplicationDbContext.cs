using Microsoft.EntityFrameworkCore;
using CDNCompleteDeveloperNetwork.Models;

namespace CDNCompleteDeveloperNetwork.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
