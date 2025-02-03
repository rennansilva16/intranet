namespace Intranet.Models;

public class Participante
{
    public int Id { get; set; }
    public required string Nome { get; set; }
    public required string Email { get; set; }
    public required string Telefone { get; set; }
    public required string Celular { get; set; }
    public DateTime DataNascimento { get; set; }
    public required string Divisao { get; set; }
}