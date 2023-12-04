using Domain.Entites;
using Domain.ViewModel;

namespace Domain.Service.Interfaces
{
    public interface IFornecedorService
    {
        void DeleteFornecedor(int id);
        List<Fornecedor> GetFornecedores();
        Fornecedor GetFornecedorById(int id);
        void InsertFornecedor(FornecedorViewModel fornecedorViewModel);
        void UpdateFornecedor(int id, FornecedorViewModel fornecedorViewModel);
        List<Fornecedor> GetFornecedorGerenteById(int gerenteId);
    }
}
