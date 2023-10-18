using DDD.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmMaster.Infra.MemoryDb.Interfaces
{
    public interface ITipo_ViaturaRepository
    {
        public List<Tipo_Viatura> GetTipoViatura();
        public Tipo_Viatura GetTipoViaturaById(int id);
        public void InsertTipoViatura(Tipo_Viatura tipoViatura);
        public void UpdateTipoViatura(Tipo_Viatura tipoViatura);
        public void DeleteTipoViatura(Tipo_Viatura tipoViatura);
    }
}
