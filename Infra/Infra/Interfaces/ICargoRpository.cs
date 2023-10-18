using DDD.Domain.Entites;
using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmMaster.Infra.MemoryDb.Interfaces
{
    public interface ICargoRepository
    {
        public List<Cargo> GetCargos();
        public Cargo GetCargoById(int id);
        public void InsertCargo(Cargo cargo, int idNivel);
        public void UpdateCargo(Cargo cargo);
        public void DeleteCargo(Cargo cargo);
    }
}
