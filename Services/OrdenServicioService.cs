using Microsoft.EntityFrameworkCore;
using PIntegradorMVC.Data;
using PIntegradorMVC.Models;

namespace PIntegradorMVC.Services
{
    public class OrdenServicioService : IOrdenServicioService
    {
        private readonly ApplicationDbContext _context;

        public OrdenServicioService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<OrdenServicio> CreateAsync(OrdenServicio orden)
        {
            _context.OrdenesServicio.Add(orden);
            await _context.SaveChangesAsync();
            return orden;
        }

        public async Task DeleteAsync(int id)
        {
            var orden = await _context.OrdenesServicio.FindAsync(id);
            if (orden != null)
            {
                _context.OrdenesServicio.Remove(orden);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<OrdenServicio>> GetAllAsync()
        {
            return await _context.OrdenesServicio.ToListAsync();
        }

        public async Task<OrdenServicio?> GetByIdAsync(int id)
        {
            return await _context.OrdenesServicio.FindAsync(id);
        }

        public async Task UpdateAsync(OrdenServicio orden)
        {
            _context.OrdenesServicio.Update(orden);
            await _context.SaveChangesAsync();
        }
    }
}
