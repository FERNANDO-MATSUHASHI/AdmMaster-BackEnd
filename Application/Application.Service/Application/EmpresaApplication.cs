using Application.Service.Interface;
using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.ViewModel;

namespace Application.Service.Application
{
    public class EmpresaApplication : IEmpresaApplication
    {
        private readonly IEmpresaService _empresaService;

        public EmpresaApplication(IEmpresaService empresaService)
        {
            _empresaService = empresaService;
        }

        public List<Empresa> GetEmpresas()
        {
            return _empresaService.GetEmpresas();
        }

        public Empresa GetEmpresaById(int id)
        {
            return _empresaService.GetEmpresaById(id);
        }

        public void InsertEmpresa(EmpresaViewModel empresaViewModel)
        {
            _empresaService.InsertEmpresa(empresaViewModel);
        }

        public void UpdateEmpresa(int id, EmpresaViewModel empresaViewModel)
        {
            _empresaService.UpdateEmpresa(id, empresaViewModel);
        }

        public void DeleteEmpresa(int id)
        {
            _empresaService.DeleteEmpresa(id);
        }

        public List<Empresa> GetEmpresaGerenteById(int gerenteId)
        {
            return _empresaService.GetEmpresaGerenteById(gerenteId);
        }
    }
}