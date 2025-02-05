using System.ComponentModel;
using Intranet.Models;

namespace Intranet.Repositorios
{
    public interface IContatoRepositorio
    {
        ContatoModel ListarPorId(int id);
        ContatoModel Editar(ContatoModel contato);
        List<ContatoModel> Listar();
        ContatoModel Adicionar(ContatoModel contato);
        bool Excluir(int id);
        Task<List<ContatoModel>> ListarAsync();
    }
}
