using Proyecto3raParcial.Components.Models;

namespace Proyecto3raParcial.Components.Repositories
{
    public interface IFrutaRepo
    {
        Task<IEnumerable<Fruta>> GetAll();
        Task<Fruta> GetById(int id);
        Task Add(Fruta fruta);
        Task Update(Fruta fruta);
        Task Delete(int id);
    }
}
