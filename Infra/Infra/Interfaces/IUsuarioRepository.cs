using Domain.Entites;

namespace Infra.Interfaces
{
    public interface IUsuarioRepository
    {
        public List<Usuario> GetUsuarios();
        public Usuario GetUsuarioById(int id);
        public void InsertUsuario(Usuario usuario);
        public void UpdateUsuario(Usuario usuario);
        public void DeleteUsuario(Usuario usuario);
    }
}