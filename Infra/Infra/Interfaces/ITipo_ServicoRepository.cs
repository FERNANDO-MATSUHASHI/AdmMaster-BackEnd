using DDD.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmMaster.Infra.MemoryDb.Interfaces
{
    public interface ITipo_ServicoRepository
    {
        public List<Tipo_Servico> GetTipoServico();
        public Tipo_Servico GetTipoServicoById(int id);
        public void InsertTipoServico(Tipo_Servico tipo_Servico);
        public void UpdateTipoServico(Tipo_Servico tipoServico);
        public void DeleteTipoServico(Tipo_Servico tipoServico);
    }
}
