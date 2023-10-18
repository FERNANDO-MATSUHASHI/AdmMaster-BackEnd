using DDD.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmMaster.Infra.MemoryDb.Interfaces
{
    public interface ITipo_VeiculoRepository
    {
        public List<Tipo_Veiculo> GetTipoVeiculo();
        public Tipo_Veiculo GetTipoVeiculoById(int id);
        public void InsertTipoVeiculo(Tipo_Veiculo tipoVeiculo);
        public void UpdateTipoVeiculo(Tipo_Veiculo tipoVeiculo);
        public void DeleteTipoVeiculo(Tipo_Veiculo tipoVeiculo);
    }
}
