using Intranet.Models;
using Microsoft.AspNetCore.Mvc;

namespace Intranet.Controllers
{
    [Route("api/eventos")]
    [ApiController]
    public class EventoController : ControllerBase
    {
        private static List<Evento> eventos = new List<Evento>();

        [HttpGet]
        public IActionResult GetEventos()
        {
            var eventosFormatados = eventos.Select(e => new
            {
                id = e.Id,
                title = e.Titulo,
                start = e.DataInicio.ToString("yyyy-MM-ddTHH:mm:ss"),
                end = e.DataFim.ToString("yyyy-MM-ddTHH:mm:ss"),
                description = e.Descricao,
                participant = e.Participante
            });

            return Ok(eventosFormatados);
        }


        [HttpPost]
        public IActionResult AdicionarEvento([FromBody] Evento novoEvento)
        {
            if (novoEvento == null)
                return BadRequest("Dados inválidos.");

            novoEvento.Id = eventos.Count + 1;
            eventos.Add(novoEvento);

            return Ok(novoEvento);
        }

        [HttpPut("{id}")]
        public IActionResult EditarEvento(int id, [FromBody] Evento eventoEditado)
        {
            var evento = eventos.FirstOrDefault(e => e.Id == id);
            if (evento == null)
                return NotFound();

            evento.Titulo = eventoEditado.Titulo;
            evento.Descricao = eventoEditado.Descricao;
            evento.DataInicio = eventoEditado.DataInicio;
            evento.DataFim = eventoEditado.DataFim;
            evento.Participante = eventoEditado.Participante;

            return Ok(evento);
        }

        [HttpDelete("{id}")]
        public IActionResult ExcluirEvento(int id)
        {
            var evento = eventos.FirstOrDefault(e => e.Id == id);
            if (evento == null)
                return NotFound();

            eventos.Remove(evento);
            return Ok();
        }

    }
}
