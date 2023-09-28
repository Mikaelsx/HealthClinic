using webapi.healthclinic.tarde.Contexts;
using webapi.healthclinic.tarde.Domains;
using webapi.healthclinic.tarde.Interfaces;

namespace webapi.healthclinic.tarde.Repositories
{
    public class EspecialidadeRepository : IEspecialidadeRepository
    {
        private readonly HealthContext ctx;

        public EspecialidadeRepository()
        {
            ctx = new HealthContext();
        }
        public void Cadastrar(Especialidade especialidade)
        {
            try
            {
                ctx.Especialidades.Add(especialidade);
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            Especialidade especialidadeBuscado = ctx.Especialidades.Find(id)!;

            if (especialidadeBuscado != null)
            {
                ctx.Especialidades.Remove(especialidadeBuscado);
            }

            ctx.SaveChanges();
        }

        public List<Especialidade> Listar()
        {
            return ctx.Especialidades.ToList();
        }
    }
}
