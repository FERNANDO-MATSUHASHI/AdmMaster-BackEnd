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
            var email = _context.Usuarios.Where(x => x.email == usuario.email).FirstOrDefault();
            if (email == null)
            {
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Email já existe.");
            }
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
                 Id = i.Id,
                 nome = i.nome,
                 cpf = i.cpf,
                 telefone = i.telefone,
                 email = i.email,
                 data_nascimento = i.data_nascimento,
                 cep = i.cep,
                 rua = i.rua,
                 numero = i.numero,
                 cidade = i.cidade,
                 estado = i.estado,
                 user_name = i.user_name,
                 senha = i.senha,
                 ativo = i.ativo,
                 comissao = i.comissao,
                 gerenteId = i.gerenteId,
                 cargoId = i.cargoId,
                 criado_em = i.criado_em.ToString("dd/MM/yyyy")
             }).ToList();
        }
    }
}