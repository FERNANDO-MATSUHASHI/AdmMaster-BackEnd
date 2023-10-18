using Domain.Entites;
using Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly SqlContext _context;

        public UsuarioRepository(SqlContext context)
        {
            _context = context;
        }

        public List<Usuario> GetUsuario()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario GetUsuarioById(int id)
        {
            return _context.Usuarios.Find(id);
        }

        public void InsertUsuario(Usuario usuario, int idCargo)
        {
            try
            {
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateUsuario(Usuario usuario)
        {
            try
            {
                _context.Entry(usuario).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteUsuario(Usuario usuario)
        {
            try
            {
                _context.Set<Usuario>().Remove(usuario);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}