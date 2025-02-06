using Intranet.Models;
using Intranet.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace Intranet.Controllers
{
    public class EventoController : Controller
    {
        private readonly IEventoRepositorio _eventoRepositorio;
        private readonly IContatoRepositorio _contatoRepositorio;

        public EventoController(IEventoRepositorio eventoRepositorio, IContatoRepositorio contatoRepositorio)
        {
            _eventoRepositorio = eventoRepositorio;
            _contatoRepositorio = contatoRepositorio;
        }

    }
}
