using Domain.Entites;
using Domain.ViewModel;

namespace Application.Service.Interface
{
    public interface IVeiculoApplication
    {
        void DeleteVeiculo(int id);
        List<Veiculo> GetVeiculos();
        Veiculo GetVeiculoById(int id);
        void InsertVeiculo(VeiculoViewModel VeiculoViewModel);
        void UpdateVeiculo(int id, VeiculoViewModel VeiculoViewModel);
        List<Veiculo> GetVeiculosByGerenteId(int gerenteId);
    }
}
