using Intranet.Data;
using Intranet.Models;

namespace Intranet.Repositorios
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _context;

        public List<ContatoModel> Listar()
        {
            return _context.Contatos.ToList();
        }
        public ContatoRepositorio(BancoContext context)
        {
            _context = context;
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            _context.Contatos.Add(contato);
            _context.SaveChanges();
            return contato;

        }

        public ContatoModel Editar(ContatoModel contato)
        {
            throw new NotImplementedException();
        }

        public ContatoModel Excluir(ContatoModel contato)
        {
            throw new NotImplementedException();
        }

        
    }
}
