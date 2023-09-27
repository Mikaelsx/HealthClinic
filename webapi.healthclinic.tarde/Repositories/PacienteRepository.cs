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
            throw new NotImplementedException();
        }

        public Paciente BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Paciente paciente)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Paciente> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
