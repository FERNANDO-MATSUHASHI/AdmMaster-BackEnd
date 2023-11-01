using Domain.Entites;
using Domain.ViewModel;

namespace Domain.Service.Interfaces
{
    public interface IDespesasAtendimentoService
    {
        List<Despesas_Atendimento> GetDespesas();
        Despesas_Atendimento GetDespesaById(int id);
        void InsertDespesa(Despesas_AtendimentoViewModel despesaViewModel);
        void UpdateDespesa(int id, Despesas_AtendimentoViewModel despesaViewModel);
        void DeleteDespesa(int id);
    }
}