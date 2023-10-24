using Domain.Entites;
using Domain.ViewModel;

namespace Application.Service.Interface
{
    public interface ICargoApplication
    {
        void DeleteCargo(int id);
        List<Cargo> GetCargos();
        Cargo GetCargoById(int id);
        void InsertCargo(CargoViewModel cargoViewModel);
        void UpdateCargo(int id, CargoViewModel cargoViewModel);
    }
}