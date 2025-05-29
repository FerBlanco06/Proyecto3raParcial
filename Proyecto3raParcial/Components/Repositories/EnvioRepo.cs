using Microsoft.EntityFrameworkCore;
using Proyecto3raParcial.Components.Data;
using Proyecto3raParcial.Components.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto3raParcial.Components.Repositories
{
    public class EnvioRepo : IEnvioRepo
    {
        private readonly DBDbContext _context;

        public EnvioRepo(DBDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Envio>> GetAll()
        {
            return await _context.Envios
                .Include(e => e.Cliente)
                .Include(e => e.Frutas)
                .ToListAsync();
        }

        public async Task<Envio> GetById(int id)
        {
            return await _context.Envios
                .Include(e => e.Cliente)
                .Include(e => e.Frutas)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task Add(Envio envio)
        {
            // Cargar las frutas desde la BD para evitar insertar duplicados
            var frutasCargadas = new List<Fruta>();

            foreach (var fruta in envio.Frutas)
            {
                var frutaExistente = await _context.Frutas.FindAsync(fruta.Id);
                if (frutaExistente != null)
                    frutasCargadas.Add(frutaExistente);
            }

            envio.Frutas = frutasCargadas;

            await _context.Envios.AddAsync(envio);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Envio envio)
        {
            var envioExistente = await _context.Envios
                .Include(e => e.Frutas)
                .FirstOrDefaultAsync(e => e.Id == envio.Id);

            if (envioExistente != null)
            {
                envioExistente.Destino = envio.Destino;
                envioExistente.ClienteId = envio.ClienteId;

                // Limpiar frutas actuales
                envioExistente.Frutas.Clear();

                // Cargar las frutas de la BD para asociarlas
                foreach (var fruta in envio.Frutas)
                {
                    var frutaExistente = await _context.Frutas.FindAsync(fruta.Id);
                    if (frutaExistente != null)
                    {
                        envioExistente.Frutas.Add(frutaExistente);
                    }
                }

                await _context.SaveChangesAsync();
            }
        }

        public async Task Delete(int id)
        {
            var envio = await _context.Envios.FindAsync(id);
            if (envio != null)
            {
                _context.Envios.Remove(envio);
                await _context.SaveChangesAsync();
            }
        }

        public Task Add(Envio envio, List<int> frutaIds)
        {
            throw new NotImplementedException();
        }

        public Task Update(Envio envio, List<int> frutaIds)
        {
            throw new NotImplementedException();
        }

        public Task CambiarEstado(int envioId, bool enviado)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Fruta>> GetFrutas()
        {
            throw new NotImplementedException();
        }
    }
}