using Microsoft.EntityFrameworkCore;
using PIntegradorMVC.Models;

namespace PIntegradorMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Dispositivo> Dispositivos { get; set; }
        public DbSet<OrdenServicio> OrdenesServicio { get; set; }
        public DbSet<Repuesto> Repuestos { get; set; }
    }
}
