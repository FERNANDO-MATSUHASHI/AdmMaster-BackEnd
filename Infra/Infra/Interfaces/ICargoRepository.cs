using Domain.Entites;

namespace Infra.Interfaces
{
    public interface ICargoRepository
    {
        public List<Cargo> GetCargos();
        public Cargo GetCargoById(int id);
        public void InsertCargo(Cargo cargo);
        public void UpdateCargo(Cargo cargo);
        public void DeleteCargo(Cargo cargo);
    }
}