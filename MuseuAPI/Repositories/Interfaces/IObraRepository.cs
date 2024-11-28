using System.Collections.Generic;
using System.Threading.Tasks;
using MuseuAPI.Entities;

namespace MuseuAPI.Repositories.Interfaces
{
    public interface IObraRepository
    {
        Task<IEnumerable<Obra>> GetAllAsync();
        Task<Obra> GetByIdAsync(int id);
        Task<Obra> AddAsync(Obra obra);
        Task UpdateAsync(Obra obra);
        Task DeleteAsync(Obra obra);
    }
}
