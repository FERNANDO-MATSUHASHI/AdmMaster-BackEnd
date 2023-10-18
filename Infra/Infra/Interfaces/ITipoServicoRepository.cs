using Domain.Entites;

namespace Infra.Interfaces
{
    public interface ITipoServicoRepository
    {
        public List<Tipo_Servico> GetTipoServico();
        public Tipo_Servico GetTipoServicoById(int id);
        public void InsertTipoServico(Tipo_Servico tipo_Servico);
        public void UpdateTipoServico(Tipo_Servico tipoServico);
        public void DeleteTipoServico(Tipo_Servico tipoServico);
    }
}