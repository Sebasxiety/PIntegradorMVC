using PIntegradorMVC.Models;

namespace PIntegradorMVC.Services
{
    public interface IDispositivoService
    {
        Task<IEnumerable<Dispositivo>> GetAllAsync();
        Task<Dispositivo?> GetByIdAsync(int id);
        Task<Dispositivo> CreateAsync(Dispositivo dispositivo);
        Task UpdateAsync(Dispositivo dispositivo);
        Task DeleteAsync(int id);
    }
}
