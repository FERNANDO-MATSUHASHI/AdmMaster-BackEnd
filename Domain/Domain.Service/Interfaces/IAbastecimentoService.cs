using Domain.Entites;
using Domain.ViewModel;

namespace Domain.Service.Interfaces
{
    public interface IAbastecimentoService
    {
        void DeleteAbastecimento(int id);
        List<Abastecimento> GetAbastecimentos();
        Abastecimento GetAbastecimentoById(int id);
        void InsertAbastecimento(AbastecimentoViewModel abastecimentoViewModel);
        void UpdateAbastecimento(int id, AbastecimentoViewModel abastecimentoViewModel);
        List<Abastecimento> GetAbastecimentoGerenteById(int gerenteId);
    }
}
