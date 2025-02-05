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

        public IActionResult Editar(int id)
        {
            ContatoModel contato = _contatoRepositorio.ListarPorId(id);
            return View(contato);
        }

        public IActionResult ExcluirConfirmacao(int id)
        {
            ContatoModel contato = _contatoRepositorio.ListarPorId(id);
            return View(contato);
        }

        public IActionResult Excluir(int id)
        {
            _contatoRepositorio.Excluir(id);
            return RedirectToAction("Editar");
        }

        [HttpPost]
        public IActionResult Adicionar(ContatoModel contato)
        {
            if (ModelState.IsValid)
            {
                _contatoRepositorio.Adicionar(contato);
                return RedirectToAction("Editar");
            }
            return View(contato);


        }

        [HttpPost]
        public IActionResult Editar(ContatoModel contato)
        {
            _contatoRepositorio.Editar(contato);
            return RedirectToAction("Editar");
        }
    }
}
