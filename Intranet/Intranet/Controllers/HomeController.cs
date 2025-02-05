using System.Diagnostics;
using Intranet.Models;
using Intranet.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace Intranet.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;

        public HomeController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }
        public IActionResult Index()
        {
            var lista = _contatoRepositorio.Listar();
            return View(lista);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
