using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.ViewModel;
using Infra.Interfaces;

namespace Domain.Service.Services
{
    public class CargoService : ICargoService
    {
        private readonly ICargoRepository _cargoRepository;
        private readonly INivelRepository _nivelRepository;

        public CargoService(ICargoRepository cargoRepository, INivelRepository nivelRepository)
        {
            _cargoRepository = cargoRepository;
            _nivelRepository = nivelRepository;
        }

        public List<Cargo> GetCargos()
        {
            return _cargoRepository.GetCargos();
        }

        public Cargo GetCargoById(int id)
        {
            return _cargoRepository.GetCargoById(id);
        }

        public void InsertCargo(CargoViewModel cargoViewModel)
        {
            var nivel = _nivelRepository.GetNivelById(cargoViewModel.nivelId);
            if (nivel == null) throw new Exception("Nivel inexistente.");

            var cargo = new Cargo
            {
                descricao = cargoViewModel.descricao,
                Nivel = nivel
            };

            _cargoRepository.InsertCargo(cargo);
        }

        public void UpdateCargo(int id, CargoViewModel cargoViewModel)
        {
            var originalCargo = _cargoRepository.GetCargoById(id);
            if (originalCargo == null)
                throw new Exception("Cargo nao existe.");

            var nivel = _nivelRepository.GetNivelById(cargoViewModel.nivelId);
            if (nivel == null) throw new Exception("Nivel inexistente.");

            originalCargo.descricao = cargoViewModel.descricao;
            originalCargo.Nivel = nivel;

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