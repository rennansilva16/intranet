using Intranet.Models;
using Intranet.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Intranet.Controllers
{
    public class EventoController : Controller
    {
        private readonly IEventoRepository _eventoRepository;

        public EventoController(IEventoRepository eventoRepository)
        {
            _eventoRepository = eventoRepository;
        }

        public async Task<IActionResult> Index()
        {
            List<EventoModel> eventos = await _eventoRepository.BuscarTodos();
            return View(eventos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Criar(EventoModel evento)
        {
            if (ModelState.IsValid)
            {
                await _eventoRepository.Adicionar(evento);
                return RedirectToAction("Index");
            }
            return View(evento);
        }

        public async Task<IActionResult> Editar(int id)
        {
            EventoModel evento = await _eventoRepository.BuscarPorId(id);
            if (evento == null) return NotFound();
            return View(evento);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(EventoModel evento)
        {
            if (ModelState.IsValid)
            {
                await _eventoRepository.Atualizar(evento);
                return RedirectToAction("Index");
            }
            return View(evento);
        }

        public async Task<IActionResult> Deletar(int id)
        {
            EventoModel evento = await _eventoRepository.BuscarPorId(id);
            if (evento == null) return NotFound();
            return View(evento);
        }

        [HttpPost, ActionName("Deletar")]
        public async Task<IActionResult> ConfirmarDeletar(int id)
        {
            await _eventoRepository.Remover(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> ObterEventos()
        {
            var eventos = await _eventoRepository.BuscarTodos();
            var eventosJson = eventos.Select(e => new
            {
                id = e.Id,
                title = e.Titulo,
                start = e.DataInicio.ToString("yyyy-MM-ddTHH:mm:ss"),
                end = e.DataFim?.ToString("yyyy-MM-ddTHH:mm:ss"),
            });

            return Json(eventosJson);
        }
    }
}
