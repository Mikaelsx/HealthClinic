using webapi.healthclinic.tarde.Contexts;
using webapi.healthclinic.tarde.Domains;
using webapi.healthclinic.tarde.Interfaces;

namespace webapi.healthclinic.tarde.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        private readonly HealthContext ctx;

        public MedicoRepository()
        {
            ctx = new HealthContext();
        }
        public void Atualizar(Guid id, Medico medico)
        {
            try
            {
                Medico medicoBuscado = ctx.Medicos.Find(id)!;

                if (medicoBuscado != null)
                {
                    medicoBuscado.CRM = medico.CRM;
                }

                ctx.Medicos.Update(medico!);

                ctx.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Medico BuscarPorId(Guid id)
        {
            return ctx.Medicos.FirstOrDefault(e => e.IdMedico == id)!;
        }

        public void Cadastrar(Medico medico)
        {
            try
            {
                ctx.Medicos.Add(medico);
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            Medico medicoBuscado = ctx.Medicos.Find(id)!;

            if (medicoBuscado != null)
            {
                ctx.Medicos.Remove(medicoBuscado);
            }

            ctx.SaveChanges();
        }

        public List<Medico> Listar()
        {
            return ctx.Medicos.ToList();
        }
    }
}
