using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.ViewModel;
using Infra.Interfaces;
using Infra.Repositories;

namespace Domain.Service.Services
{
    public class FornecedorService : IFornecedorService
    {
        public readonly IFornecedorRepository _fornecedorRepository;

        public FornecedorService(IFornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }

        public List<Fornecedor> GetFornecedores()
        {
            return _fornecedorRepository.GetFornecedores();
        }

        public Fornecedor GetFornecedorById(int id)
        {
            return _fornecedorRepository.GetFornecedorById(id);
        }

        public void InsertFornecedor(FornecedorViewModel fornecedorViewModel)
        {
            var fornecedor = new Fornecedor
            {
                cnpj = fornecedorViewModel.cnpj,
                razao_social = fornecedorViewModel.razao_social,
                nome_fantasia = fornecedorViewModel.nome_fantasia,
                telefone = fornecedorViewModel.telefone,
                email = fornecedorViewModel.email,
                cep = fornecedorViewModel.cep,
                rua = fornecedorViewModel.rua,
                numero = fornecedorViewModel.numero,
                cidade = fornecedorViewModel.cidade,
                estado = fornecedorViewModel.estado,
                gerenteId = fornecedorViewModel.gerenteId
            };

            _fornecedorRepository.InsertFornecedor(fornecedor);
        }

        public void UpdateFornecedor(int id, FornecedorViewModel fornecedorViewModel)
        {
            var originalFornecedor = _fornecedorRepository.GetFornecedorById(id);
            if (originalFornecedor == null)
                throw new Exception("Fornecedor nao existe.");

            originalFornecedor.cnpj = fornecedorViewModel.cnpj;
            originalFornecedor.razao_social = fornecedorViewModel.razao_social;
            originalFornecedor.nome_fantasia = fornecedorViewModel.nome_fantasia;
            originalFornecedor.telefone = fornecedorViewModel.telefone;
            originalFornecedor.email = fornecedorViewModel.email;
            originalFornecedor.cep = fornecedorViewModel.cep;
            originalFornecedor.rua = fornecedorViewModel.rua;
            originalFornecedor.numero = fornecedorViewModel.numero;
            originalFornecedor.cidade = fornecedorViewModel.cidade;
            originalFornecedor.estado = fornecedorViewModel.estado;
            originalFornecedor.gerenteId = fornecedorViewModel.gerenteId;

            _fornecedorRepository.UpdateFornecedor(originalFornecedor);
        }

        public void DeleteFornecedor(int id)
        {
            var originalFornecedor = _fornecedorRepository.GetFornecedorById(id);
            if (originalFornecedor == null)
                throw new Exception("Fornecedor nao existe.");

            _fornecedorRepository.DeleteFornecedor(originalFornecedor);
        }
        public List<Fornecedor> GetFornecedorGerenteById(int gerenteId)
        {
            return _fornecedorRepository.GetFornecedorGerenteById(gerenteId);
        }
    }
}
