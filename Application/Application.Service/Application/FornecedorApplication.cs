using Application.Service.Interface;
using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.Service.Services;
using Domain.ViewModel;

namespace Application.Service.Application
{
    public class FornecedorApplication : IFornecedorApplication
    {
        private readonly IFornecedorService _fornecedorService;

        public FornecedorApplication(IFornecedorService fornecedorService)
        {
            _fornecedorService = fornecedorService;
        }

        public List<Fornecedor> GetFornecedores()
        {
            return _fornecedorService.GetFornecedores();
        }

        public Fornecedor GetFornecedorById(int id)
        {
            return _fornecedorService.GetFornecedorById(id);
        }

        public void InsertFornecedor(FornecedorViewModel fornecedorViewModel)
        {
            _fornecedorService.InsertFornecedor(fornecedorViewModel);
        }

        public void UpdateFornecedor(int id, FornecedorViewModel fornecedorViewModel)
        {
            _fornecedorService.UpdateFornecedor(id, fornecedorViewModel);
        }

        public void DeleteFornecedor(int id)
        {
            _fornecedorService.DeleteFornecedor(id);
        }
        public List<Fornecedor> GetFornecedorGerenteById(int gerenteId)
        {
            return _fornecedorService.GetFornecedorGerenteById(gerenteId);
        }
    }
}
