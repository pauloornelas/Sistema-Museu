using System.Collections.Generic;
using System.Threading.Tasks;
using MuseuAPI.Entities;

namespace MuseuAPI.Repositories.Interfaces
{
    public interface IQuestionarioRepository
    {
        Task<IEnumerable<Questionario>> GetAllAsync();
        Task<Questionario> GetByIdAsync(int id);
        Task<Questionario> AddAsync(Questionario questionario);
        Task UpdateAsync(Questionario questionario);
        Task DeleteAsync(Questionario questionario);
    }
}
