using webapi.healthclinic.tarde.Domains;

namespace webapi.healthclinic.tarde.Interfaces
{
    public interface ITiposUsuarioRepository 
    {
        void Cadastrar(TiposUsuario tiposUsuario);
        void Deletar(Guid id);
        List<TiposUsuario> Listar();
        TiposUsuario BuscarPorId(Guid id);
        void Atualizar(Guid id, TiposUsuario tiposUsuario);
    }
}
