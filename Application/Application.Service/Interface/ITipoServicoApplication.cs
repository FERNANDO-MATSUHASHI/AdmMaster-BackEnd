using Domain.Entites;
using Domain.ViewModel;

namespace Application.Service.Interface
{
    public interface ITipoServicoApplication
    {
        void DeleteTipoServico(int id);
        List<Tipo_Servico> GetTipoServicos();
        Tipo_Servico GetTipoServicoById(int id);
        void InsertTipoServico(TipoServicoViewModel tipoServicoViewModel);
        void UpdateTipoServico(int id, TipoServicoViewModel tipoServicoViewModel);
    }
}