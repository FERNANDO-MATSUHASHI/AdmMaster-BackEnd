using Domain.Entites;
using Domain.ViewModel;

namespace Domain.Service.Interfaces
{
    public interface IDespesasAtendimentoService
    {
        List<Despesas_Atendimento> GetDespesas();
        List<Despesas_Atendimento> GetDespesasByFilter(string? qru, DateTime? dataInicial, DateTime? dataFinal);
        Despesas_Atendimento GetDespesaById(int id);
        Viatura GetInfoViatura(int id);
        void InsertDespesa(Despesas_AtendimentoViewModel despesaViewModel);
        void UpdateDespesa(int id, Despesas_AtendimentoViewModel despesaViewModel);
        void DeleteDespesa(int id);
    }
}