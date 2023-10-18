using Domain.Entites;

namespace Infra.Interfaces
{
    public interface ITipoVeiculoRepository
    {
        public List<Tipo_Veiculo> GetTipoVeiculo();
        public Tipo_Veiculo GetTipoVeiculoById(int id);
        public void InsertTipoVeiculo(Tipo_Veiculo tipoVeiculo);
        public void UpdateTipoVeiculo(Tipo_Veiculo tipoVeiculo);
        public void DeleteTipoVeiculo(Tipo_Veiculo tipoVeiculo);
    }
}