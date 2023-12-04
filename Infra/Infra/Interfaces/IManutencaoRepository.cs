using Domain.Entites;

namespace Infra.Interfaces
{
    public interface IManutencaoRepository
    {
        public List<Manutencao> GetManutencoes();
        public Manutencao GetManutencaoById(int id);
        public void InsertManutencao(Manutencao manutencao);
        public void UpdateManutencao(Manutencao manutencao);
        public void DeleteManutencao(Manutencao manutencao);
        public List<Manutencao> GetManutencaoGerenteById(int id);
    }
}