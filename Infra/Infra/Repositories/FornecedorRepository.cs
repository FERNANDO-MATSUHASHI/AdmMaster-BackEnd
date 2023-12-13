using Domain.Entites;
using Infra.Interfaces;

namespace Infra.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly SqlContext _context;

        public FornecedorRepository(SqlContext context)
        {
            _context = context;
        }

        public List<Fornecedor> GetFornecedores()
        {
            return _context.Fornecedor.ToList();
        }

        public Fornecedor GetFornecedorById(int id)
        {
            return _context.Fornecedor.Find(id);
        }

        public void InsertFornecedor(Fornecedor fornecedor)
        {
            //var cnpj = _context.Fornecedor.Where(x => x.cnpj == fornecedor.cnpj).FirstOrDefault();
            //if (cnpj == null)
            //{
            //    _context.Fornecedor.Add(fornecedor);
            //    _context.SaveChanges();
            //}
            //else
            //{
            //    throw new Exception("CNPJ já existe.");
            //}
            _context.Fornecedor.Add(fornecedor);
            _context.SaveChanges();
        }
        public void UpdateFornecedor(Fornecedor fornecedor)
        {
            _context.Fornecedor.Update(fornecedor);
            _context.SaveChanges();
        }
        public void DeleteFornecedor(Fornecedor fornecedor)
        {
            _context.Fornecedor.Remove(fornecedor);
            _context.SaveChanges();
        }
        public List<Fornecedor> GetFornecedorGerenteById(int gerenteId)
        {
            return _context.Fornecedor.Where(x => x.gerenteId == gerenteId).ToList();
        }
    }
}