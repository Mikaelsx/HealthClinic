using Microsoft.EntityFrameworkCore;
using webapi.healthclinic.tarde.Domains;
using static webapi.healthclinic.tarde.Domains.TiposUsuario;

namespace webapi.healthclinic.tarde.Contexts
{
    public class HealthContext : DbContext
    {
        // TipoUsuario
        public DbSet<TiposUsuario> TiposUsuarios { get; set; }

        // Especialidade
        public DbSet<Especialidade> Especialidades { get; set; }

        // Comentario
        public DbSet<Comentario> Comentarios { get; set; }

        // Usuario
        public DbSet<Usuario> Usuarios { get; set; }

        // Paciente
        public DbSet<Paciente> Pacientes { get; set; }

        // Clinica
        public DbSet<Clinica> Clinicas { get; set; }

        // Medico
        public DbSet<Medico> Medicos { get; set; }

        // Consulta
        public DbSet<Consulta> Consultas { get; set; }


        // Conexão
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = NOTE16-S14; Database = HEALTH; User Id = sa; pwd = Senai@134; TrustServerCertificate = True");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
