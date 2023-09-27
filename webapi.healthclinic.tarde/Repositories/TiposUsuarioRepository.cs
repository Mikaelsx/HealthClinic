using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using webapi.healthclinic.tarde.Contexts;
using webapi.healthclinic.tarde.Domains;
using webapi.healthclinic.tarde.Interfaces;

namespace webapi.healthclinic.tarde.Repositories
{
    public class TiposUsuarioRepository : ITiposUsuarioRepository
    {
        private readonly HealthContext ctx;

        public TiposUsuarioRepository()
        {
            ctx = new HealthContext();
        }

        public void Atualizar(Guid id, TiposUsuario tiposUsuario)
        {
            try
            {
                TiposUsuario tipoBuscado = ctx.TiposUsuarios.Find(id)!;

                if (tipoBuscado != null)
                {
                    tipoBuscado.Titulo = tiposUsuario.Titulo;
                }

                ctx.TiposUsuarios.Update(tipoBuscado!);

                ctx.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public TiposUsuario BuscarPorId(Guid id)
        {
            return ctx.TiposUsuarios.FirstOrDefault(e => e.IdTiposUsuario == id)!;
        }

        public void Cadastrar(TiposUsuario tiposUsuario)
        {
            try
            {
                ctx.TiposUsuarios.Add(tiposUsuario);
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            TiposUsuario tiposBuscado = ctx.TiposUsuarios.Find(id)!;

            if (tiposBuscado != null)
            {
                ctx.TiposUsuarios.Remove(tiposBuscado);
            }

            ctx.SaveChanges();
        }

        public List<TiposUsuario> Listar()
        {
            return ctx.TiposUsuarios.ToList();
        }
    }
}
