using Domain.Entites;
using Domain.ViewModel;

namespace Domain.Service.Interfaces
{
    public interface IManutencaoService
    {
        void DeleteManutencao(int id);
        List<Manutencao> GetManutencoes();
        Manutencao GetManutencaoById(int id);
        void InsertManutencao(ManutencaoViewModel manutencaoViewModel);
        void UpdateManutencao(int id, ManutencaoViewModel manutencaoViewModel);
        List<Manutencao> GetManutencaoGerenteById(int gerenteId);
    }
}
