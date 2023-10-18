using Domain.Entites;
using Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

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
        public void InsertCargo(Cargo cargo, int idNivel)
        {
            try
            {
                _context.Cargos.Add(cargo);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateCargo(Cargo cargo)
        {
            try
            {
                _context.Entry(cargo).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteCargo(Cargo cargo)
        {
            try
            {
                _context.Set<Cargo>().Remove(cargo);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}