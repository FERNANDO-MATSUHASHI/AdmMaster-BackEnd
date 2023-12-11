using Domain.Entites;

namespace Infra.Interfaces
{
    public interface IEmpresaRepository
    {
        public List<Empresa> GetEmpresas();
        public Empresa GetEmpresaById(int id);
        public void InsertEmpresa(Empresa empresa);
        public void UpdateEmpresa(Empresa empresa);
        public void DeleteEmpresa(Empresa empresa);
        public List<Empresa> GetEmpresaGerenteById(int id);
    }
}