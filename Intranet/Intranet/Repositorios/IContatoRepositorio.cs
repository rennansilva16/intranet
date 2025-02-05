using System.ComponentModel;
using Intranet.Models;

namespace Intranet.Repositorios
{
    public interface IContatoRepositorio
    {
        public List<ContatoModel> Listar();
        public ContatoModel Adicionar(ContatoModel contato);
        public ContatoModel Editar(ContatoModel contato);
        public ContatoModel Excluir(ContatoModel contato);
    }
}
