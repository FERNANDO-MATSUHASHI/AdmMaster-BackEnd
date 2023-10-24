using Domain.Entites;
using Domain.ViewModel;

namespace Domain.Service.Interfaces
{
    public interface IVeiculoService
    {
        void DeleteVeiculo(int id);
        List<Veiculo> GetVeiculos();
        Veiculo GetVeiculoById(int id);
        void InsertVeiculo(VeiculoViewModel veiculoViewModel);
        void UpdateVeiculo(int id, VeiculoViewModel veiculoViewModel);
    }
}
