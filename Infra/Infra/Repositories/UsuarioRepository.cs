using Domain.Entites;
using Domain.ViewModel;
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

        public List<Usuario> GetUsuarios()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario GetUsuarioById(int id)
        {
            return _context.Usuarios.Find(id);
        }

        public void InsertUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void UpdateUsuario(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();

        }
        public void DeleteUsuario(Usuario usuario)
        {
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
        }

        public Usuario? GetUsuarioByEmail(string email)
        {
            return _context.Usuarios.Where(x => x.email == email).FirstOrDefault();
        }

        public List<ColaboradoresViewModel>? GetColaboradoresByGerenteId(int gerenteId)
        {
            return (from i in _context.Usuarios.AsNoTracking()
             join cargo in _context.Cargos on i.cargoId equals cargo.Id
             where i.gerenteId == gerenteId
             select new ColaboradoresViewModel
             {
                 nome = i.nome,
                 email = i.email,
                 cargo = cargo.descricao,
                 estado = i.estado,
                 criado_em = i.criado_em.ToString("dd/MM/yyyy")
             }).ToList();
        }
    }
}