using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.healthclinic.tarde.Domains
{
    [Table(nameof(Consulta))]
    public class Consulta
    {
        // Chave
        [Key]
        public Guid IdConsulta { get; set; } = Guid.NewGuid();

        // Descrição
        [Column(TypeName = "VARCHAR(300)")]
        [Required(ErrorMessage = "Insira uma descrição válida")]
        public string? Descricao { get; set; }

        // Data Consulta
        [Column(TypeName = "CHAR(14)")]
        [StringLength(14)]
        public string? DataConsulta { get; set; }

        // Horario Consulta
        [Column(TypeName = "VARCHAR(14)")]
        [StringLength(14)]
        public string? HorarioConsulta { get; set; }

        // Foreign Key Medico
        [Required(ErrorMessage = "Insira um Medico válido")]
        public Guid IdMedico { get; set; }
        [ForeignKey(nameof(IdMedico))]
        public Medico? medico { get; set; }

        // Foreign Key Paciente
        [Required(ErrorMessage = "Insira um Paciente válido")]
        public Guid IdPaciente { get; set; }
        [ForeignKey(nameof(IdPaciente))]
        public Paciente? paciente { get; set; }

        // Foreign Key Comentario
        [Required(ErrorMessage = "Insira um Comentario válido")]
        public Guid IdComentario { get; set; }
        [ForeignKey(nameof(IdComentario))]
        public Comentario? comentario { get; set; }
    }
}
