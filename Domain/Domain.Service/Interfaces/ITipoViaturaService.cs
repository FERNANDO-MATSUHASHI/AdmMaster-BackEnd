using Domain.Entites;
using Domain.ViewModel;

namespace Domain.Service.Interfaces
{
    public interface ITipoViaturaService
    {
        void DeleteTipoViatura(int id);
        List<Tipo_Viatura> GetTipoViaturas();
        Tipo_Viatura GetTipoViaturaById(int id);
        void InsertTipoViatura(TipoViaturaViewModel TipoViaturaViewModel);
        void UpdateTipoViatura(int id, TipoViaturaViewModel TipoViaturaViewModel);
        List<Tipo_Viatura> GetTipoViaturasByGerenteId(int gerenteId);
    }
}