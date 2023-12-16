using Application.Service.Interface;
using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.Service.Services;
using Domain.ViewModel;

namespace Application.Service.Application
{
    public class TipoCombustivelApplication : ITipoCombustivelApplication
    {
        private readonly ITipoCombustivelService _tipoCombustivelService;

        public TipoCombustivelApplication(ITipoCombustivelService tipoCombustivelService)
        {
            _tipoCombustivelService = tipoCombustivelService;
        }

        public List<Tipo_Combustivel> GetTipoCombustiveis()
        {
            return _tipoCombustivelService.GetTipoCombustiveis();
        }

        public Tipo_Combustivel GetTipoCombustivelById(int id)
        {
            return _tipoCombustivelService.GetTipoCombustivelById(id);
        }

        public void InsertTipoCombustivel(TipoCombustivelViewModel tipoCombustivelViewModel)
        {
            _tipoCombustivelService.InsertTipoCombustivel(tipoCombustivelViewModel);
        }

        public void UpdateTipoCombustivel(int id, TipoCombustivelViewModel tipoCombustivelViewModel)
        {
            _tipoCombustivelService.UpdateTipoCombustivel(id, tipoCombustivelViewModel);
        }

        public void DeleteTipoCombustivel(int id)
        {
            _tipoCombustivelService.DeleteTipoCombustivel(id);
        }
        public List<Tipo_Combustivel> GetTipo_CombustivelGerenteById(int gerenteId)
        {
            return _tipoCombustivelService.GetTipo_CombustivelGerenteById(gerenteId);
        }
    }
}
