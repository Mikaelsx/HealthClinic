using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.healthclinic.tarde.Domains
{
    [Table(nameof(Paciente))]
    public class Paciente
    {
        // Chave
        [Key]
        public Guid IdPaciente { get; set; } = Guid.NewGuid();

        // CPF
        [Column(TypeName = "CHAR(11)")]
        [Required(ErrorMessage = "Insira um CPF válido.")]
        public string? CPF { get; set; }

        // FK TipoUsuario
        [Required(ErrorMessage = "O Tipo de usuario é obrigatório")]
        public Guid IdUsuario { get; set; }
        [ForeignKey(nameof(IdUsuario))]
        public Usuario? usuario { get; set; }
    }
}
