using Domain.Entites;
using Infra.Interfaces;

namespace Infra.Repositories
{
    public class CadastroUserRepository : ICadastroUserRepository
    {
        private readonly SqlContext _context;

        public CadastroUserRepository(SqlContext context)
        {
            _context = context;
        }

        public List<Usuario> GetUser()
        {
            return _context.Usuarios.ToList();
        }
        public Usuario GetUserById(int id)
        {
            return _context.Usuarios.Find(id);
        }
        public void InsertUser(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }
        public void UpdateUser(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
        }
        public void DeleteUser(Usuario usuario)
        {
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
        }
    }
}
