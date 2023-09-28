using webapi.healthclinic.tarde.Contexts;
using webapi.healthclinic.tarde.Domains;
using webapi.healthclinic.tarde.Interfaces;

namespace webapi.healthclinic.tarde.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {
        private readonly HealthContext ctx;

        public ClinicaRepository()
        {
            ctx = new HealthContext();
        }
        public Clinica BuscarPorId(Guid id)
        {
            return ctx.Clinicas.FirstOrDefault(e => e.IdClinica == id)!;
        }

        public void Cadastrar(Clinica clinica)
        {
            try
            {
                ctx.Clinicas.Add(clinica);
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            Clinica clinicaBuscado = ctx.Clinicas.Find(id)!;

            if (clinicaBuscado != null)
            {
                ctx.Clinicas.Remove(clinicaBuscado);
            }

            ctx.SaveChanges();
        }

        public List<Clinica> Listar()
        {
            return ctx.Clinicas.ToList();
        }
    }
}
