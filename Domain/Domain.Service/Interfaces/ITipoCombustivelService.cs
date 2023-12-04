using Domain.Entites;
using Domain.ViewModel;

namespace Domain.Service.Interfaces
{
    public interface ITipoCombustivelService
    {
        void DeleteTipoCombustivel(int id);
        List<Tipo_Combustivel> GetTipoCombustiveis();
        Tipo_Combustivel GetTipoCombustivelById(int id);
        void InsertTipoCombustivel(TipoCombustivelViewModel TipoCombustivelViewModel);
        void UpdateTipoCombustivel(int id, TipoCombustivelViewModel TipoCombustivelViewModel);
    }
}