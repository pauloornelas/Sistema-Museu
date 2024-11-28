using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using MuseuAPI.Repositories.Interfaces;
using MuseuAPI.Entities;
using MuseuAPI.Data;

namespace MuseuAPI.Repositories
{
    public class QuestionarioRepository : IQuestionarioRepository
    {
        private readonly AppDbContext _context;

        public QuestionarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Questionario>> GetAllAsync()
        {
            return await _context.Questionarios.ToListAsync();
        }

        public async Task<Questionario> GetByIdAsync(int id)
        {
            return await _context.Questionarios.FindAsync(id);
        }

        public async Task<Questionario> AddAsync(Questionario questionario)
        {
            _context.Questionarios.Add(questionario);
            await _context.SaveChangesAsync();
            return questionario;
        }

        public async Task UpdateAsync(Questionario questionario)
        {
            _context.Questionarios.Update(questionario);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Questionario questionario)
        {
            _context.Questionarios.Remove(questionario);
            await _context.SaveChangesAsync();
        }
    }
}
