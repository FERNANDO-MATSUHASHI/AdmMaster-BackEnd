using Domain.Entites;

namespace Infra.Interfaces
{
    public interface IAbastecimentoRepository
    {
        public List<Abastecimento> GetAbastecimentos();
        public Abastecimento GetAbastecimentoById(int id);
        public void InsertAbastecimento(Abastecimento abastecimento);
        public void UpdateAbastecimento(Abastecimento abastecimento);
        public void DeleteAbastecimento(Abastecimento abastecimento);
        public List<Abastecimento> GetAbastecimentoGerenteById(int id);
        public List<Abastecimento> GetAbastecimentosByFilter(int? fornecedorId, int gerenteId, DateTime? dataInicial, DateTime? dataFinal);
    }
}