using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.healthclinic.tarde.Domains
{
    [Table(nameof(Medico))]
    public class Medico
    {
        // Chave
        [Key]
        public Guid IdMedico { get; set; }

        // CRM
        [Column(TypeName = "VARCHAR(20)")]
        [Required(ErrorMessage = "Insira um CRM válido.")]
        public string? CRM { get; set; }

        // Foreign Key Usuario
        [Required(ErrorMessage = "Insira um Usuario válido")]
        public Guid IdUsuario { get; set;}
        [ForeignKey(nameof(IdUsuario))]
        public TiposUsuario? tipoUsuario { get; set; }

        // Foreign Key Especialidade
        [Required(ErrorMessage = "Insira uma Especialidade válida")]
        public Guid IdEspecialidade { get; set; }
        [ForeignKey(nameof(IdEspecialidade))]
        public Especialidade? especialidade { get; set; }

        // Foreign Key Usuario
        [Required(ErrorMessage = "Insira uma Clinica válida")]
        public Guid IdClinica { get; set; }
        [ForeignKey(nameof(IdClinica))]
        public Clinica? clinica { get; set; }
    }
}
