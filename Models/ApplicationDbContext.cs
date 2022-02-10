using Microsoft.EntityFrameworkCore;

namespace CoreRESTAPI.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        
        public DbSet<Order> Orders { get; set; }
    }
}