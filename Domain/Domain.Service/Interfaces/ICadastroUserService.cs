using Domain.Entites;
using Domain.ViewModel;

namespace Domain.Service.Interfaces
{
    public interface ICadastroUserService
    {
        List<Usuario> GetUser();
        Usuario GetUserById(int id);
        void InsertUser(Usuario usuario);
        void UpdateUser(Usuario usuario);
        void DeleteUser(Usuario usuario);
    }
}