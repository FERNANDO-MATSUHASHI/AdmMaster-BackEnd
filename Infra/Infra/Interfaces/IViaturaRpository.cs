using DDD.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmMaster.Infra.MemoryDb.Interfaces
{
    public interface IViaturaRepository
    {
        public List<Viatura> GetViatura();
        public Viatura GetViaturaById(int id);
        public void InsertViatura(Viatura viatura, int idTipoServico, int idTipoViatura, int idTipoVeiculo);
        public void UpdateViatura(Viatura viatura);
        public void DeleteViatura(Viatura viatura);
    }
}
