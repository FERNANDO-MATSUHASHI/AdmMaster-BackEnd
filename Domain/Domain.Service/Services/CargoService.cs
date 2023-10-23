using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.ViewModel;
using Infra.Interfaces;

namespace Domain.Service.Services
{
    public class CargoService : ICargoService
    {
        private readonly ICargoRepository _cargoRepository;

        public CargoService(ICargoRepository cargoRepository)
        {
            _cargoRepository = cargoRepository;
        }

        public List<Cargo> GetCargo()
        {
            return _cargoRepository.GetCargos();
        }

        public Cargo GetCargoById(int id)
        {
            return _cargoRepository.GetCargoById(id);
        }

        public void InsertCargo(CargoViewModel cargoViewModel)
        {
            var cargo = new Cargo
            {
                descricao = cargoViewModel.descricao
            };

            _cargoRepository.InsertCargo(cargo);
        }

        public void UpdateCargo(int id, CargoViewModel cargoViewModel)
        {
            var originalCargo = _cargoRepository.GetCargoById(id);
            if (originalCargo == null)
                throw new Exception("Cargo nao existe.");

            originalCargo.descricao = cargoViewModel.descricao;

            _cargoRepository.UpdateCargo(originalCargo);
        }

        public void DeleteCargo(int id)
        {
            var originalCargo = _cargoRepository.GetCargoById(id);
            if (originalCargo == null)
                throw new Exception("Cargo nao existe.");

            _cargoRepository.DeleteCargo(originalCargo);
        }
    }
}