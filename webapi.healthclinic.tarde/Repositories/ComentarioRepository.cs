using webapi.healthclinic.tarde.Contexts;
using webapi.healthclinic.tarde.Domains;
using webapi.healthclinic.tarde.Interfaces;

namespace webapi.healthclinic.tarde.Repositories
{
    public class ComentarioRepository : IComentarioRepository
    {
        private readonly HealthContext ctx;

        public ComentarioRepository()
        {
            ctx = new HealthContext();
        }

        public Comentario BuscarPorId(Guid id)
        {
            return ctx.Comentarios.FirstOrDefault(e => e.IdComentario == id)!;
        }

        public void Cadastrar(Comentario comentario)
        {
            try
            {
                ctx.Comentarios.Add(comentario);
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            Comentario comentarioBuscado = ctx.Comentarios.Find(id)!;

            if (comentarioBuscado != null)
            {
                ctx.Comentarios.Remove(comentarioBuscado);
            }

            ctx.SaveChanges();
        }

        public List<Comentario> Listar()
        {
            return ctx.Comentarios.ToList();
        }

    }
}
