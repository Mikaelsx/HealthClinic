using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using webapi.healthclinic.tarde.Interfaces;

namespace webapi.healthclinic.tarde.Domains
{
    [Table(nameof(TiposUsuario))]
    public class TiposUsuario
    {
        // Chave
        [Key]
        public Guid IdTiposUsuario { get; set; } = Guid.NewGuid();

        // Tipos de Usuario
        [Column(TypeName = "VARCHAR(30)")]
        [Required(ErrorMessage = "Titulo do tipo de usuario obrigatorio")]
        public string? Titulo { get; set; }

    }
}
