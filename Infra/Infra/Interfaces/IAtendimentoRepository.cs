using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmMaster.Infra.MemoryDb.Interfaces
{
    public interface IAtendimentoRepository
    {
        public List<Atendimento> GetAtendimentos();
        public Atendimento GetAtendimentoById(int id);
        public void InsertAtendimento(Atendimento atendimento, int idViatura, int idUsuario);
        public void UpdateAtendimento(Atendimento atendimento);
        public void DeleteAtendimento(Atendimento atendimento);
    }
}
