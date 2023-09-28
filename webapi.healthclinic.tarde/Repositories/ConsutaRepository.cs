using webapi.healthclinic.tarde.Contexts;
using webapi.healthclinic.tarde.Domains;
using webapi.healthclinic.tarde.Interfaces;

namespace webapi.healthclinic.tarde.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        private readonly HealthContext ctx;

        public ConsultaRepository()
        {
            ctx = new HealthContext();
        }
        public void Atualizar(Guid id, Consulta consulta)
        {
            try
            {
                Consulta consultaBuscado = ctx.Consultas.Find(id)!;

                if (consultaBuscado != null)
                {
                    consultaBuscado.Descricao = consulta.Descricao;
                }

                ctx.Consultas.Update(consultaBuscado!);

                ctx.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Consulta BuscarPorId(Guid id)
        {
            return ctx.Consultas.FirstOrDefault(e => e.IdConsulta == id)!;
        }

        public void Cadastrar(Consulta consulta)
        {
            try
            {
                ctx.Consultas.Add(consulta);
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            Consulta consultaBuscado = ctx.Consultas.Find(id)!;

            if (consultaBuscado != null)
            {
                ctx.Consultas.Remove(consultaBuscado);
            }

            ctx.SaveChanges();
        }

        public List<Consulta> Listar()
        {
            return ctx.Consultas.ToList();
        }
    }
}
