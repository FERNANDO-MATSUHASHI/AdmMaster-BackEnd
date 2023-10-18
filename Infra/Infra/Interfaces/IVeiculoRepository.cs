using Domain.Entites;

namespace Infra.Interfaces
{
    public interface IVeiculoRepository
    {
        public List<Veiculo> GetVeiculo();
        public Veiculo GetVeiculoById(int id);
        public void InsertVeiculo(Veiculo veiculo, int idTipoVeiculo);
        public void UpdateVeiculo(Veiculo veiculo);
        public void DeleteVeiculo(Veiculo veiculo);
    }
}