using Domain.Entites;
using Domain.ViewModel;

namespace Domain.Service.Interfaces
{
    public interface ITipoVeiculoService
    {
        void DeleteTipoVeiculo(int id);
        List<Tipo_Veiculo> GetTipoVeiculos();
        Tipo_Veiculo GetTipoVeiculoById(int id);
        void InsertTipoVeiculo(TipoVeiculoViewModel tipoVeiculoViewModel);
        void UpdateTipoVeiculo(int id, TipoVeiculoViewModel tipoVeiculoViewModel);
        List<Tipo_Veiculo> GetTipoVeiculosByGerenteId(int gerenteId);
    }
}