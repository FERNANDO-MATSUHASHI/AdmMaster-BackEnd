using Domain.Entites;
using Domain.ViewModel;

namespace Application.Service.Interface
{
    public interface IEmpresaApplication
    {       
        List<Empresa> GetEmpresas();
        Empresa GetEmpresaById(int id);
        void InsertEmpresa(EmpresaViewModel empresaViewModel);
        void UpdateEmpresa(int id, EmpresaViewModel empresaViewModel);
        void DeleteEmpresa(int id);
        List<Empresa> GetEmpresaGerenteById(int gerenteId);
    }
}