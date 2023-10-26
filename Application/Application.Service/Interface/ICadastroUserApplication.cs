using Domain.Entites;
using Domain.ViewModel;

namespace Application.Service.Interface
{
    public interface ICadastroUserApplication
    {
        List<Usuario> GetUser();
        Usuario GetUserById(int id);
        void InsertUser(Usuario usuario);
        void UpdateUser(int id, Usuario usuario);
        void DeleteUser(int id);
    }
}
