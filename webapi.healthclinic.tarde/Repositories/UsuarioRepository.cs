using webapi.healthclinic.tarde.Contexts;
using webapi.healthclinic.tarde.Domains;
using webapi.healthclinic.tarde.Interfaces;

namespace webapi.healthclinic.tarde.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly HealthContext ctx;

        public UsuarioRepository()
        {
            ctx = new HealthContext();
        }
      
        public Usuario BuscarPorId(Guid id)
        {
            return ctx.Usuarios.FirstOrDefault(e => e.IdUsuario == id)!;
        }

        public void Cadastrar(Usuario usuario)
        {
            try
            {
                ctx.Usuarios.Add(usuario);
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            Usuario usuarioBuscado = ctx.Usuarios.Find(id)!;

            if (usuarioBuscado != null)
            {
                ctx.Usuarios.Remove(usuarioBuscado);
            }

            ctx.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return ctx.Usuarios.ToList();
        }
    }
}
