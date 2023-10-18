using DDD.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmMaster.Infra.MemoryDb.Interfaces
{
    public interface IVeiculoRepository
    {
        public List<Veiculo> GetVeiculo();
        public Veiculo GetVeiculoById(int id);
        public void InsertVeiculo(Veiculo veiculo, int idTipoVeiculo);
        public void UpdateVeiculo(Veiculo veiculo);
        public void DeleteVeiculo(Veiculo veiculo);
    }
}
