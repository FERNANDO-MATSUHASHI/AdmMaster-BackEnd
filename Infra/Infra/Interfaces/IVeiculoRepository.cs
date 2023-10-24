using Domain.Entites;

namespace Infra.Interfaces
{
    public interface IVeiculoRepository
    {
        public List<Veiculo> GetVeiculos();
        public Veiculo GetVeiculoById(int id);
        public void InsertVeiculo(Veiculo veiculo);
        public void UpdateVeiculo(Veiculo veiculo);
        public void DeleteVeiculo(Veiculo veiculo);
    }
}