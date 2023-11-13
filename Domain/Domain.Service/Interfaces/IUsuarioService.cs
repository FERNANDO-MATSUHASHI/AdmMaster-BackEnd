using Domain.Entites;
using Domain.ViewModel;

namespace Domain.Service.Interfaces
{
    public interface IUsuarioService
    {
        List<Usuario> GetUsuarios();
        Usuario GetUsuarioById(int id);
        void InsertUsuario(UsuarioViewModel usuarioViewModel);
        void UpdateUsuario(int id, UsuarioViewModel usuarioViewModel);
        void DeleteUsuario(int id);

        string Login(LoginViewModel loginViewModel);
        Usuario GetUsuarioByEmail(string email); 
        List<ColaboradoresViewModel> GetColaboradores(int gerenteId);
    }
}
