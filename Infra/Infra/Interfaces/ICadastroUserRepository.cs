using Domain.Entites;

namespace Infra.Interfaces
{
    public interface ICadastroUserRepository
    {
        public List<Usuario> GetUser();
        public Usuario GetUserById(int id);
        public void InsertUser(Usuario usuario);
        public void UpdateUser(Usuario usuario);
        public void DeleteUser(Usuario usuario);
    }
}