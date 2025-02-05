using Intranet.Data;
using Intranet.Models;
using Intranet.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Intranet.Repositories
{
    public class EventoRepository : IEventoRepository
    {
        private readonly BancoContext _context;

        public EventoRepository(BancoContext context)
        {
            _context = context;
        }

        public async Task<List<EventoModel>> BuscarTodos()
        {
            return await _context.Eventos.Include(e => e.Contato).ToListAsync();
        }

        public async Task<EventoModel> BuscarPorId(int id)
        {
            return await _context.Eventos.Include(e => e.Contato).FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<EventoModel> Adicionar(EventoModel evento)
        {
            await _context.Eventos.AddAsync(evento);
            await _context.SaveChangesAsync();
            return evento;
        }

        public async Task<EventoModel> Atualizar(EventoModel evento)
        {
            _context.Eventos.Update(evento);
            await _context.SaveChangesAsync();
            return evento;
        }

        public async Task<bool> Remover(int id)
        {
            var evento = await BuscarPorId(id);
            if (evento == null) return false;

            _context.Eventos.Remove(evento);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
