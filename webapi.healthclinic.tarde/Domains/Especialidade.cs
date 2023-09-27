using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.healthclinic.tarde.Domains
{
    [Table(nameof(Especialidade))]
    public class Especialidade
    {
        // Chave
        [Key]
        public Guid IdEspecialidade { get; set; } = Guid.NewGuid();

        // Especialidade
        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "Insira uma Especialidade válida")]
        public string? TituloEspecialidade { get; set; }
    }
}