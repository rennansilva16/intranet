using Intranet.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Intranet.Repositories.Interfaces
{
    public interface IEventoRepository
    {
        Task<List<EventoModel>> BuscarTodos();
        Task<EventoModel> BuscarPorId(int id);
        Task<EventoModel> Adicionar(EventoModel evento);
        Task<EventoModel> Atualizar(EventoModel evento);
        Task<bool> Remover(int id);
    }
}
