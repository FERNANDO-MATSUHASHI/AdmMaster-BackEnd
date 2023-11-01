using Domain.Entites;
using Domain.ViewModel;

namespace Application.Service.Interface
{
    public interface IDespesasAtendimentoApplication
    {       
        List<Despesas_Atendimento> GetDespesas();
        Despesas_Atendimento GetDespesaById(int id);
        void InsertDespesa(Despesas_AtendimentoViewModel despesaViewModel);
        void UpdateDespesa(int id, Despesas_AtendimentoViewModel despesaViewModel);
        void DeleteDespesa(int id);
    }
}