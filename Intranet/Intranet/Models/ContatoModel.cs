using System.ComponentModel.DataAnnotations;

namespace Intranet.Models;

public class ContatoModel
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Informe a divisão do contato.")]
    public string Divisao { get; set; }
    [Required(ErrorMessage = "Informe o nome do contato.")]
    public string Nome { get; set; }
    public string Telefone { get; set; }
    [Required(ErrorMessage = "Informe o email do contato.")]
    [EmailAddress(ErrorMessage = "Informe um email válido.")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Informe o telefone do contato.")]
    [Phone(ErrorMessage = "Informe um número de telefone válido.")]
    public int Celular { get; set; }
    public DateOnly Aniversario { get; set; }

}
