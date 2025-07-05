using PIntegradorMVC.Models;

namespace PIntegradorMVC.Services
{
    public interface IOrdenServicioService
    {
        Task<IEnumerable<OrdenServicio>> GetAllAsync();
        Task<OrdenServicio?> GetByIdAsync(int id);
        Task<OrdenServicio> CreateAsync(OrdenServicio orden);
        Task UpdateAsync(OrdenServicio orden);
        Task DeleteAsync(int id);
    }
}
