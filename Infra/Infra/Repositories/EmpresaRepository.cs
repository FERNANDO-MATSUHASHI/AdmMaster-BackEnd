using Domain.Entites;
using Infra.Interfaces;

namespace Infra.Repositories
{
    public class EmpresaRepository : IEmpresaRepository
    {
        private readonly SqlContext _context;

        public EmpresaRepository(SqlContext context)
        {
            _context = context;
        }
        public List<Empresa> GetEmpresas()
        {
            return _context.Empresa.ToList();
        }
        public Empresa GetEmpresaById(int id)
        {
            return _context.Empresa.Find(id);
        }
        public void InsertEmpresa(Empresa empresa)
        {
            _context.Empresa.Add(empresa);
            _context.SaveChanges();
        }
        public void UpdateEmpresa(Empresa empresa)
        {
            _context.Empresa.Update(empresa);
            _context.SaveChanges();
        }
        public void DeleteEmpresa(Empresa empresa)
        {
            _context.Empresa.Remove(empresa);
            _context.SaveChanges();
        }
        public List<Empresa> GetEmpresaGerenteById(int gerenteId)
        {
            return _context.Empresa.Where(x => x.gerenteId == gerenteId).ToList();
        }
    }
}