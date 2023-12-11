using Application.Service.Interface;
using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.Service.Services;
using Domain.ViewModel;

namespace Application.Service.Application
{
    public class TipoServicoApplication : ITipoServicoApplication
    {
        private readonly ITipoServicoService _tipoServicoService;

        public TipoServicoApplication(ITipoServicoService tipoServicoService)
        {
            _tipoServicoService = tipoServicoService;
        }

        public List<Tipo_Servico> GetTipoServicos()
        {
            return _tipoServicoService.GetTipoServicos();
        }

        public Tipo_Servico GetTipoServicoById(int id)
        {
            return _tipoServicoService.GetTipoServicoById(id);
        }

        public void InsertTipoServico(TipoServicoViewModel TipoServicoViewModel)
        {
            _tipoServicoService.InsertTipoServico(TipoServicoViewModel);
        }

        public void UpdateTipoServico(int id, TipoServicoViewModel TipoServicoViewModel)
        {
            _tipoServicoService.UpdateTipoServico(id, TipoServicoViewModel);
        }

        public void DeleteTipoServico(int id)
        {
            _tipoServicoService.DeleteTipoServico(id);
        }
        List<Tipo_Servico> ITipoServicoApplication.GetTipoServicosByGerenteId(int gerenteId)
        {
            return _tipoServicoService.GetTipoServicosByGerenteId(gerenteId);
        }
    }
}