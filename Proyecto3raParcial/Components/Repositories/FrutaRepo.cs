using Microsoft.EntityFrameworkCore;
using Proyecto3raParcial.Components.Data;
using Proyecto3raParcial.Components.Models;

namespace Proyecto3raParcial.Components.Repositories
{
    public class FrutaRepo : IFrutaRepo
    {

        private readonly DBDbContext _context;

        public FrutaRepo(DBDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Fruta>> GetAll()
        {
            return await _context.Frutas.AsNoTracking().ToListAsync();
        }

        public async Task<Fruta> GetById(int id)
        {
            return await _context.Frutas.FindAsync(id);
        }

        public async Task Add(Fruta fruta)
        {
            await _context.Frutas.AddAsync(fruta);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Fruta fruta)
        {
            _context.Frutas.Update(fruta);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var fruta = await _context.Frutas.FindAsync(id);
            if (fruta != null)
            {
                _context.Frutas.Remove(fruta);
                await _context.SaveChangesAsync();
            }
        }
    }
}
      

