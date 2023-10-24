using Domain.Entites;
using Domain.ViewModel;

namespace Domain.Service.Interfaces
{
    public interface IUsuarioService
    {
        void DeleteUsuario(int id);
        List<Usuario> GetUsuarios();
        Usuario GetUsuarioById(int id);
        void InsertUsuario(UsuarioViewModel usuarioViewModel);
        void UpdateUsuario(int id, UsuarioViewModel usuarioViewModel);
    }
}
