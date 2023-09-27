using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.healthclinic.tarde.Domains
{
    [Table(nameof(Comentario))]
    public class Comentario
    {
        // Chave
        [Key]
        public Guid IdComentario { get; set; } = Guid.NewGuid();

        // Feedback
        [Column(TypeName = "VARCHAR(500)")]
        [Required(ErrorMessage = "Insira um Feedback válido.")]
        [StringLength(50)]
        public string? Feedback { get; set; }
    }
}
