using Domain.Entites;

namespace Infra.Interfaces
{
    public interface IFornecedorRepository
    {
        public List<Fornecedor> GetFornecedores();
        public Fornecedor GetFornecedorById(int id);
        public void InsertFornecedor(Fornecedor fornecedor);
        public void UpdateFornecedor(Fornecedor fornecedor);
        public void DeleteFornecedor(Fornecedor fornecedor);
        public List<Fornecedor> GetFornecedorGerenteById(int id);
    }
}