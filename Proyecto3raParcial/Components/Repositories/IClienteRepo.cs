using Proyecto3raParcial.Components.Models;

namespace Proyecto3raParcial.Components.Repositories
{
    public interface IClienteRepo
    {
        Task<IEnumerable<Cliente>> GetAll();
        Task<Cliente> GetById(int id);
        Task Add(Cliente cliente);
        Task Update(Cliente cliente);
        Task Delete(int id);
    }
}

