using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using MuseuAPI.Repositories.Interfaces;
using MuseuAPI.Entities;
using MuseuAPI.Data;

namespace MuseuAPI.Repositories
{
    public class ObraRepository : IObraRepository
    {
        private readonly AppDbContext _context;

        public ObraRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Obra>> GetAllAsync()
        {
            return await _context.Obras.ToListAsync();
        }

        public async Task<Obra> GetByIdAsync(int id)
        {
            return await _context.Obras.FindAsync(id);
        }

        public async Task<Obra> AddAsync(Obra obra)
        {
            _context.Obras.Add(obra);
            await _context.SaveChangesAsync();
            return obra;
        }

        public async Task UpdateAsync(Obra obra)
        {
            _context.Obras.Update(obra);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Obra obra)
        {
            _context.Obras.Remove(obra);
            await _context.SaveChangesAsync();
        }
    }
}
