using Domain.Entites;
using Infra.Interfaces;

namespace Infra.Repositories
{
    public class CargoRepository : ICargoRepository
    {
        private readonly SqlContext _context;

        public CargoRepository(SqlContext context)
        {
            _context = context;
        }

        public List<Cargo> GetCargos()
        {
            return _context.Cargos.ToList();
        }

        public Cargo GetCargoById(int id)
        {
            return _context.Cargos.Find(id);
        }
        public void InsertCargo(Cargo cargo)
        {
            _context.Cargos.Add(cargo);
            _context.SaveChanges();
        }
        public void UpdateCargo(Cargo cargo)
        {
            _context.Cargos.Update(cargo);
            _context.SaveChanges();
        }
        public void DeleteCargo(Cargo cargo)
        {
            _context.Cargos.Remove(cargo);
            _context.SaveChanges();
        }
    }
}