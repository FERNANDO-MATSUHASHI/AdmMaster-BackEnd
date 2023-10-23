using Application.Service.Interface;
using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.ViewModel;

namespace Application.Service.Application
{
    public class TipoVeiculoApplication : ITipoVeiculoApplication
    {
        private readonly ITipoVeiculoService _tipoVeiculoService;

        public TipoVeiculoApplication(ITipoVeiculoService tipoVeiculoService)
        {
            _tipoVeiculoService = tipoVeiculoService;
        }

        public List<Tipo_Veiculo> GetTipoVeiculos()
        {
            return _tipoVeiculoService.GetTipoVeiculos();
        }

        public Tipo_Veiculo GetTipoVeiculoById(int id)
        {
            return _tipoVeiculoService.GetTipoVeiculoById(id);
        }

        public void InsertTipoVeiculo(TipoVeiculoViewModel tipoVeiculoViewModel)
        {
            _tipoVeiculoService.InsertTipoVeiculo(tipoVeiculoViewModel);
        }

        public void UpdateTipoVeiculo(int id, TipoVeiculoViewModel tipoVeiculoViewModel)
        {
            _tipoVeiculoService.UpdateTipoVeiculo(id, tipoVeiculoViewModel);
        }

        public void DeleteTipoVeiculo(int id)
        {
            _tipoVeiculoService.DeleteTipoVeiculo(id);
        }
    }
}