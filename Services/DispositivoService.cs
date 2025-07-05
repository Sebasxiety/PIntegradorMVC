using Microsoft.EntityFrameworkCore;
using PIntegradorMVC.Data;
using PIntegradorMVC.Models;

namespace PIntegradorMVC.Services
{
    public class DispositivoService : IDispositivoService
    {
        private readonly ApplicationDbContext _context;

        public DispositivoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Dispositivo> CreateAsync(Dispositivo dispositivo)
        {
            _context.Dispositivos.Add(dispositivo);
            await _context.SaveChangesAsync();
            return dispositivo;
        }

        public async Task DeleteAsync(int id)
        {
            var dispositivo = await _context.Dispositivos.FindAsync(id);
            if (dispositivo != null)
            {
                _context.Dispositivos.Remove(dispositivo);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Dispositivo>> GetAllAsync()
        {
            return await _context.Dispositivos.ToListAsync();
        }

        public async Task<Dispositivo?> GetByIdAsync(int id)
        {
            return await _context.Dispositivos.FindAsync(id);
        }

        public async Task UpdateAsync(Dispositivo dispositivo)
        {
            _context.Dispositivos.Update(dispositivo);
            await _context.SaveChangesAsync();
        }
    }
}
