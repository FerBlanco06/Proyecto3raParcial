using Microsoft.EntityFrameworkCore;
using Proyecto3raParcial.Components.Data;
using Proyecto3raParcial.Components.Models;

namespace Proyecto3raParcial.Components.Repositories
{
    public class ClienteRepo : IClienteRepo
    {
        private readonly DBDbContext _context;

        public ClienteRepo(DBDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cliente>> GetAll()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<Cliente?> GetById(int id)
        {
            return await _context.Clientes.FindAsync(id);
        }

        public async Task Add(Cliente cliente)
        {
            await _context.Clientes.AddAsync(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
        }
    }
}
