using Application.Service.Interface;
using Domain.Entites;
using Domain.Service.Interfaces;
using Domain.ViewModel;

namespace Application.Service.Application
{
    public class DespesasAtendimentoApplication : IDespesasAtendimentoApplication
    {
        private readonly IDespesasAtendimentoApplication _despesaService;

        public DespesasAtendimentoApplication(IDespesasAtendimentoApplication despesaService)
        {
            _despesaService = despesaService;
        }

        public List<Despesas_Atendimento> GetDespesas()
        {
            return _despesaService.GetDespesas();
        }

        public Despesas_Atendimento GetDespesaById(int id)
        {
            return _despesaService.GetDespesaById(id);
        }

        public void InsertDespesa(Despesas_AtendimentoViewModel despesaViewModel)
        {
            _despesaService.InsertDespesa(despesaViewModel);
        }

        public void UpdateDespesa(int id, Despesas_AtendimentoViewModel despesaViewModel)
        {
            _despesaService.UpdateDespesa(id, despesaViewModel);
        }

        public void DeleteDespesa(int id)
        {
            _despesaService.DeleteDespesa(id);
        }
    }
}