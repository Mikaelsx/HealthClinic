using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.healthclinic.tarde.Domains
{
    [Table(nameof(Clinica))]
    public class Clinica
    {
        // Chave
        [Key]
        public Guid IdClinica { get; set; } = Guid.NewGuid();

        // Endereço
        [Column(TypeName = "VARCHAR(150)")]
        [Required(ErrorMessage = "Insira um Endereço válido.")]
        public string? Endereco { get; set; }

        // CNPJ
        [Column(TypeName = "CHAR(14)")]
        [Required(ErrorMessage = "Insira um Cnpj válido.")]
        public string? CNPJ { get; set; }

        // Horario
        [Column(TypeName = "CHAR(14)")]
        [Required(ErrorMessage = "Insira um Horario válido.")]
        public string? Horario { get; set; }

        // Nome Fantasia
        [Column(TypeName = "VARCHAR(80)")]
        public string? NomeFantasia { get; set; }

        // Razão Social
        [Column(TypeName = "VARCHAR(300)")]
        public string? RazaoSocial { get; set; }
    }
}
