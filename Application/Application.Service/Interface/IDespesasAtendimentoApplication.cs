using Domain.Entites;
using Domain.ViewModel;

namespace Application.Service.Interface
{
    public interface IDespesasAtendimentoApplication
    {
        List<Despesas_Atendimento> GetDespesas();
        List<Despesas_Atendimento> GetDespesasByFilter(string? qru, DateTime? dataInicial, DateTime? dataFinal);
        Despesas_Atendimento GetDespesaById(int id);
        Viatura GetInfoViatura(int id);
        void InsertDespesa(Despesas_AtendimentoViewModel despesaViewModel);
        void UpdateDespesa(int id, Despesas_AtendimentoViewModel despesaViewModel);
        void DeleteDespesa(int id);
        List<Despesas_Atendimento> GetDespesaGerenteById(int gerenteId);
    }
}