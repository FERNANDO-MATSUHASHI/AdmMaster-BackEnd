using Application.Service.Interface;
using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.ViewModel;

namespace Application.Service.Application
{
    public class CargoApplication : ICargoApplication
    {
        private readonly ICargoService _cargoService;

        public CargoApplication(ICargoService cargoService)
        {
            _cargoService = cargoService;
        }

        public List<Cargo> GetCargos()
        {
            return _cargoService.GetCargos();
        }

        public Cargo GetCargoById(int id)
        {
            return _cargoService.GetCargoById(id);
        }

        public void InsertCargo(CargoViewModel cargoViewModel)
        {
            _cargoService.InsertCargo(cargoViewModel);
        }

        public void UpdateCargo(int id, CargoViewModel cargoViewModel)
        {
            _cargoService.UpdateCargo(id, cargoViewModel);
        }

        public void DeleteCargo(int id)
        {
            _cargoService.DeleteCargo(id);
        }
    }
}