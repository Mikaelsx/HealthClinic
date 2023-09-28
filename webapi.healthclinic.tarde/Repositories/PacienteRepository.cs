using webapi.healthclinic.tarde.Contexts;
using webapi.healthclinic.tarde.Domains;
using webapi.healthclinic.tarde.Interfaces;

namespace webapi.healthclinic.tarde.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly HealthContext ctx;

        public PacienteRepository()
        {
            ctx = new HealthContext();
        }
        public void Atualizar(Guid id, Paciente paciente)
        {
            try
            {
                Paciente pacienteBuscado = ctx.Pacientes.Find(id)!;

                if (pacienteBuscado != null)
                {
                    pacienteBuscado.CPF = paciente.CPF;
                }

                ctx.Pacientes.Update(pacienteBuscado!);

                ctx.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Paciente BuscarPorId(Guid id)
        {
            return ctx.Pacientes.FirstOrDefault(e => e.IdPaciente == id)!;
        }

        public void Cadastrar(Paciente paciente)
        {
            try
            {
                ctx.Pacientes.Add(paciente);
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            Paciente pacienteBuscado = ctx.Pacientes.Find(id)!;

            if (pacienteBuscado != null)
            {
                ctx.Pacientes.Remove(pacienteBuscado);
            }

            ctx.SaveChanges();
        }

        public List<Paciente> Listar()
        {
            return ctx.Pacientes.ToList();
        }
    }
}
