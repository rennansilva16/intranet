using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intranet.Models
{
    public class EventoModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Titulo { get; set; }

        [Required]
        public DateTime DataInicio { get; set; }

        public DateTime? DataFim { get; set; }

        [Required]
        public int ContatoId { get; set; }  // Melhor nome para refletir a relação correta

        public ContatoModel Contato { get; set; }  // Mantendo a coerência com a classe relacionada
    }
}
