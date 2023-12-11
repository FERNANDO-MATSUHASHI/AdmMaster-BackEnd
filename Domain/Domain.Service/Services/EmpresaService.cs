using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.ViewModel;
using Infra.Interfaces;
using Infra.Repositories;

namespace Domain.Service.Services
{
    public class EmpresaService : IEmpresaService
    {
        private readonly IEmpresaRepository _empresaRepository;

        public EmpresaService(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }

        public List<Empresa> GetEmpresas()
        {
            return _empresaRepository.GetEmpresas();
        }

        public Empresa GetEmpresaById(int id)
        {
            return _empresaRepository.GetEmpresaById(id);
        }

        public void InsertEmpresa(EmpresaViewModel empresaViewModel)
        {
            var empresa = new Empresa
            {
                nome_empresa = empresaViewModel.nome_empresa,
                gerenteId = empresaViewModel.gerenteId,
            };

            _empresaRepository.InsertEmpresa(empresa);
        }

        public void UpdateEmpresa(int id, EmpresaViewModel empresaViewModel)
        {
            var originalEmpresa = _empresaRepository.GetEmpresaById(id);
            if (originalEmpresa == null)
                throw new Exception("Empresa não existe.");

            originalEmpresa.nome_empresa = empresaViewModel.nome_empresa;
            originalEmpresa.gerenteId = empresaViewModel.gerenteId;

            _empresaRepository.UpdateEmpresa(originalEmpresa);
        }

        public void DeleteEmpresa(int id)
        {
            var originalEmpresa = _empresaRepository.GetEmpresaById(id);
            if (originalEmpresa == null)
                throw new Exception("Empresa nao existe.");

            _empresaRepository.DeleteEmpresa(originalEmpresa);
        }

        public List<Empresa> GetEmpresaGerenteById(int gerenteId)
        {
            return _empresaRepository.GetEmpresaGerenteById(gerenteId);
        }
    }
}