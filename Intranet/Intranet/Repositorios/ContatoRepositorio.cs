using Intranet.Data;
using Intranet.Models;
using Microsoft.EntityFrameworkCore;

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

        public ContatoModel ListarPorId(int id)
        {
            return _context.Contatos.FirstOrDefault(x => x.Id == id);
        }

        public ContatoModel Editar(ContatoModel contato)
        {
            ContatoModel contatoDB = ListarPorId(contato.Id);

            if(contatoDB == null) throw new System.Exception("Contato não encontrado");

            contatoDB.Nome = contato.Nome;
            contatoDB.Email = contato.Email;
            contatoDB.Telefone = contato.Telefone;
            contatoDB.Celular = contato.Celular;
            contatoDB.Aniversario = contato.Aniversario;
            contatoDB.Divisao = contato.Divisao;

            _context.Update(contatoDB);
            _context.SaveChanges();

            return contatoDB;
        }

        public bool Excluir(int id)
        {
            ContatoModel contatoDB = ListarPorId(id);

            if (contatoDB == null) throw new Exception("Houve um erro na deleção do contato");

            _context.Contatos.Remove(contatoDB);
            _context.SaveChanges();

            return true;
        }
    }
}
