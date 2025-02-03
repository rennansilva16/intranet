using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Intranet.Models;

namespace Intranet.Controllers
{
    public class ContatoController : Controller

    {
        private readonly IList<Participante> _contatos;
        

        public IActionResult Index()
        {
            if (_contatos == null)
            {
                new Participante { Id = 1, Nome = "João Silva", Email = "joao@email.com", Telefone = "1234-5678", Celular = "98765-4321", DataNascimento = new DateTime(1990, 5, 20), Divisao = "TI" };
                new Participante { Id = 2, Nome = "Maria Oliveira", Email = "maria@email.com", Telefone = "2345-6789", Celular = "98765-1234", DataNascimento = new DateTime(1985, 8, 15), Divisao = "RH" };
            }
            return View(_contatos);
        }


        // Exibe o modal de adição de contato
        public IActionResult Adicionar()
        {
            return PartialView("_AdicionarContato");
        }

        // Adiciona um novo contato
        [HttpPost]
        public IActionResult Adicionar(Participante novoContato)
        {
            novoContato.Id = _contatos.Count + 1;
            _contatos.Add(novoContato);
            return RedirectToAction("Index");
        }

        // Exibe o modal de edição
        public IActionResult Editar(int id)
        {
            var contato = _contatos.FirstOrDefault(c => c.Id == id);
            if (contato == null) return NotFound();
            return PartialView("_EditarContato", contato);
        }

        // Salva as edições
        [HttpPost]
        public IActionResult Editar(Participante contatoEditado)
        {
            var contato = _contatos.FirstOrDefault(c => c.Id == contatoEditado.Id);
            if (contato == null) return NotFound();

            contato.Nome = contatoEditado.Nome;
            contato.Email = contatoEditado.Email;
            contato.Telefone = contatoEditado.Telefone;
            contato.Celular = contatoEditado.Celular;
            contato.DataNascimento = contatoEditado.DataNascimento;
            contato.Divisao = contatoEditado.Divisao;

            return RedirectToAction("Index");
        }

        // Remove um contato
        public IActionResult Excluir(int id)
        {
            var contato = _contatos.FirstOrDefault(c => c.Id == id);
            if (contato == null) return NotFound();

            _contatos.Remove(contato);
            return RedirectToAction("Index");
        }
    }
}
