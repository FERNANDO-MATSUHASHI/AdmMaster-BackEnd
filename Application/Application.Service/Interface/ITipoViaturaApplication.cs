using Domain.Entites;
using Domain.ViewModel;

namespace Application.Service.Interface
{
    public interface ITipoViaturaApplication
    {
        void DeleteTipoViatura(int id);
        List<Tipo_Viatura> GetTipoViaturas();
        Tipo_Viatura GetTipoViaturaById(int id);
        void InsertTipoViatura(TipoViaturaViewModel TipoViaturaViewModel);
        void UpdateTipoViatura(int id, TipoViaturaViewModel TipoViaturaViewModel);
        List<Tipo_Viatura> GetTipoViaturasByGerenteId(int gerenteId);
    }
}