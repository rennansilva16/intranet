namespace Intranet.Models;

public class ContatoModel
{
    public int Id { get; set; }
    public string Divisao { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    public int Celular { get; set; }
    public DateOnly Aniversario { get; set; }

}
