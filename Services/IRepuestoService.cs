using PIntegradorMVC.Models;

namespace PIntegradorMVC.Services
{
    public interface IRepuestoService
    {
        Task<IEnumerable<Repuesto>> GetAllAsync();
        Task<Repuesto?> GetByIdAsync(int id);
        Task<Repuesto> CreateAsync(Repuesto repuesto);
        Task UpdateAsync(Repuesto repuesto);
        Task DeleteAsync(int id);
    }
}
