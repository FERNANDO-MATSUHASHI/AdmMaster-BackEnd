using Domain.Entites;
using Domain.ViewModel;

namespace Domain.Service.Interfaces
{
    public interface ICargoService
    {
        void DeleteCargo(int id);
        List<Cargo> GetCargo();
        Cargo GetCargoById(int id);
        void InsertCargo(CargoViewModel cargoViewModel);
        void UpdateCargo(int id, CargoViewModel cargoViewModel);
    }
}