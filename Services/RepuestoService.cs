using Microsoft.EntityFrameworkCore;
using PIntegradorMVC.Data;
using PIntegradorMVC.Models;

namespace PIntegradorMVC.Services
{
    public class RepuestoService : IRepuestoService
    {
        private readonly ApplicationDbContext _context;

        public RepuestoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Repuesto> CreateAsync(Repuesto repuesto)
        {
            _context.Repuestos.Add(repuesto);
            await _context.SaveChangesAsync();
            return repuesto;
        }

        public async Task DeleteAsync(int id)
        {
            var repuesto = await _context.Repuestos.FindAsync(id);
            if (repuesto != null)
            {
                _context.Repuestos.Remove(repuesto);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Repuesto>> GetAllAsync()
        {
            return await _context.Repuestos.ToListAsync();
        }

        public async Task<Repuesto?> GetByIdAsync(int id)
        {
            return await _context.Repuestos.FindAsync(id);
        }

        public async Task UpdateAsync(Repuesto repuesto)
        {
            _context.Repuestos.Update(repuesto);
            await _context.SaveChangesAsync();
        }
    }
}
