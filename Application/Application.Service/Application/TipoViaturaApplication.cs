using Application.Service.Interface;
using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.Service.Services;
using Domain.ViewModel;

namespace Application.Service.Application
{
    public class TipoViaturaApplication : ITipoViaturaApplication
    {
        private readonly ITipoViaturaService _tipoViaturaService;

        public TipoViaturaApplication(ITipoViaturaService tipoViaturaService)
        {
            _tipoViaturaService = tipoViaturaService;
        }

        public List<Tipo_Viatura> GetTipoViaturas()
        {
            return _tipoViaturaService.GetTipoViaturas();
        }

        public Tipo_Viatura GetTipoViaturaById(int id)
        {
            return _tipoViaturaService.GetTipoViaturaById(id);
        }

        public void InsertTipoViatura(TipoViaturaViewModel TipoViaturaViewModel)
        {
            _tipoViaturaService.InsertTipoViatura(TipoViaturaViewModel);
        }

        public void UpdateTipoViatura(int id, TipoViaturaViewModel TipoViaturaViewModel)
        {
            _tipoViaturaService.UpdateTipoViatura(id, TipoViaturaViewModel);
        }

        public void DeleteTipoViatura(int id)
        {
            _tipoViaturaService.DeleteTipoViatura(id);
        }
        List<Tipo_Viatura> ITipoViaturaApplication.GetTipoViaturasByGerenteId(int gerenteId)
        {
            return _tipoViaturaService.GetTipoViaturasByGerenteId(gerenteId);
        }
    }
}
