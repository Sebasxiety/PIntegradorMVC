using Microsoft.EntityFrameworkCore;

namespace PIntegradorMVC.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // DbSet properties go here
    }
}
