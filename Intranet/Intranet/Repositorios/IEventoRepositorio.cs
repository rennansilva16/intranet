using System.Collections.Generic;
using Intranet.Models;

namespace Intranet.Repositorios;

public interface IEventoRepositorio
{
    EventoModel ListarPorId(int id);
    EventoModel Adicionar(EventoModel evento);
    EventoModel Editar(EventoModel evento);
    bool Excluir(int id);
}
