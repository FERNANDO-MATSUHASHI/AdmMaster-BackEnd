using Application.Service.Interface;
using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.Service.Services;
using Domain.ViewModel;

namespace Application.Service.Application
{
    public class VeiculoApplication : IVeiculoApplication
    {
        public readonly IVeiculoService _veiculoService;

        public VeiculoApplication(IVeiculoService veiculoService)
        {
            _veiculoService = veiculoService;
        }

        public List<Veiculo> GetVeiculos()
        {
            return _veiculoService.GetVeiculos();
        }

        public Veiculo GetVeiculoById(int id)
        {
            return _veiculoService.GetVeiculoById(id);
        }

        public void InsertVeiculo(VeiculoViewModel VeiculoViewModel)
        {
            _veiculoService.InsertVeiculo(VeiculoViewModel);
        }

        public void UpdateVeiculo(int id, VeiculoViewModel VeiculoViewModel)
        {
            _veiculoService.UpdateVeiculo(id, VeiculoViewModel);
        }

        public void DeleteVeiculo(int id)
        {
            _veiculoService.DeleteVeiculo(id);
        }
        List<Veiculo> IVeiculoApplication.GetVeiculosByGerenteId(int gerenteId)
        {
            return _veiculoService.GetVeiculosByGerenteId(gerenteId);
        }
    }
}