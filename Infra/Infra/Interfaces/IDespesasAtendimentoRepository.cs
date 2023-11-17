using Domain.Entites;

namespace Infra.Interfaces
{
    public interface IDespesasAtendimentoRepository
    {
        public List<Despesas_Atendimento> GetDespesas();
        public List<Despesas_Atendimento> GetDespesasByFilter(string? qru, DateTime? dataInicial, DateTime? dataFinal);
        public Viatura GetInfoViatura(int id);
        public Despesas_Atendimento GetDespesaById(int id);
        public void InsertDespesa(Despesas_Atendimento despesa);
        public void UpdateDespesa(Despesas_Atendimento despesa);
        public void DeleteDespesa(Despesas_Atendimento despesa);
    }
}