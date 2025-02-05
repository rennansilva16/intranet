using Intranet.Models;
using Intranet.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace Intranet.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;

        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }
        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Excluir()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(ContatoModel contato)
        {
            _contatoRepositorio.Adicionar(contato);
            return RedirectToAction("Adicionar");
        }
    }
}
