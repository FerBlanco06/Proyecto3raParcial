using Microsoft.EntityFrameworkCore;
using Proyecto3raParcial.Components.Models;

namespace Proyecto3raParcial.Components.Data
{
    public class DBDbContext : DbContext
    {
        public DBDbContext(DbContextOptions<DBDbContext> options) : base(options) { }

        public DbSet<Envio> Envios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Fruta> Frutas { get; set; }

       
       
    }
}