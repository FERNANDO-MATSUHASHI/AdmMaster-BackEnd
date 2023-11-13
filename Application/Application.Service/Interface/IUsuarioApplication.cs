using Domain.Entites;
using Domain.ViewModel;

namespace Application.Service.Interface
{
    public interface IUsuarioApplication
    {
        void DeleteUsuario(int id);
        List<Usuario> GetUsuarios();
        Usuario GetUsuarioById(int id);
        void InsertUsuario(UsuarioViewModel usuarioViewModel);
        void UpdateUsuario(int id, UsuarioViewModel UsuarioViewModel);
        string Login(LoginViewModel loginViewModel);
        Usuario GetUsuarioByEmail(string email);
        List<ColaboradoresViewModel> GetColaboradores(int gerenteId);
    }
}
