using Domain.Entites;
using Domain.ViewModel;

namespace Domain.Service.Interfaces
{
    public interface ITipoServicoService
    {
        void DeleteTipoServico(int id);
        List<Tipo_Servico> GetTipoServicos();
        Tipo_Servico GetTipoServicoById(int id);
        void InsertTipoServico(TipoServicoViewModel tipoServicoViewModel);
        void UpdateTipoServico(int id, TipoServicoViewModel tipoServicoViewModel);
    }
}