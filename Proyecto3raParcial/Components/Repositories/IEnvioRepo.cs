using Proyecto3raParcial.Components.Models;

namespace Proyecto3raParcial.Components.Repositories
{

    public interface IEnvioRepo
    {
        Task<IEnumerable<Envio>> GetAll();
        Task<IEnumerable<Fruta>> GetFrutas();

        Task<Envio> GetById(int id);
        Task Add(Envio envio);
        Task Add(Envio envio, List<int> frutaIds);
        Task Update(Envio envio);
        Task Update(Envio envio, List<int> frutaIds);
        Task Delete(int id);
        Task CambiarEstado(int envioId, bool enviado);
    }


}

