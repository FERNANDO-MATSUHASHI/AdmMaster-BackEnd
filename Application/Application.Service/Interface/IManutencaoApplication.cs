using Domain.Entites;
using Domain.ViewModel;

namespace Application.Service.Interface
{
    public interface IManutencaoApplication
    {
        void DeleteManutencao(int id);
        List<Manutencao> GetManutencoes();
        Manutencao GetManutencaoById(int id);
        void InsertManutencao(ManutencaoViewModel manutencaoViewModel);
        void UpdateManutencao(int id, ManutencaoViewModel manutencaoViewModel);
        List<Manutencao> GetManutencaoGerenteById(int gerenteId);
    }
}
