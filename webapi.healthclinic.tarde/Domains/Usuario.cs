using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webapi.healthclinic.tarde.Domains
{
    [Table(nameof(Usuario))]
    [Index(nameof(Email), IsUnique = true)]
    public class Usuario
    {
        // Chave
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        // Nome
        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O Nome é obrigatório")]
        public string? Nome { get; set; }

        // Email
        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O Email é obrigatório")]
        public string? Email { get; set; }

        // Senha
        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O Email é obrigatório")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "A Senha deve conter de 3 a 20 caracteres")]
        public string? Senha { get; set; }

        // FK TipoUsuario
        [Required(ErrorMessage = "O Tipo de usuario é obrigatório")]
        public Guid IdTiposUsuario { get; set; }
        [ForeignKey(nameof(IdTiposUsuario))]
        public TiposUsuario? TipoUsuario { get; set; }
    }
}
