using Intranet.Data;
using Intranet.Models;
using Microsoft.EntityFrameworkCore;

namespace Intranet.Repositorios
{
    public class EventoRepositorio : IEventoRepositorio
    {
        private readonly BancoContext _context;

        public EventoRepositorio(BancoContext context)
        {
            _context = context;
        }

        public EventoModel Adicionar(EventoModel evento)
        {
            _context.Eventos.Add(evento);
            _context.SaveChanges();
            return evento;
        }

        public EventoModel ListarPorId(int id)
        {
            return _context.Eventos.FirstOrDefault(x => x.Id == id);
        }
        public EventoModel Editar(EventoModel evento)
        {
            EventoModel eventoDB = ListarPorId(evento.Id);

            if (eventoDB == null) throw new System.Exception("Contato não encontrado");

            eventoDB.Titulo = evento.Titulo;
            eventoDB.Descricao = evento.Titulo;
            eventoDB.DataInicio = evento.DataInicio;
            eventoDB.DataFim = evento.DataFim;

            _context.Update(eventoDB);
            _context.SaveChanges();

            return eventoDB;
        }

        public bool Excluir(int id)
        {
            EventoModel eventoDB = ListarPorId(id);

            if (eventoDB == null) throw new Exception("Houve um erro na deleção do contato");

            _context.Eventos.Remove(eventoDB);
            _context.SaveChanges();

            return true;
        }

        
    }
}
