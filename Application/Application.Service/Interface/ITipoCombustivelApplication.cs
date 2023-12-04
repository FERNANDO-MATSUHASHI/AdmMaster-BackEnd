using Domain.Entites;
using Domain.ViewModel;

namespace Application.Service.Interface
{
    public interface ITipoCombustivelApplication
    {
        void DeleteTipoCombustivel(int id);
        List<Tipo_Combustivel> GetTipoCombustiveis();
        Tipo_Combustivel GetTipoCombustivelById(int id);
        void InsertTipoCombustivel(TipoCombustivelViewModel tipoCombustivelaViewModel);
        void UpdateTipoCombustivel(int id, TipoCombustivelViewModel tipoCombustivelaViewModel);
    }
}