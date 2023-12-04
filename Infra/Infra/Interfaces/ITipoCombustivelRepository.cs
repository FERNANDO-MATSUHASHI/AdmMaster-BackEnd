using Domain.Entites;

namespace Infra.Interfaces
{
    public interface ITipoCombustivelRepository
    {
        public List<Tipo_Combustivel> GetTipoCombustiveis();
        public Tipo_Combustivel GetTipoCombustivelById(int id);
        public void InsertTipoCombustivel(Tipo_Combustivel tipo_Combustivel);
        public void UpdateTipoCombustivel(Tipo_Combustivel tipo_Combustivel);
        public void DeleteTipoCombustivel(Tipo_Combustivel tipo_Combustivel);
    }
}