using Domain.Entites;
using Domain.ViewModel;

namespace Application.Service.Interface
{
    public interface IAbastecimentoApplication
    {
        void DeleteAbastecimento(int id);
        List<Abastecimento> GetAbastecimentos();
        Abastecimento GetAbastecimentoById(int id);
        void InsertAbastecimento(AbastecimentoViewModel abastecimentoViewModel);
        void UpdateAbastecimento(int id, AbastecimentoViewModel abastecimentoViewModel);
        List<Abastecimento> GetAbastecimentoGerenteById(int gerenteId);
    }
}
