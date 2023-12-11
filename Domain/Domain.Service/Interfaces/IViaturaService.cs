using Domain.Entites;
using Domain.ViewModel;

namespace Domain.Service.Interfaces
{
    public interface IViaturaService
    {
        void DeleteViatura(int id);
        List<Viatura> GetViaturas();
        Viatura GetViaturaById(int id);
        void InsertViatura(ViaturaViewModel viaturaViewModel);
        void UpdateViatura(int id, ViaturaViewModel viaturaViewModel);
        List<Viatura> GetViaturasByGerenteId(int gerenteId);
    }
}
